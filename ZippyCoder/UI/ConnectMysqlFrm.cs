using ChurSkins;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZippyCoder.Entity;

namespace ZippyCoder
{
    public partial class ConnectMysqlFrm : CForm
    {

        private Project project;
        private MainFrm _Owner;
        public ConnectMysqlFrm(MainFrm owner)
        {
            this._Owner = owner;
            project = new Project();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTryConnect_Click(object sender, EventArgs e)
        {
            //ddlDatabase.Items.Clear();
            string conStr1 = "Server={0};Port={1};Uid={2};Pwd={3};";
            //string conStr2 = "Persist Security Info=False;Integrated Security=true;Server={0};Initial Catalog=master";
            string conStr = "";
            if (string.IsNullOrEmpty(txtHost.Text.Trim()) || string.IsNullOrEmpty(txtPort.Text.Trim()) || string.IsNullOrEmpty(txtUser.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                CMessageBox.Show(this, "服务器信息没填写完整。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conStr = string.Format(conStr1, txtHost.Text.Trim(), txtPort.Text.Trim(), txtUser.Text.Trim(), txtPassword.Text.Trim());

            MySqlConnection con = new MySqlConnection(conStr);
            try
            {

                con.Open();
            }
            catch (Exception ex)
            {
                CMessageBox.Show(ex.Message);
                return;
            }
            MySqlCommand cmd = new MySqlCommand("show databases", con);
            IDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comDatabaseList.Items.Add(reader.GetString(0));
            }
            reader.Close();
            con.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comDatabaseList.Text)) return;

            project.Namespace = comDatabaseList.Text;
            project.Title = comDatabaseList.Text;

            string conStr1 = "Server={0};Port={1};Uid={2};Pwd={3};Database={4}";

            if (string.IsNullOrEmpty(txtHost.Text.Trim()) || string.IsNullOrEmpty(txtPort.Text.Trim()) || string.IsNullOrEmpty(txtUser.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                CMessageBox.Show(this, "服务器信息没填写完整。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string conStr = string.Format(conStr1, txtHost.Text.Trim(), txtPort.Text.Trim(), txtUser.Text.Trim(), txtPassword.Text.Trim(), comDatabaseList.Text);

            //  CessageBox.Show(conStr);

            MySqlConnection con = new MySqlConnection(conStr);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                CMessageBox.Show(ex.Message);
                return;
            }

            List<string> tableNames = new List<string>();
            MySqlCommand cmd = new MySqlCommand("show tables", con);
            IDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tableNames.Add(reader.GetString(0));
            }
            reader.Close();

            #region 查询列结构
            foreach (string strTableName in tableNames)
            {
                ZippyCoder.Entity.Table table = new ZippyCoder.Entity.Table();
                table.Name = strTableName;
                //查询表的备注  by chuchur 2014年9月22日 16:18:37
                string sqlTableComment = "SELECT table_name, TABLE_COMMENT FROM INFORMATION_SCHEMA.TABLES  WHERE table_name ='" + strTableName + "'";
                MySqlCommand cmdTableComment = new MySqlCommand(sqlTableComment, con);
                IDataReader readerTableComment = cmdTableComment.ExecuteReader();
                while (readerTableComment.Read())
                {
                    if (readerTableComment.GetValue(1) != null)
                    {
                        table.Remark = readerTableComment.GetValue(1).ToString();
                        table.Title = (table.Remark.Length > 15) ? table.Remark.Substring(0, 15) + "..." : table.Remark;
                    }
                    else
                    {
                        table.Remark = "这家伙很懒,毛都没留一根....";
                        table.Title = strTableName;
                    }
                }
                readerTableComment.Dispose();

                project.Tables.Add(table);

                //声明列..
                //List<ZippyCoder.Entity.Col> fkCols = new List<ZippyCoder.Entity.Col>();

                //查询列名的备注 by chuchur 2014年9月22日 16:18:41
                string sqlColComment = "SELECT COLUMN_NAME ,COLUMN_COMMENT FROM INFORMATION_SCHEMA.COLUMNS where table_name='" + strTableName + "'";
                MySqlCommand cmdColComment = new MySqlCommand(sqlColComment, con);
                IDataReader readerColComment = cmdColComment.ExecuteReader();

                Dictionary<string, string> Cols = new Dictionary<string, string>();
                //取得字段和字段备注
                while (readerColComment.Read())
                {
                    string colName = string.Empty, colRemark = string.Empty;
                    if (readerColComment.GetValue(0) != null)
                        colName = readerColComment.GetValue(0).ToString();
                    if (readerColComment.GetValue(1) != null)
                        colRemark = readerColComment.GetValue(1).ToString();
                    if (!Cols.Keys.Contains(colName))
                        Cols.Add(colName, colRemark == "" ? colName : colRemark);
                }
                readerColComment.Dispose();
                foreach (var s in Cols)
                {
                    ZippyCoder.Entity.Col col = table.Exists(s.Key);
                    if (col == null)
                    {
                        col = new ZippyCoder.Entity.Col();
                        table.Cols.Add(col);
                        col.Parent = table;
                    }
                    col.Name = s.Key;
                    col.Remark = s.Value;
                    col.Title = s.Value;
                }


                //查询列名
                string sql = "SHOW COLUMNS FROM " + strTableName;
                MySqlCommand cmdColProperty = new MySqlCommand(sql, con);
                IDataReader readerCol = cmdColProperty.ExecuteReader();


                while (readerCol.Read())
                {
                    object _colName = readerCol.GetValue(0);
                    object _mysqlType = readerCol.GetValue(1);
                    object _canNull = readerCol.GetValue(2);
                    object _isKey = readerCol.GetValue(3);
                    object _defVal = readerCol.GetValue(4);
                    object _extra = readerCol.GetValue(5);
                    string colName = _colName == null ? "" : _colName.ToString();
                    string mysqlType = _mysqlType == null ? "" : _mysqlType.ToString();
                    string canNull = _canNull == null ? "" : _canNull.ToString();
                    string isKey = _isKey == null ? "" : _isKey.ToString();
                    string defVal = _defVal == null ? "" : _defVal.ToString();
                    string extra = _extra == null ? "" : _extra.ToString();
                    string dataType = string.Empty, dataLen = string.Empty;
                    var match = System.Text.RegularExpressions.Regex.Match(mysqlType, @"([\w]+).*?([\d\,]+).*");
                    var matchCount = match.Groups.Count;
                    if (matchCount > 1)
                        dataType = match.Groups[1].Value;
                    if (matchCount > 2)
                        dataLen = match.Groups[2].Value;

                    if (string.IsNullOrEmpty(dataType))
                        dataType = mysqlType;



                    ZippyCoder.Entity.Col col = table.Exists(colName);
                    if (col == null)
                    {
                        col = new ZippyCoder.Entity.Col();
                        table.Cols.Add(col);
                        col.Parent = table;
                    }
                    col.Name = colName;
                    //col.Title = colName;
                    col.DataType = ZippyCoder.TypeConverter.ToSqlDbType(dataType);
                    col.Default = (defVal == "NULL" ? "" : defVal);
                    col.Length = dataLen;
                    col.IsPK = (isKey != null && isKey.ToLower() == "pri");
                    col.IsNull = (canNull != null && canNull.ToLower() == "yes");
                    col.AutoIncrease = (extra != null && extra.ToLower() == "auto_increment");
                }
                readerCol.Close();

            }

            #endregion

            con.Close();

            //_Owner.Project = project;
            //_Owner.UpdateUI();

            TreeFrm _treeFrm = new TreeFrm(_Owner);

            _treeFrm.Project = project;
            _treeFrm.UpdateUI();
            _treeFrm.Text = project.Namespace + " - 基础数据结构";
            _treeFrm.Show();
            this.Close();
        }
    }
}

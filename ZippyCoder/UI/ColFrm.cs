using ChurSkins;
using System;
using System.Windows.Forms;
using ZippyCoder.Entity;

namespace ZippyCoder
{
    public partial class ColFrm : CForm
    {
        public ColFrm(MainFrm owner, TreeFrm treeFrm)
        {
            InitializeComponent();
            _Owner = owner;
            _treeFrm = treeFrm;
            //this.MdiParent = _Owner;
            tbxDataType.DataSource = Enum.GetNames(typeof(System.Data.SqlDbType));
            this.tbxName.LostFocus += new System.EventHandler(tbxName_LostFocus);
        }
        private string oldColName = string.Empty; //记录修改前的 col，改变列名 sql稍有变化

        private TreeFrm _treeFrm;
        private MainFrm _Owner;
        private Project _Project;
        public Project Project
        {
            get { return _Project; }
            set
            {
                _Project = value;
                BindFKTable();
            }
        }
        private void BindFKTable()
        {
            tbxFKTable.Items.Clear();
            //tbxFKCol.Items.Clear();
            tbxFKTable.Items.Add("不映射");
            foreach (Table table in _Project.Tables)
            {
                tbxFKTable.Items.Add(table.Name);
            }
        }
        private void BindFKCol(ComboBox cbx, string tableName, string colName)
        {
            Table table = _Project.FindTable(tableName);
            if (table != null)
            {
                foreach (Col col in table.Cols)
                {
                    cbx.Items.Add(col.Name);
                }
                cbx.SelectedValue = colName;
            }
        }
        private Col _Col;
        public Col Col
        {
            get
            {
                if (_Col == null)
                    _Col = new Col();

                _Col.Name = tbxName.Text;

                _Col.Title = tbxTitle.Text;
                if (string.IsNullOrEmpty(_Col.Title))
                    _Col.Title = _Col.Name;
                _Col.Remark = tbxRemark.Text;
                _Col.Default = tbxDefault.Text;
                _Col.Length = tbxLength.Text;
                _Col.IsNull = cbxIsNull.Checked;
                _Col.IsPK = cbxPK.Checked;
                _Col.AutoIncrease = cbxAutoIncreament.Checked;
                _Col.Unique = cbxUnique.Checked;
                _Col.FkDeleteCascade = cbxFKDeleteCascade.Checked;
                _Col.FkWithNoCheck = cbxFKNoCheck.Checked;
                _Col.DataType = (System.Data.SqlDbType)Enum.Parse(typeof(System.Data.SqlDbType), tbxDataType.SelectedValue.ToString());
                if (tbxFKTable.SelectedIndex > 0 && tbxFKCol.SelectedIndex >= 0)
                {
                    _Col.RefTable = tbxFKTable.SelectedValue.ToString();
                    _Col.RefCol = tbxFKCol.SelectedValue.ToString();
                    if (tbxFKColTitle.SelectedIndex >= 0)
                        _Col.RefColTextField = tbxFKColTitle.SelectedValue.ToString();
                    else
                        _Col.RefColTextField = tbxFKCol.SelectedValue.ToString();
                }
                else
                {
                    _Col.RefTable = string.Empty;
                    _Col.RefCol = string.Empty;
                }
                _Col.IsIndex = cbxIsIndex.Checked;
                return _Col;
            }
            set
            {
                oldColName = value.Name;
                tbxName.Text = value.Name;
                //tbxName.Focus();
                tbxTitle.Text = value.Title;
                tbxRemark.Text = value.Remark;
                tbxDefault.Text = value.Default;
                tbxLength.Text = value.Length;
                cbxAutoIncreament.Checked = value.AutoIncrease;
                cbxIsNull.Checked = value.IsNull;
                cbxPK.Checked = value.IsPK;
                cbxUnique.Checked = value.Unique;
                //tbxDataType.SelectedValue = value.DataType.ToString();
                //tbxRenderType.SelectedItem = value.RenderType.ToString();
                //tbxEnumType.Text = value.EnumType;
                //tbxResoureType.Text = value.ResourceType;
                cbxFKNoCheck.Checked = value.FkWithNoCheck;
                cbxFKDeleteCascade.Checked = value.FkDeleteCascade;
                cbxIsIndex.Checked = value.IsIndex;
                /*tbxWidthPx.Text = value.WidthPx.ToString();
                if ((value.UIColType & UIColTypes.Editable) == UIColTypes.Editable)
                {
                    cbxEditable.IsChecked = true;
                }
                else
                {
                    cbxEditable.IsChecked = false;
                }
                if ((value.UIColType & UIColTypes.Detailable) == UIColTypes.Detailable)
                {
                    cbxDetailable.IsChecked = true;
                }
                else
                {
                    cbxDetailable.IsChecked = false;
                }
                if ((value.UIColType & UIColTypes.Listable) == UIColTypes.Listable)
                {
                    cbxListable.IsChecked = true;
                }
                else
                {
                    cbxListable.IsChecked = false;
                }
                if ((value.UIColType & UIColTypes.Queryable) == UIColTypes.Queryable)
                {
                    cbxQueryable.IsChecked = true;
                }
                else
                {
                    cbxQueryable.IsChecked = false;
                }
                if ((value.UIColType & UIColTypes.Sortable) == UIColTypes.Sortable)
                {
                    cbxSortable.IsChecked = true;
                }
                else
                {
                    cbxSortable.IsChecked = false;
                }
                */

                BindFKTable();


                if (value.RefTable != null)
                {
                    tbxFKTable.SelectedValue = value.RefTable;
                    BindFKCol(tbxFKCol, value.RefTable, value.RefCol);
                    BindFKCol(tbxFKColTitle, value.RefTable, value.RefColTextField);
                }
                /*
                if (string.IsNullOrEmpty(value.CssClassLength) && value.RenderType == RenderTypes.TextBox) value.CssClassLength = "w100";
                tbxCssClassLength.Text = value.CssClassLength;
                if (string.IsNullOrEmpty(value.CssClass) && value.RenderType == RenderTypes.TextBox) value.CssClass = "textBox";
                tbxCssClass.Text = value.CssClass;
                */

                _Col = value;
            }
        }


        private void tbxName_LostFocus(object sender, EventArgs e)
        {
            if (tbxName.Text == "Title" && string.IsNullOrEmpty(tbxTitle.Text))
            {
                tbxTitle.Text = "标题";
                tbxDataType.SelectedValue = "NVarChar";
                tbxLength.Text = "300";
            }
            else if (tbxName.Text.EndsWith("ID") && string.IsNullOrEmpty(tbxTitle.Text))
            {
                tbxTitle.Text = "编号";
                tbxDataType.SelectedValue = "BigInt";
            }
            else if ((tbxName.Text.EndsWith("Date") || tbxName.Text.StartsWith("Date")) && string.IsNullOrEmpty(tbxTitle.Text))
            {
                tbxTitle.Text = "日期";
                tbxDataType.SelectedValue = "DateTime";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Col.Name))
            {
                CMessageBox.Show(_Owner, "列名不能为空", "错误提示");
                return;
            }
            //try
            //{
            _treeFrm.UpdateColNode(Col);
            _treeFrm.WriteSqlLog(_Col, oldColName);
            //}
            //catch (Exception ex)
            //{
            //    CMessageBox.Show(_Owner, ex.Message, "发生错误", , MessageBoxButtons.OK,MessageBoxIcon.Error);
            //   return;
            // }
            this.Close();
            //this.Visible = false;
            //_treeFrm.Operation = ChangeTypes.None;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //   this.Visible = false;
        }
    }
}
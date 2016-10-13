using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ZippyCoder.Logic
{
    public class Helpler
    {
        /// <summary>
        /// 改变窗体标题
        /// </summary>
        /// <param name="saved"></param>
        /// <param name="treeFrm"></param>
        public static void ChangeTitle(bool saved, TreeFrm treeFrm)
        {
            if (treeFrm.Text.StartsWith("*") && saved)
            {
                treeFrm.Text = treeFrm.Text.Substring(1, treeFrm.Text.Length - 1);
            }
            else if (!treeFrm.Text.StartsWith("*") && !saved)
            {
                treeFrm.Text = "*" + treeFrm.Text;
            }
        }

        /// <summary>
        /// 新建懒人列
        /// </summary>
        /// <param name="tviTable"></param>
        /// <param name="table"></param>
        public static void CreateLazyCols(TreeNode tviTable, ZippyCoder.Entity.Table table)
        {
            TreeNode tviCol;
            ZippyCoder.Entity.Col col;

            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = table.Name + "ID";
            col.IsPK = true;
            col.IsNull = false;
            col.Unique = true;
            col.AutoIncrease = true;
            col.CssClass = "textBox";
            col.CssClassLength = "w1";
            col.DataType = System.Data.SqlDbType.BigInt;
            col.Title = table.Title + "编号";
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable | ZippyCoder.Entity.UIColTypes.Listable | ZippyCoder.Entity.UIColTypes.Sortable;
            tviCol = new TreeNode();
            tviCol.Text = table.Title + "编号[" + table.Name + "ID]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);


            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = "TenantID";
            col.IsPK = false;
            col.IsNull = false;
            col.Unique = false;
            col.AutoIncrease = false;
            col.IsIndex = true;
            col.Default = "'00000000-0000-0000-0000-000000000000'";
            col.CssClass = "";
            col.CssClassLength = "";
            col.DataType = System.Data.SqlDbType.UniqueIdentifier;
            col.Title = "租户";
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable;
            tviCol = new TreeNode();
            tviCol.Text = "租户[TenantID]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);


            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = table.Name + "Type";
            col.DataType = System.Data.SqlDbType.Int;
            col.Default = "1";
            col.Title = table.Title + "类型";
            col.EnumType = table.Name + "Types";
            col.ResourceType = "Resources.X";
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable | ZippyCoder.Entity.UIColTypes.Queryable | ZippyCoder.Entity.UIColTypes.Editable | ZippyCoder.Entity.UIColTypes.Listable;
            col.RenderType = ZippyCoder.Entity.RenderTypes.CheckBoxList;
            tviCol = new TreeNode();
            tviCol.Text = col.Title + "[" + col.Name + "]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);

            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = table.Name + "Status";
            col.DataType = System.Data.SqlDbType.Int;
            col.Default = "1";
            col.Title = table.Title + "状态";
            col.EnumType = table.Name + "Status";
            col.ResourceType = "Resources.X";
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable | ZippyCoder.Entity.UIColTypes.Queryable | ZippyCoder.Entity.UIColTypes.Editable | ZippyCoder.Entity.UIColTypes.Listable;
            col.RenderType = ZippyCoder.Entity.RenderTypes.RadioButtonList;
            tviCol = new TreeNode();
            tviCol.Text = col.Title + "[" + col.Name + "]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);

            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = "DisplayOrder";
            col.CssClass = "textBox";
            col.CssClassLength = "w1";
            col.DataType = System.Data.SqlDbType.Int;
            col.Default = "0";
            col.Title = "排列顺序";
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable | ZippyCoder.Entity.UIColTypes.Editable | ZippyCoder.Entity.UIColTypes.Sortable;
            tviCol = new TreeNode();
            tviCol.Text = "排列顺序[DisplayOrder]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);

            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = "CreateDate";
            col.AutoIncrease = false;
            col.CssClass = "textBox";
            col.CssClassLength = "w3";
            col.DataType = System.Data.SqlDbType.DateTime;
            col.Default = "(GetDate())";
            col.Title = "创建时间";
            col.RenderType = ZippyCoder.Entity.RenderTypes.TextBox;
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable | ZippyCoder.Entity.UIColTypes.Listable | ZippyCoder.Entity.UIColTypes.Queryable | ZippyCoder.Entity.UIColTypes.Sortable;
            tviCol = new TreeNode();
            tviCol.Text = "创建时间[CreateDate]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);

            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = "Creator";
            col.CssClass = "textBox";
            col.CssClassLength = "w1";
            col.DataType = System.Data.SqlDbType.UniqueIdentifier;
            //col.Default = "0";
            col.Title = "创建人";
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable;
            tviCol = new TreeNode();
            tviCol.Text = "创建人[Creator]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);

            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = "UpdateDate";
            col.AutoIncrease = false;
            col.CssClass = "textBox";
            col.CssClassLength = "w3";
            col.DataType = System.Data.SqlDbType.DateTime;
            col.Title = "更新时间";
            col.RenderType = ZippyCoder.Entity.RenderTypes.TextBox;
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable;
            tviCol = new TreeNode();
            tviCol.Text = "更新时间[UpdateDate]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);

            col = new ZippyCoder.Entity.Col();
            table.Cols.Add(col);
            col.Name = "Updater";
            col.CssClass = "textBox";
            col.CssClassLength = "w1";
            col.DataType = System.Data.SqlDbType.UniqueIdentifier;
            //col.Default = "0";
            col.Title = "更新人";
            col.UIColType = ZippyCoder.Entity.UIColTypes.Detailable;
            tviCol = new TreeNode();
            tviCol.Text = "更新人[Updater]";
            tviCol.Tag = col;
            tviTable.Nodes.Add(tviCol);

        }
        /// <summary>
        /// 将 obj 序列化成 xml
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            string result = string.Empty;
            try
            {
                System.Reflection.Assembly a = null;
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                System.IO.Stream stream = new System.IO.MemoryStream();
                //此部分是为了去除默认命名空间xmlns:xsd和xmlns:xsi @chuchur 2014年1月11日 20:07:39
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                //
                XmlTextWriter xtWriter = new XmlTextWriter(stream, System.Text.Encoding.UTF8);
                serializer.Serialize(xtWriter, obj, ns);
                xtWriter.Flush();
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                using (System.IO.StreamReader reader = new System.IO.StreamReader(stream, System.Text.Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                    reader.Close();
                    return result;
                }
            }
            catch { return result; }
        }
        public static T DeSerialize<T>(string xml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (System.IO.StringReader sr = new System.IO.StringReader(xml))
            {
                T rtn = (T)ser.Deserialize(sr);
                sr.Close();
                return rtn;
            }
        }
    }
}

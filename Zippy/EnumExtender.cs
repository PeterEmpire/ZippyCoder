/*-----------------------------------------------------
 * 此类用来扩展 枚举类型的 方法。
 * 
 * 
 * 创建者：啤酒云 
 * 
 * 
 *  
 * 
 -------------------------------------------------------*/
namespace System
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI.WebControls;
    /// <summary>
    /// 扩展 Enum
    /// </summary>
    public static class EnumExtender
    {
        #region ToHtmlControlList
        /// <summary>
        /// 输出一个 radio 或者 checkbox 的列表，直接是 html 表现形式。
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="controlName"></param>
        /// <param name="controlType">input 中的 type，可以的值为： radio checkbox</param>
        /// <returns></returns>
        public static string ToHtmlControlList(this Type enumType, string controlName, string controlType)
        {
            return enumType.ToHtmlControlList(controlName, controlType, null, null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="controlName"></param>
        /// <param name="controlType">input 中的 type，可以的值为： radio checkbox</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string ToHtmlControlList(this Type enumType, string controlName, string controlType, int? defaultValue)
        {
            return enumType.ToHtmlControlList(controlName, controlType, null, defaultValue);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="controlName"></param>
        /// <param name="controlType">input 中的 type，可以的值为： radio checkbox</param>
        /// <param name="resourceType"></param>
        /// <returns></returns>
        public static string ToHtmlControlList(this Type enumType, string controlName, string controlType, Type resourceType)
        {
            return enumType.ToHtmlControlList(controlName, controlType, resourceType, null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="controlName"></param>
        /// <param name="controlType">input 中的 type，可以的值为： radio checkbox</param>
        /// <param name="resourceType"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string ToHtmlControlList(this Type enumType, string controlName, string controlType, Type resourceType, int? defaultValue)
        {
            return enumType.ToHtmlControlList(controlName, controlType, resourceType, defaultValue, null, "");
        }

        public static string ToHtmlControlList(this Type enumType, string controlName, string controlType, Type resourceType, int? defaultValue, IDictionary<string, object> htmlAttributes, string split)
        {
            return ToHtmlControlList(enumType, controlName, controlType, resourceType, defaultValue,htmlAttributes, split, null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="controlName"></param>
        /// <param name="controlType"></param>
        /// <param name="resourceType"></param>
        /// <param name="defaultValue"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="split">在radio 和 check 中间增加的空格字符</param>
        /// <param name="zeroOption">select 中增加value为0 的“请选择字样”，此尽在 select 下有效</param>
        /// <returns></returns>
        public static string ToHtmlControlList(this Type enumType, string controlName, string controlType, Type resourceType, int? defaultValue, IDictionary<string, object> htmlAttributes, string split, string zeroOption)
        {
            if (!enumType.IsEnum) throw new Exception("主体必须是一个 enum 类型。");

            StringBuilder sb = new StringBuilder();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);

            System.Resources.ResourceManager rm = null;
            if (resourceType != null)
                rm = new System.Resources.ResourceManager(resourceType);

            if (controlType == "select")
            {
                sb.Append("<select id=\"" + controlName + "\" name=\"" + controlName + "\">\r\n");
                if (zeroOption != null)
                {
                    sb.Append("<option value=\"0\">" + zeroOption + "</option>\r\n");
                }
            }
            foreach (int val in values)
            {
                string name = Enum.GetName(enumType, val);
                string text = rm == null ? name : rm.GetString("Enum_" + enumType.Name + "_" + name);
                if (text.IsNullOrEmpty()) text = name;
                string ischekced = "";
                if (defaultValue.HasValue)
                {
                    if (controlType == "select")
                        ischekced = ((defaultValue & val) == val) ? " selected=\"selected\"" : "";
                    else
                        ischekced = ((defaultValue & val) == val) ? " checked=\"checked\"" : "";
                }
                string addKV = " ";
                if (htmlAttributes != null)
                {
                    foreach (string k in htmlAttributes.Keys)
                    {
                        addKV += k + "='" + htmlAttributes[k] + "' ";
                    }
                }

                addKV = addKV.TrimEnd();
                if (controlType == "select")
                    sb.Append("<option value=\"" + val + "\" " + ischekced + ">" + text + "</option>\r\n");
                else
                    sb.Append("<input type=\"" + controlType + "\" name=\"" + controlName + "\" value='" + val + "' id=\"" + controlName + val + "\"" + ischekced + addKV + " /><label for=\"" + controlName + val + "\">" + text + "</label> \r\n" + split);
            }

            if (controlType == "select")
                sb.Append("</select>\r\n");
            return sb.ToString();
        }
        #endregion

        #region Bind To WebControl
        public static void BindTo(this Type enumType, ListControl ddl)
        {
            ddl.Items.Clear();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                string resValue = name;
                if (resValue == null) resValue = name;
                ddl.Items.Add(new ListItem(resValue, ((int)values.GetValue(i)).ToString()));
            }
        }
        /// <summary>
        /// 绑定到 ListControl
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="ddl"></param>
        /// <param name="initLabel"></param>
        public static void BindTo(this Type enumType, ListControl ddl, string initLabel)
        {
            ddl.Items.Clear();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                string resValue = name;
                if (resValue == null) resValue = name;
                ddl.Items.Add(new ListItem(resValue, ((int)values.GetValue(i)).ToString()));
            }
            ListItem li0 = new ListItem(initLabel, "0");
            ddl.Items.Insert(0, li0);
        }
        /// <summary>
        /// Binds the specified enum type.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <param name="ddl">The DDL.</param>
        /// <param name="resourceType">Type of the resource.</param>
        public static void BindTo(this Type enumType, ListControl ddl, Type resourceType)
        {
            ddl.Items.Clear();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(resourceType);
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                string text = rm.GetString("Enum_" + enumType.Name + "_" + name);
                ddl.Items.Add(new ListItem(text, ((int)values.GetValue(i)).ToString()));
            }
        }

        /// <summary>
        /// Binds the specified enum type.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <param name="ddl">The DDL.</param>
        /// <param name="resourceType">Type of the resource.</param>
        /// <param name="initLabel">The init label.</param>
        public static void BindTo(this Type enumType, ListControl ddl, Type resourceType, string initLabel)
        {
            ddl.Items.Clear();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(resourceType);
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                string text = rm.GetString("Enum_" + enumType.Name + "_" + name);
                ddl.Items.Add(new ListItem(text, ((int)values.GetValue(i)).ToString()));
            }
            ListItem li0 = new ListItem(initLabel, "0");
            ddl.Items.Insert(0, li0);
        }
        #endregion

        #region ToString

        public static string EnumToString(this Type enumType, int enumValue, Type resourceType)
        {
            if (!enumType.IsEnum) throw new Exception("主体必须是一个 enum 类型。");
            StringBuilder sb = new StringBuilder();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);

            System.Resources.ResourceManager rm = null;
            if (resourceType != null)
                rm = new System.Resources.ResourceManager(resourceType);

            foreach (int val in values)
            {
                if (enumValue == val)
                {
                    string name = Enum.GetName(enumType, val);
                    string text = name;
                    if (rm != null)
                        text = rm.GetString("Enum_" + enumType.Name + "_" + name);
                    if (text.IsNullOrEmpty()) text = name;
                    sb.Append(text);
                    break;
                }
            }
            if (sb.Length == 0)
            {
                string name = Enum.GetName(enumType, enumValue);
                string text = rm.GetString("Enum_" + enumType.Name + "_" + name);
                if (text.IsNullOrEmpty()) text = name;
                sb.Append(text);
            }
            string res = sb.ToString();
            return res;
        }

        /// <summary>
        /// 将enum的数值转化成为字符串，适用于 2^ 类型的枚举
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="enumValue"></param>
        /// <param name="resourceType"></param>
        /// <param name="seporator"></param>
        /// <returns></returns>
        public static string ToString(this Type enumType, int enumValue, Type resourceType, string seporator)
        {
            if (!enumType.IsEnum) throw new Exception("主体必须是一个 enum 类型。");
            StringBuilder sb = new StringBuilder();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);

            System.Resources.ResourceManager rm = null;
            if (resourceType != null)
                rm = new System.Resources.ResourceManager(resourceType);

            foreach (int val in values)
            {
                if ((val & enumValue) == val)
                {
                    string name = Enum.GetName(enumType, val);
                    string text = name;
                    if (rm != null)
                        text = rm.GetString("Enum_" + enumType.Name + "_" + name);
                    if (text.IsNullOrEmpty()) text = name;
                    sb.Append(text + seporator);
                }
            }
            if (sb.Length == 0)
            {
                string name = Enum.GetName(enumType, enumValue);
                string text = rm.GetString("Enum_" + enumType.Name + "_" + name);
                if (text.IsNullOrEmpty()) text = name;
                sb.Append(text);
            }
            string res = sb.ToString();
            if (res.EndsWith(seporator))
            {
                res = res.Remove(res.Length - seporator.Length);
            }
            return res;
        }
        /// <summary>
        /// 将enum的数值转化成为字符串，适用于 2^ 类型的枚举
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="enumValue"></param>
        /// <param name="resourceType"></param>
        /// <returns></returns>
        public static string ToString(this Type enumType, int enumValue, Type resourceType)
        {
            return enumType.ToString(enumValue, resourceType, " | ");
        }
        /// <summary>
        /// 将enum的数值转化成为字符串，适用于 2^ 类型的枚举
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string ToString(this Type enumType, int enumValue)
        {
            if (!enumType.IsEnum) throw new Exception("主体必须是一个 enum 类型。");
            StringBuilder sb = new StringBuilder();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);

            foreach (int val in values)
            {
                if ((val & enumValue) == val)
                {
                    string name = Enum.GetName(enumType, val);
                    sb.Append(name + " | ");
                }
            }
            if (sb.Length == 0)
            {
                string name = Enum.GetName(enumType, enumValue);
                sb.Append(name);
            }
            string res = sb.ToString();
            if (res.EndsWith(" | "))
            {
                res = res.Remove(res.Length - 3);
            }
            return res;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="enumValue"></param>
        /// <param name="resourceType"></param>
        /// <returns></returns>
        public static string ToStringUnique(this Type enumType, int enumValue, Type resourceType)
        {
            if (!enumType.IsEnum) throw new Exception("主体必须是一个 enum 类型。");
            StringBuilder sb = new StringBuilder();
            System.Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);

            System.Resources.ResourceManager rm = null;
            if (resourceType != null)
                rm = new System.Resources.ResourceManager(resourceType);


            foreach (int val in values)
            {
                if (val == enumValue)
                {
                    string name = Enum.GetName(enumType, val);
                    string text = name;
                    if (rm != null)
                        text = rm.GetString("Enum_" + enumType.Name + "_" + name);
                    if (text.IsNullOrEmpty()) text = name;
                    return text;
                }
            }

            return string.Empty;
        }


        #endregion

    }
}

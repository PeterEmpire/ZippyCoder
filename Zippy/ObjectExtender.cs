/*-----------------------------------------------------
 * 此类用来扩展 Object，为 Object 增加方法。
 * 
 * 
 * Author：啤酒云 
 *  
 * 
 -------------------------------------------------------*/

using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
namespace System
{
    /// <summary>
    /// 扩展 Object
    /// </summary>
    public static class ObjectExtender
    {
        #region 判断
        /// <summary>
        /// 验证网址
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsWebUrl(this string source)
        {
            return Regex.IsMatch(source, @"^(((file|gopher|news|nntp|telnet|http|ftp|https|ftps|sftp)://)|(www\.))+(([a-zA-Z0-9\._-]+\.[a-zA-Z]{2,6})|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(/[a-zA-Z0-9\&amp;%_\./-~-]*)?$", RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// 验证手机号
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsMobile(this string source)
        {
            if (source.IsNullOrEmpty()) return false;
            return Regex.IsMatch(source, @"^(13|14|15|16|18|19)\d{9}$");
        }
        /// <summary>
        /// 判断 object 是否有值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>不为null或者 空字符 则返回真。</returns>
        public static bool IsNotNullOrEmpty(this object obj)
        {
            if (obj == null) return false;
            if (string.IsNullOrEmpty(obj.ToString())) return false;
            return true;
        }

        /// <summary>
        /// 判断 object 是否为空值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>为 null 或者 空字符 则返回真。</returns>
        public static bool IsNullOrEmpty(this object obj)
        {
            if (obj == null) return true;
            if (string.IsNullOrEmpty(obj.ToString())) return true;
            return false;
        }

        /// <summary>
        /// 是否整数
        /// </summary>
        /// <param name="input">输入的字符</param>
        /// <returns>
        /// 	<c>true</c> if the specified STR value is integer; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsInteger(this object input)
        {
            if (input == null) return false;
            try
            {
                Convert.ToInt32(input);
                return true;
            }
            catch { }
            return false;
        }
        /// <summary>
        /// 是否为布尔值
        /// </summary>
        /// <param name="boolValue">The bool value.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns>
        /// 	<c>true</c> if the specified bool value is bool; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBool(this object boolValue, bool defaultValue)
        {
            try
            {
                return bool.Parse(boolValue.ToString());
            }
            catch { }
            return defaultValue;
        }
        #endregion

        #region 转化
        /// <summary>
        /// 将 object 转化为整形
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int ToInt32(this object obj, int defaultValue)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return defaultValue;
            }
        }
        /// <summary>
        /// 将obj转化成为整形，转化失败返回 0
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static int ToInt32(this object obj)
        {
            return ToInt32(obj, 0);
        }

        /// <summary>
        /// 转化成长整数
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="defaultValue">转化失败返回此值</param>
        /// <returns></returns>
        public static long ToInt64(this object obj, long defaultValue)
        {
            try
            {
                return Convert.ToInt64(obj);
            }
            catch
            {
                return defaultValue;
            }
        }


        /// <summary>
        /// 转化成长整数
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static long ToInt64(this object obj)
        {
            return ToInt64(obj, 0);
        }


        /// <summary>
        /// 转化成小数
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public static decimal ToDecimal(this object obj, decimal defaultValue)
        {
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转化成小数
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static decimal ToDecimal(this object obj)
        {
            return ToDecimal(obj, 0);
        }


        /// <summary>
        /// 转化为布尔值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns></returns>
        public static bool ToBoolean(this object obj, bool defaultValue)
        {
            try
            {
                return Convert.ToBoolean(obj);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转化成布尔值
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static bool ToBoolean(this object obj)
        {
            return ToBoolean(obj, false);
        }

        /// <summary>
        /// 转化成Double
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static double ToDouble(this object obj, double defaultValue)
        {
            try
            {
                return double.Parse(obj.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 变换成为Double
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="decimalDigits"></param>
        /// <returns></returns>
        public static double ToDouble(this object obj, int decimalDigits)
        {
            double d1 = ToDouble(obj, 0);
            return ToDouble(d1.ToString("f" + decimalDigits), 0);
        }
        /// <summary>
        /// 变换成为Double，默认为0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double ToDouble(this object obj)
        {
            return ToDouble(obj, 0D);
        }

        /// <summary>
        /// 变换成为日期
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue">如果输入非法日期，则返回此日期</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this object obj, DateTime defaultValue)
        {
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 变换成为日期
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns>如果不是合法的日期，则返回DateTime.MinValue</returns>
        public static DateTime ToDateTime(this object obj)
        {
            return ToDateTime(obj, System.DateTime.MinValue);
        }

        /// <summary>
        /// 变换成为GUID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>如果不是合法的guid，返回 Guid.Empty</returns>
        public static Guid ToGuid(this object obj)
        {
            try
            {
                return new Guid(obj.ToString());
            }
            catch
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// 格式化金额
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalFormat">格式化小数：如 "#.##"</param>
        /// <param name="displayPattern">显示模式，如{0}元</param>
        /// <returns></returns>
        public static string ToCurrency(this object value, string decimalFormat, string displayPattern)
        {
            decimal price = ToDecimal(value);

            return string.Format(displayPattern, price.ToString(decimalFormat));
        }
        #endregion

        #region 序列化
        /// <summary>
        /// 将 obj 序列化成 xml
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(this object obj)
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(obj.GetType());
            System.IO.Stream stream = new System.IO.MemoryStream();
            //此部分是为了去除默认命名空间xmlns:xsd和xmlns:xsi @chuchur 2014年1月11日 20:07:39
            System.Xml.Serialization.XmlSerializerNamespaces ns =
                new System.Xml.Serialization.XmlSerializerNamespaces();
            ns.Add("", "");
            //
            System.Xml.XmlTextWriter xtWriter = new System.Xml.XmlTextWriter(stream, System.Text.Encoding.UTF8);
            serializer.Serialize(xtWriter, obj, ns);
            xtWriter.Flush();
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream, System.Text.Encoding.UTF8))
            {
                string result = reader.ReadToEnd();
                reader.Close();
                return result;
            }
        }
        /// <summary>
        /// 将 obj 序列化成 xml，并 zip
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeAndZip(this object obj)
        {
            string rtn = obj.Serialize();
            return rtn.Zip();
        }

        public static string SerializeAsJson(this object obj)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(obj.GetType());
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, obj);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }

        /// <summary>
        /// DataSet To Json by chuchur 2013年12月24日 09:52:32
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static string dsToJson(this System.Data.DataSet ds)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder("[");
            for (int o = 0; o < ds.Tables.Count; o++)
            {
                str.Append("{");
                str.Append(string.Format("\"{0}\":[", ds.Tables[o].TableName));

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    str.Append("{");
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        str.Append(string.Format("\"{0}\":\"{1}\",", ds.Tables[0].Columns[j].ColumnName, ds.Tables[0].Rows[i][j].ToString()));
                    }
                    str.Remove(str.Length - 1, 1);
                    str.Append("},");
                }
                str.Remove(str.Length - 1, 1);
                str.Append("]},");
            }
            str.Remove(str.Length - 1, 1);
            str.Append("]");
            return str.ToString();
        }
        #endregion


        #region 位运算
        /// <summary>
        /// 位运算，判断多重状态 num1 中是否 包含。表达式为   (num1&num2)==num2 ?
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static bool BitIs(this object num1, object num2)
        {
            int x2 = num2.ToInt32();
            return (num1.ToInt32() & x2) == x2;
        }
        /// <summary>
        /// 位与， x | y = ?
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int BitAdd(this object num1, object num2)
        {
            return num1.ToInt32() | num2.ToInt32();
        }
        /// <summary>
        /// 减去某个状态
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int BitSubtract(this object num1, object num2)
        {
            return num1.ToInt32() & ~num2.ToInt32();
        }
        #endregion

        public static System.Dynamic.ExpandoObject ToExpando(this object anonymousObject)
        {
            System.Collections.Generic.IDictionary<string, object> anonymousDictionary = new System.Web.Routing.RouteValueDictionary(anonymousObject);
            System.Collections.Generic.IDictionary<string, object> expando = new System.Dynamic.ExpandoObject();
            foreach (var item in anonymousDictionary)
                expando.Add(item);
            return (System.Dynamic.ExpandoObject)expando;
        }

    }
}

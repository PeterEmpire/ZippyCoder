/*-----------------------------------------------------
 * 此类用来扩展 String，为 String 增加方法。
 * 
 * 
 * 创建者：啤酒云 
 * 
 -------------------------------------------------------*/
namespace System
{

    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Drawing.Drawing2D;
    using System.Security.Cryptography;
    using System.Linq;
    using System.Runtime.Serialization.Json;
    using System.IO;
    using System.Text;
    using System.Xml.Serialization;
    /// <summary>
    /// 扩展 String
    /// </summary>
    public static class StringExtender
    {
        #region 杂
        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToUpperFirstLetter(this String str)
        {
            string letter = str.Substring(0, 1);
            return letter.ToUpper() + str.Substring(1);
        }
        /// <summary>
        /// 计算英文单词的数量
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// 获取字符串字节长度，（中文字符为 2）
        /// </summary>
        /// <param name="str">输入的字符串</param>
        /// <returns>字符串长度</returns>
        public static int GetBytesLength(this String str)
        {
            if (str == null || str == string.Empty)
                return 0;
            return System.Text.Encoding.Default.GetByteCount(str);
        }
        /// <summary>
        /// 按字节数量截取字符串
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="MaxLength">需要截取的字符串</param>
        /// <returns></returns>
        public static string ToStringChopped(this String str, int MaxLength)
        {
            if (str == null || str == string.Empty)
                return "";

            str = str.Replace("\r\n", "");
            str = str.Replace("&nbsp;", "");
            str = str.Replace("&nbsp", "");


            if (str.GetBytesLength() > MaxLength)
            {
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                int Length = 0;

                for (int i = 0, j = str.Length; i < j && Length < MaxLength; i++)
                {
                    builder.Append(str[i]);

                    Length += System.Text.Encoding.Default.GetByteCount(str[i].ToString());
                }

                return builder.ToString() + "...";
            }
            else
            {
                return str;
            }
        }

        /// <summary>
        /// 输出一个没有前缀的 url。
        /// 去掉 http://, ftp:// 等内容
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string ToUrlWithoutPrefix(this String url)
        {
            if (string.IsNullOrEmpty(url)) return url;
            url = url.ToLower().Trim();
            int slashIndex = url.IndexOf("://");
            if (slashIndex > 0)
                return url.Substring(slashIndex + 3, url.Length - slashIndex - 3);

            return url;
        }

        /// <summary>
        /// 移除字符串最后一个字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveLastChar(this String str)
        {
            return RemoveLastChar(str, 1);
        }

        /// <summary>
        /// 移除字符串后面的n个字符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RemoveLastChar(this String str, int length)
        {
            if (str.Length == 0)
                throw new Exception("不能对空字符串进行操作！");

            if (str.Length == length)
                return str;

            var startIndex = str.Length - length;

            return str.Remove(startIndex);
        }
        #endregion

        #region 汉字操作
        /// <summary>
        /// 截取汉字拼音的首字母
        /// </summary>
        /// <param name="str">单个汉字，多个字符按单个处理</param>
        /// <returns>汉语拼音的首字母，大写</returns>
        public static string ToPinyinFirstLetter(this String str)
        {
            byte[] arrCN = System.Text.Encoding.Default.GetBytes(str);
            if (arrCN.Length > 1)
            {
                int area = (short)arrCN[0];
                int pos = (short)arrCN[1];
                int code = (area << 8) + pos;
                int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614, 48119, 48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387, 51446, 52218, 52698, 52698, 52698, 52980, 53689, 54481 };
                for (int i = 0; i < 26; i++)
                {
                    int max = 55290;
                    if (i != 25) max = areacode[i + 1];
                    if (areacode[i] <= code && code < max)
                    {
                        return System.Text.Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
                    }
                }
                return "*";
            }
            else return str;
        }
        #endregion

        #region Zip and UnZip
        /// <summary>
        /// 压缩字符串后并使用 Base64 编码，字符编码为 UTF-8
        /// </summary>
        /// <param name="str"></param>
        /// <returns>压缩后的字符串</returns>
        public static string Zip(this string str)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            using (System.IO.Compression.GZipStream zip = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            System.IO.MemoryStream outStream = new System.IO.MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return Convert.ToBase64String(gzBuffer);
        }

        /// <summary>
        /// 解压字符串，字符编码为 UTF-8
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UnZip(this String str)
        {
            byte[] gzBuffer = Convert.FromBase64String(str);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                ms.Write(gzBuffer, 4, (gzBuffer.Length - 4));

                byte[] buffer = new byte[msgLength];

                ms.Position = 0;
                using (System.IO.Compression.GZipStream zip = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Decompress))
                {
                    zip.Read(buffer, 0, buffer.Length);
                }

                return System.Text.Encoding.UTF8.GetString(buffer);
            }
        }
        #endregion

        #region Url Download
        /// <summary>
        /// 将一个url这个网址的内容下载回来
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string DownloadString(this String url)
        {
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                return wc.DownloadString(url);
            }
        }

        /// <summary>
        /// 下载一个url的内容，并解压。此内容需经过 Zip 方法压缩过。
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string DownloadAndUnzipString(this String url)
        {
            string res = url.DownloadString();
            return res.UnZip();
        }
        #endregion

        #region Unicode转换
        /// <summary>
        /// 将原始字串转换为unicode,格式为\u....\u....
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <returns></returns>
        public static string ToUnicode(this String str)
        {
            string outStr = string.Empty;
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    //将中文字符转为10进制整数，然后转为16进制unicode字符
                    outStr += "\\u" + ((int)str[i]).ToString("x");
                }
            }
            return outStr;
        }

        /// <summary>
        /// 将Unicode字串\u....\u....格式字串转换为原始字符串
        /// </summary>
        /// <param name="str">\u....\u....格式的字串</param>
        /// <returns></returns>
        public static string Unicode2String(this String str)
        {
            string outStr = string.Empty;
            if (!string.IsNullOrEmpty(str))
            {
                string[] strlist = str.Replace("\\", "").Split('u');
                try
                {
                    for (int i = 1; i < strlist.Length; i++)
                    {
                        //将unicode字符转为10进制整数，然后转为char中文字符
                        outStr += (char)int.Parse(strlist[i], System.Globalization.NumberStyles.HexNumber);
                    }
                }
                catch (FormatException ex)
                {
                    outStr = ex.Message;
                }
            }
            return outStr;
        }
        #endregion

        #region 消除有害字符、河蟹
        /// <summary>
        /// 清除所有 html 标签
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string CleanHtmlTag(this string html)
        {
            if (string.IsNullOrEmpty(html))
                return "";
            return System.Text.RegularExpressions.Regex.Replace(html, @"<[^>]+>", "");

        }
        /// <summary>
        /// 清除指定的标签
        /// </summary>
        /// <param name="html"></param>
        /// <param name="tag">需要清除的标签</param>
        /// <returns></returns>
        public static string CleanHtmlTag(this string html, string tag)
        {
            if (string.IsNullOrEmpty(html))
                return "";
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"<[/]?" + tag + ">", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            html = regex.Replace(html, "");
            return html;
        }

        /// <summary>
        /// 清除有害的html代码，如 &lt;script..&gt; &lt;iframe...&gt; 等
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string CleanHarmfulHtml(this string html)
        {
            System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex(@"<script.*</script *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex(@" href *= *[^>]+script[^>]+>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex(@" on.*?=", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex4 = new System.Text.RegularExpressions.Regex(@"<iframe.*</iframe *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex5 = new System.Text.RegularExpressions.Regex(@"<frameset.*</frameset *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            html = regex1.Replace(html, ""); //过滤<script></script>标记 
            html = regex2.Replace(html, ">"); //过滤href=javascript: (<a>) 属性 
            html = regex3.Replace(html, " _disabledevent="); //过滤其它控件的on...事件 
            html = regex4.Replace(html, ""); //过滤iframe 
            html = regex5.Replace(html, ""); //过滤frameset 
            return html;
        }

        /// <summary>
        /// 河蟹敏感字
        /// </summary>
        /// <param name="input">输入的文字</param>
        /// <param name="harmfulWords">敏感字</param>
        /// <param name="replaceTo">将敏感字替换成这个</param>
        /// <returns></returns>
        public static string CleanHarmfulWords(this string input, List<string> harmfulWords, string replaceTo)
        {
            if (string.IsNullOrEmpty(input))
                return "";


            if (harmfulWords == null)
            {
                harmfulWords = new List<string>();
                harmfulWords.Add("法轮功");
                harmfulWords.Add("鸡巴");
                harmfulWords.Add("falungong");
                harmfulWords.Add("屄");
                harmfulWords.Add("操你妈");
            }

            System.Text.RegularExpressions.RegexOptions options = System.Text.RegularExpressions.RegexOptions.IgnoreCase |
                System.Text.RegularExpressions.RegexOptions.Compiled |
                System.Text.RegularExpressions.RegexOptions.ExplicitCapture;

            foreach (string censor in harmfulWords)
            {
                string searchPattern;

                if (System.Web.HttpUtility.UrlEncode(censor) == censor)
                {
                    if (-1 == censor.IndexOfAny(new char[] { '\\', '[', '^', '*', '{', '.', '#', '?', '+', '$', '|' }))
                    {
                        searchPattern = String.Format(@"(?<!\[(code|pre)(\s*)\](.*))(\b{0}\b)(?!(.*)\[\/(code|pre)(\s*)\])", censor);
                    }
                    else
                    {
                        searchPattern = censor;
                    }
                }
                else
                {
                    searchPattern = censor;
                }

                //searchPattern = censor;

                //System.Web.HttpContext.Current.Response.Write(searchPattern + "\r\n");
                input = System.Text.RegularExpressions.Regex.Replace(input, searchPattern, replaceTo, options);
            }

            return input;
        }

        /// <summary>
        ///  河蟹敏感字。此方法的逻辑是：首先查看 Application["ForbiddenWords"] 中的值，如果没有值则去请求 forbiddenPath。
        ///  所以，如果需要更新forbiddenPath的内容，请清空 Application["ForbiddenWords"] 。
        /// </summary>
        /// <param name="input"></param>
        /// <param name="forbiddenPath">将敏感词一行一个存在此路径件中</param>
        /// <returns></returns>
        public static string CleanHarmfulWords(this string input, string forbiddenPath)
        {
            object fwrods = System.Web.HttpContext.Current.Application["ForbiddenWords"];
            List<string> arWords;
            if (fwrods != null)
            {
                arWords = (List<string>)fwrods;
            }
            else
            {
                arWords = new List<string>();
                if (System.IO.File.Exists(forbiddenPath))
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(forbiddenPath);
                    while (sr.Peek() >= 0)
                    {
                        string word = sr.ReadLine();
                        if (word.Trim() != "")
                            arWords.Add(word);
                    }
                    sr.Close();
                }
                System.Web.HttpContext.Current.Application["ForbiddenWords"] = arWords;

            }
            return CleanHarmfulWords(input, arWords, "***");
        }

        /// <summary>
        /// 河蟹敏感字。将敏感词一行一个存在根目录的 harmfulWords.txt 文件中
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string CleanHarmfulWords(string input)
        {
            //
            string forbiddenWordsPath = System.Web.HttpContext.Current.Server.MapPath("~/harmfulWords.txt");
            return CleanHarmfulWords(input, forbiddenWordsPath);
        }

        /// <summary>
        /// 清除 html内容中的有害脚本。并河蟹之。
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <returns></returns>
        public static string CleanHtml(this string html)
        {
            if (string.IsNullOrEmpty(html))
                return html;
            html = CleanHarmfulHtml(html);
            html = CleanHarmfulWords(html);
            return html;
        }

        /// <summary>
        /// 清除有害的sql输入
        /// </summary>
        /// <param name="sqlInput">The SQL input.</param>
        /// <returns></returns>
        public static string CleanSqlInput(this string sqlInput)
        {
            if (string.IsNullOrEmpty(sqlInput))
                return "";
            sqlInput = sqlInput.Replace("'", "''");
            sqlInput = sqlInput.Replace("(", "");
            sqlInput = sqlInput.Replace("%", "");

            return sqlInput;
        }
        #endregion

        #region CSS 操作相关

        /// <summary>
        /// 将字符串解析为CSS集合
        /// </summary>
        /// <param name="cssString"></param>
        /// <returns></returns>
        public static System.Web.UI.CssStyleCollection ToCssCollection(this String cssString)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl helper = new System.Web.UI.HtmlControls.HtmlGenericControl();
            helper.Style.Value = cssString;
            return helper.Style;
        }

        /// <summary>
        /// 分割CSS 以键,值对方式存储
        /// </summary>
        /// <param name="cssString"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ToCssDictionary(this string cssString)
        {
            if (string.IsNullOrWhiteSpace(cssString)) return new Dictionary<string, string>();
            Dictionary<string, string> cssList = new Dictionary<string, string>();
            string PatternCss = @"([\w|-]+):{1}([\w|\s|#|url|\/|\.|%|(|)|:|-]+);{1}";
            System.Text.RegularExpressions.Regex expression = new System.Text.RegularExpressions.Regex(PatternCss, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            System.Text.RegularExpressions.MatchCollection match = expression.Matches(cssString);
            int count = match.Count;

            for (int i = 0; i < count; i++)
            {
                cssList.Add(match[i].Groups[1].Value, match[i].Groups[2].Value);
            }

            return cssList;
        }

        /// <summary>
        /// 移除 css 的键
        /// </summary>
        /// <param name="cssString"></param>
        /// <param name="cssKey"></param>
        /// <returns></returns>
        public static string RemoveCss(this string cssString, string cssKey)
        {
            string rtn = "";
            Dictionary<string, string> kvs = cssString.ToCssDictionary();
            foreach (string key in kvs.Keys)
            {
                if (key.ToLower() != cssKey.ToLower())
                {
                    rtn += key + ":" + kvs[key] + ";";
                }
            }
            return rtn;
        }

        /// <summary>
        /// 增加一个 CSS 键值对到目标中
        /// </summary>
        /// <param name="cssString"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AddCss(this string cssString, string newKey, string newValue)
        {
            string rtn = "";
            Dictionary<string, string> kvs = cssString.ToCssDictionary();
            kvs[newKey] = newValue;
            foreach (string key in kvs.Keys)
            {
                rtn += key.ToLower() + ":" + kvs[key] + ";";
            }
            return rtn;
        }

        /// <summary>
        /// 合并两段 css, style2 的相同的key将覆盖 style1
        /// </summary>
        /// <param name="style1"></param>
        /// <param name="style2"></param>
        /// <returns>返回一个新的css字符串</returns>
        public static string Combine(this string style1, string style2)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            Dictionary<string, string> dict1 = style1.ToCssDictionary();
            Dictionary<string, string> dict2 = style2.ToCssDictionary();
            foreach (string key2 in dict2.Keys)
            {
                dict1[key2] = dict2[key2];
            }

            foreach (string key1 in dict1.Keys)
            {
                sb.Append(key1 + ":" + dict1[key1] + ";");
            }

            return sb.ToString();
        }
        #endregion

        #region 反序列化
        /// <summary>
        /// 反序列化xml2T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T DeSerialize<T>(this string xml)
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (System.IO.StringReader sr = new System.IO.StringReader(xml))
            {
                T rtn = (T)ser.Deserialize(sr);
                sr.Close();
                return rtn;
            }
        }

        /// <summary>
        /// 从一个压缩字符串中反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="zipString"></param>
        /// <returns></returns>
        public static T DeSerializeFromZip<T>(string zipString)
        {
            string xml = zipString.UnZip();
            return xml.DeSerialize<T>();
        }


        public static T DeSerializeJson<T>(this string json)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            T obj = (T)ser.ReadObject(ms);
            return obj;
        }
        #endregion

        #region 加密
        /// <summary>
        /// 将字符串转成byte数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Byte[] ToByteArray(this String s)
        {
            return System.Text.Encoding.UTF8.GetBytes(s);
        }
        /// <summary>
        /// MD5 加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Md5(this string str)
        {
            Byte[] hba = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).
                ComputeHash(str.ToByteArray());

            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            foreach (byte bb in hba)
            {
                builder.Append(bb.ToString("x").PadLeft(2, '0'));
            }

            return builder.ToString();
        }
        /// <summary>
        /// Liwill 的加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Md6(this string str)
        {
            str = str + "_liwill";
            Byte[] hba = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).
                ComputeHash(str.ToByteArray());

            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            foreach (byte bb in hba)
            {
                builder.Append(bb.ToString("x").PadLeft(2, '0'));
            }

            return builder.ToString();
        }
        /// <summary>
        /// md5 16位，早期 asp 模式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MD5_16bit(this string str)
        {
            string rtn = Md5(str);
            return rtn.Substring(8, 16);
        }

        /// <summary>
        /// 使用 RSA 加密字符串, 使用pkcs1.5填充
        /// </summary>
        /// <param name="a_strString"> 使用 UTF 变成byte[] </param>
        /// <param name="publicKey">公匙</param>
        /// <returns>加密后并经base64编码的字符串</returns>
        public static string EncryptRSA(this string a_strString, string publicKey)
        {
            var paras = new CspParameters();

            using (var rsaProvider = new RSACryptoServiceProvider())
            {
                try
                {
                    rsaProvider.ImportCspBlob(Convert.FromBase64String(publicKey));
                    return Convert.ToBase64String(rsaProvider.Encrypt(System.Text.Encoding.UTF8.GetBytes(a_strString), false));
                }
                catch { return null; }

            }
        }
        /// <summary>
        /// 使用 RSA 解密
        /// </summary>
        /// <param name="a_strString">需要解密的字符串</param>
        /// <param name="privateKey"></param>
        /// <returns>使用utf8编码的字符串</returns>
        public static string DecryptRSA(this string a_strString, string privateKey)
        {
            using (var rsaProvider = new RSACryptoServiceProvider())
            {
                try
                {
                    rsaProvider.ImportCspBlob(Convert.FromBase64String(privateKey));

                    var bsign = Convert.FromBase64String(a_strString);
                    var tms = rsaProvider.Decrypt(bsign, false);

                    return System.Text.Encoding.UTF8.GetString(tms);
                }
                catch (Exception ex)
                {
                    throw ex;
                    //return null;
                }

            }
        }




        /// <summary>
        /// 3des加密字符串
        /// </summary>
        /// <param name="a_strString">要加密的字符串</param>
        /// <param name="a_strKey">密钥</param>
        /// <returns>加密后并经base64编码的字符串</returns>
        /// <remarks>重载，指定编码方式</remarks>
        public static string Encrypt3DES(this string a_strString, string a_strKey)
        {
            System.Security.Cryptography.TripleDESCryptoServiceProvider DES = new
                System.Security.Cryptography.TripleDESCryptoServiceProvider();
            System.Security.Cryptography.MD5CryptoServiceProvider hashMD5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            DES.Key = hashMD5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(a_strKey));
            DES.Mode = System.Security.Cryptography.CipherMode.ECB;

            System.Security.Cryptography.ICryptoTransform DESEncrypt = DES.CreateEncryptor();

            byte[] Buffer = System.Text.Encoding.UTF8.GetBytes(a_strString);
            return Convert.ToBase64String(DESEncrypt.TransformFinalBlock
                (Buffer, 0, Buffer.Length));
        }//end method

        /// <summary>
        /// 3des解密字符6
        /// </summary>
        /// <param name="a_strString">要解密的字符串</param>
        /// <param name="a_strKey">密钥</param>
        /// <returns>解密后的字符串</returns>
        /// <exception cref="">密钥错误</exception>
        /// <remarks>静态方法，采用默认utf8编码</remarks>
        public static string Decrypt3DES(this string a_strString, string a_strKey)
        {
            System.Security.Cryptography.TripleDESCryptoServiceProvider DES = new
                System.Security.Cryptography.TripleDESCryptoServiceProvider();
            System.Security.Cryptography.MD5CryptoServiceProvider hashMD5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            DES.Key = hashMD5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(a_strKey));
            DES.Mode = System.Security.Cryptography.CipherMode.ECB;

            System.Security.Cryptography.ICryptoTransform DESDecrypt = DES.CreateDecryptor();

            string result = "";
            try
            {
                byte[] Buffer = Convert.FromBase64String(a_strString);
                result = System.Text.Encoding.UTF8.GetString(DESDecrypt.TransformFinalBlock
                    (Buffer, 0, Buffer.Length));
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine("错误：{0}", e);
#endif//DEBUG
                throw (new Exception("Invalid Key or input string is not a valid base64 string", e));
            }

            return result;
        }//end method


        public static IDictionary<string, string> ToDictionary(this string queryString)
        {
            if (queryString.Contains('?'))
            {
                queryString = queryString.Substring(queryString.IndexOf('?') + 1);
            }
            var kvs = queryString.Split('&');
            var dict = new Dictionary<string, string>();
            foreach (string kv in kvs)
            {
                if (kv.Contains('='))
                {
                    var k_v = kv.Split('=');
                    string key = k_v[0];
                    dict.Add(key, k_v[1]);
                }
            }
            return dict;
        }

        /// <summary>
        /// 对querystring进行升序排序
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="excepts">需要排除的参数</param>
        /// <returns></returns>
        public static string SortQueryString(this string queryString, params string[] excepts)
        {
            var dict = queryString.ToDictionary();
            foreach (var exp in excepts)
            {
                dict.Remove(exp);
            }
            var dict2 = dict.OrderBy(s => s.Key);
            string rtn = string.Empty;
            foreach (var skey in dict2)
            {
                rtn += skey.Key + "=" + skey.Value + "&";
            }
            if (rtn.EndsWith("&"))
            {
                rtn = rtn.Substring(0, rtn.Length - 1);
            }
            return rtn;
        }

        /// <summary>
        /// HMACSHA256  编码方式为：UTF8，最后的结果 转成16进制字符串。与php格式一致。
        /// 请注意：php的文件格式需要存储成为 utf8
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string EncryptHMACSHA256(this string str, string key)
        {
            var hma = new HMACSHA256(System.Text.Encoding.UTF8.GetBytes(key));
            var result = hma.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));

            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            foreach (byte bb in result)
            {
                builder.Append(bb.ToString("x2"));
            }
            return builder.ToString();
        }
        /// <summary>
        /// HMACSHA1 编码方式为：UTF8，最后的结果 转成16进制字符串。与php格式一致。
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string EncryptHMACSHA1(this string str, string key)
        {
            var hma = new HMACSHA1(System.Text.Encoding.UTF8.GetBytes(key));
            var result = hma.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));

            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            foreach (byte bb in result)
            {
                builder.Append(bb.ToString("x2"));
            }
            return builder.ToString();
        }
        #endregion

        #region Cookie 加密解密
        /// <summary>
        /// 提供一种存储cookie的方式，此cookie带有一把钥匙，钥匙符合才是有效。
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key">将本身存储到的 Cookie 键</param>
        /// <param name="expires">过期日期</param>
        public static void Save2Cookie(this string value, string key, DateTime expires)
        {

            System.Web.HttpCookie cookie = new System.Web.HttpCookie(key);
            cookie.Path = "/";
            cookie.Values.Add(key + "Value", value);
            cookie.Values.Add(key + "Code", value.Md6());
            cookie.Expires = expires;
            System.Web.HttpContext.Current.Response.SetCookie(cookie);

        }
        /// <summary>
        /// 从键中取出 Liwill 方式加密的 Cookie 值。本体为Cookie的键。
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string ToCookieValue(this string key)
        {
            if (System.Web.HttpContext.Current.Request.Cookies[key] == null)
                return string.Empty;
            string cookieCode = System.Web.HttpContext.Current.Request.Cookies[key][key + "Code"];
            string cookieValue = System.Web.HttpContext.Current.Request.Cookies[key][key + "Value"];
            if (cookieCode == cookieValue.Md6())
            {
                return cookieValue;
            }
            return null;

        }
        /// <summary>
        /// 移除cookie
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveCookie(this string key)
        {
            System.Web.HttpCookie cookie = new System.Web.HttpCookie(key);
            cookie.Path = "/";
            cookie.Expires = DateTime.Now.AddDays(-1);
            System.Web.HttpContext.Current.Response.SetCookie(cookie);
        }
        #endregion

        /// <summary>
        /// 从字符串中随机取出字符
        /// </summary>
        /// <param name="allChars">种子</param>
        /// <param name="length">需要取值的长度</param>
        /// <returns></returns>
        public static string ToRandom(this string allChars, int length)
        {
            char[] VcArray = allChars.ToCharArray();
            string VNum = "";


            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i < length + 1; i++)
            {
                int t = rand.Next(VcArray.Length - 1);

                VNum += VcArray[t];

            }
            return VNum;

        }
        /// <summary>
        /// 输出一个图片验证码
        /// </summary>
        /// <param name="text"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Image ToHipImage(this string text)
        {
            System.Random rnd = new Random(System.DateTime.Now.Millisecond);


            int iwidth = (int)(text.Length * 14);
            System.Drawing.Bitmap image = new System.Drawing.Bitmap(iwidth, 24);
            Graphics g = Graphics.FromImage(image);
            Font f = new System.Drawing.Font("Arial", rnd.Next(8, 14), System.Drawing.FontStyle.Regular);
            Brush b = new System.Drawing.SolidBrush(Color.FromArgb(123, 123, 123));
            //g.FillRectangle(new System.Drawing.SolidBrush(Color.Blue),0,0,image.Width, image.Height);
            g.Clear(Color.FromArgb(233, 233, 233));
            g.DrawString(text, f, b, 3, 3);
            g.Dispose();
            image.DistortImage(rnd.NextDouble() * 10 * (rnd.Next(2) == 1 ? 1 : -1));
            return image;
        }

        /// <summary>
        /// 将 枚举字符串 并起来，如 “1, 2” 变化成 1| 2 的整数
        /// </summary>
        /// <param name="enumString"></param>
        /// <returns></returns>
        public static int ToEnumInt32(this string enumString)
        {
            if (string.IsNullOrEmpty(enumString)) return 0;
            string[] strs = enumString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int rtn = 0;
            foreach (string str in strs)
            {
                rtn |= str.ToInt32();
            }
            return rtn;
        }

        /// <summary>
        /// 使用正则表达式判断是否匹配
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatch(this string str, string pattern)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, pattern);
        }

    }
}

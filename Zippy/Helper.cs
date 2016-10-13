using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Zippy
{
    public static class Helper
    { 
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

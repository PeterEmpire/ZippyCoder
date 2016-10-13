/*-----------------------------------------------------
 * 此类用来扩展 System.Web.UI.Page，为其增加方法。
 * 
 * 
 * Author：啤酒云 (cloudbeer@liwill.com)
 * 
 *  (C) 励惠 2010
 * 
 -------------------------------------------------------*/

namespace System.Web.UI
{
    /// <summary>
    /// 此类用来扩展 System.Web.UI.Page，为其增加方法。
    /// </summary>
    public static class PageExtender
    {
        /// <summary>
        /// 获取本页应用程序的根
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static string GetRoot(this Page page)
        {
            string root = page.Request.ApplicationPath;
            if (root == "/")
            {
                root = "";
            }
            return root;
        }


        /// <summary>
        /// 获取本页面的不带查询参数的 Url，Url 重写的地址按原样返回
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static string GetUrl(this Page page)
        {
            string action = page.Request.RawUrl;
            if (action.IndexOf("?") >= 0)
                action = action.Substring(0, action.IndexOf("?"));
            return action;
        }
        /// <summary>
        /// 获取本页面的 Url，Url 重写的地址按原样返回。
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static string GetUrlAndQuery(this Page page)
        {
            return page.Request.RawUrl;
        }

        /// <summary>
        /// 获取整形参数。
        /// </summary>
        /// <param name="page"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int RequestInt(this Page page, string key)
        {
            int rn = 0;
            try
            {
                rn = int.Parse(page.Request[key]);
            }
            catch { }
            return rn;
        }

        /// <summary>
        /// 获取整形参数。
        /// </summary>
        /// <param name="page"></param>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int RequestInt(this Page page, string key, int defaultValue)
        {
            try
            {
                return int.Parse(page.Request[key]);
            }
            catch { }
            return defaultValue;
        }

        /// <summary>
        /// 获取长整形参数
        /// </summary>
        /// <param name="page"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static long RequestLong(this Page page, string key)
        {
            long rn = 0;
            try
            {
                rn = long.Parse(page.Request[key]);
            }
            catch { }
            return rn;
        }

        /// <summary>
        /// 显示一个 JS alert 弹出框，多次调用此方法无效。
        /// </summary>
        /// <param name="page"></param>
        /// <param name="msg"></param>
        public static void JSAlert(this Page page, string msg)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            msg = msg.Replace("'", "\'");
            sb.AppendLine("alert('" + msg + "');");
            page.ClientScript.RegisterStartupScript(page.GetType(), "jsAlert", sb.ToString(), true);
        }
        /// <summary>
        /// 显示一个 JS alert 弹出框，并转向新的地址。
        /// </summary>
        /// <param name="page"></param>
        /// <param name="msg"></param>
        /// <param name="redirectUrl"></param>
        public static void JSAlert(this Page page, string msg, string redirectUrl)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            msg = msg.Replace("'", "\'");
            sb.AppendLine("alert('" + msg + "');");
            sb.AppendLine("window.location.href='" + redirectUrl + "';");
            page.ClientScript.RegisterStartupScript(typeof(System.Web.UI.Page), "jsAlert", sb.ToString(), true);
        }

        /// <summary>
        /// 关闭本窗口
        /// </summary>
        /// <param name="page"></param>
        public static void JSClose(this Page page)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("window.close();");
            page.ClientScript.RegisterStartupScript(typeof(System.Web.UI.Page), "jsClose", sb.ToString(), true);
        }

        /// <summary>
        /// 输出一段纯文本。
        /// </summary>
        /// <param name="page"></param>
        /// <param name="value"></param>
        public static void WriteAjax(this Page page, object value)
        {
            page.Response.Clear();
            page.Response.Write(value);
            page.Response.End();
        }

        /// <summary>
        /// 输出 XML 文档。
        /// </summary>
        /// <param name="page"></param>
        /// <param name="xml"></param>
        public static void WriteXml(this Page page, string xml)
        {
            page.Response.Clear();
            page.Response.ContentType = "text/xml";
            page.Response.Write(xml);
            page.Response.End();
        }

        /// <summary>
        /// 快速注册JS
        /// </summary>
        /// <param name="page"></param>
        /// <param name="key"></param>
        /// <param name="js"></param>
        public static void RegisterJs(this Page page, string key, string js)
        {
            page.ClientScript.RegisterClientScriptBlock(typeof(System.Web.UI.Page), key, js, true);
        }

        /// <summary>
        /// 快速注册 JS，仅能调用一次。
        /// </summary>
        /// <param name="page"></param>
        /// <param name="js"></param>
        public static void RegisterJs(this Page page, string js)
        {
            page.RegisterJs(js, "jsLiwillOnce");
        }

        /// <summary>
        /// 返回页面。返回目标为：url中的 ReturnUrl 或者 ReturnPage 的参数。没有这两项的返回根目录。
        /// </summary>
        /// <param name="page"></param>
        public static void Return(this Page page)
        {
            string url = page.Request.QueryString["ReturnUrl"];

            if (string.IsNullOrEmpty(url))
            {
                url = page.Request.QueryString["ReturnPage"];
            }
            if (string.IsNullOrEmpty(url))
            {
                url = page.GetRoot() + "/";
            }
            page.Response.Redirect(url, true);
        }
        /// <summary>
        /// 返回一个错误页面 /ErrorPages/?ErrorCode=errorCode。
        /// </summary>
        /// <param name="page"></param>
        /// <param name="errorCode"></param>
        public static void ReturnErrorPage(this Page page, string errorCode)
        {
            page.Response.Redirect("/ErrorPages/?ErrorCode=" + errorCode + "&ReturnUrl=" + page.GetUrlAndQuery(), true);
        }
    }
}

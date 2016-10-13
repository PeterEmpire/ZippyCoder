using ChurSkins;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ZippyCoder.Logic;
namespace ZippyCoder
{
    static class Program
    {
        public static bool canCreateNew = false;
        public static string confpath { get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ZippyCoder.xml"); } }
        public static History history;/// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Mutex mutex = new Mutex(true, Process.GetCurrentProcess().ProcessName, out canCreateNew);
            //加载配置文件
            try
            {
                if (File.Exists(confpath))
                {
                    XmlDocument xd = new XmlDocument();
                    xd.Load(confpath);
                    string xml = Helpler.Serialize(xd);
                    history = Helpler.DeSerialize<History>(xml);
                }
                if (history == null) history = new History();
            }
            catch { }
            if (canCreateNew)
            { Application.Run(new MainFrm()); }
            else
            { CMessageBox.Show(null, "程序已经在运行", "提示"); }
            //Application.Run(new Form1());
        }
    }
}

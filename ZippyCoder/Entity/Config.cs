using System;
using System.Collections.Generic;
namespace ZippyCoder
{
    //[System.Xml.Serialization.XmlRoot(Namespace = "http://www.blahblahblah.com.net.org")]
    public class History
    {
        private List<LocalHistory> localHistory;
        public List<LocalHistory> LocalHistory
        {
            get { if (localHistory == null) localHistory = new List<LocalHistory>(); return localHistory; }
            set { localHistory = value; }
        }
        private List<DataHistory> dataHistory;
        public List<DataHistory> DataHistory
        {
            get { if (dataHistory == null) dataHistory = new List<DataHistory>(); return dataHistory; }
            set { dataHistory = value; }
        }
    }
    public class LocalHistory
    {
        private string solutionname;
        private string solutionpath;
        public string SolutionName { get { return solutionname; } set { solutionname = value; } }
        public string SolutionPath { get { return solutionpath; } set { solutionpath = value; } }
    }
    //[Serializable]
    public class DataHistory
    {
        private string key;
        private string dabasetype;
        private string ip;
        private string port;
        private string username;
        private string password;
        private string databasename;
        /// <summary>
        /// 唯一识别符
        /// </summary>
        public string Key { get { return key; } set { key = value; } }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DataBaseType { get { return dabasetype; } set { dabasetype = value; } }
        /// <summary>
        /// 数据库链接地址
        /// </summary>
        public string IP { get { return ip; } set { ip = value; } }
        /// <summary>
        /// 链接端口
        /// </summary>
        public string Port { get { return port; } set { port = value; } }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get { return username; } set { username = value; } }
        /// <summary>
        /// 密码,加密后的字符串
        /// </summary>
        public string Password { get { return password; } set { password = value; } }
        /// <summary>
        /// 链接的数据库
        /// </summary>
        public string DataBaseName { get { return databasename; } set { databasename = value; } }
    }
    public class DataBaseType
    {
        public const string Mysql = "Mysql";
        public const string Mssql = "Mssql";
        public const string Oracle = "Oracle";
    }
}

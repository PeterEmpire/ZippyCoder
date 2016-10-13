using ChurSkins;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using ZippyCoder.Entity;
using ZippyCoder.Logic;

namespace ZippyCoder
{
    public partial class MainFrm : CForm
    {
        private ConnectSqlServerFrm mssqlFrm;
        private ConnectMysqlFrm mysqlFrm;
        public TableFrm tableFrm;
        public ColFrm colFrm;
        private ProjectFrm projectFrm;
        private Project _Project;
        public TreeFrm treeFrm;
        private T4SettingFrm t4SettingFrm;
        public string projectPath;
        public Project Project
        {
            get { return _Project; }
            set { _Project = value; }
        }

        public MainFrm()
        {
            InitializeComponent();
            InitT4Tables();
            InitT4Projects();
            LoadHistory();
        }
        #region Open Form
        private void OpenMsSqlFrm(object sender, EventArgs e)
        {
            if (mssqlFrm == null)
                mssqlFrm = new ConnectSqlServerFrm(this);
            mssqlFrm.FormClosing += (a, b) => { this.mssqlFrm = null; };
            mssqlFrm.ShowDialog();
        }
        private void OpenMySqlFrm(object sender, EventArgs e)
        {
            if (mysqlFrm == null)
                mysqlFrm = new ConnectMysqlFrm(this);
            mysqlFrm.FormClosing += (a, b) => { this.mysqlFrm = null; };
            mysqlFrm.ShowDialog();
        }
        private void OpenProjectFrm(object sender, EventArgs e)
        {
            if (projectFrm == null)
                projectFrm = new ProjectFrm(this);
            projectFrm.FormClosing += (a, b) => { this.projectFrm = null; };
            projectFrm.ShowDialog();
        }
        #endregion

        #region Open Form  初始化生成/插件菜单
        private void InitT4Tables()
        {
            string pluginPath = ".\\T4Template\\Table";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(pluginPath);
            RecursionDirectory(di, mT4TableCoder, true);
        }
        private void InitT4Projects()
        {
            string pluginPath = ".\\T4Template\\Project";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(pluginPath);
            RecursionDirectory(di, mT4ProjectCoder, false);
        }
        private void RecursionDirectory(System.IO.DirectoryInfo di, ToolStripMenuItem rootMenu, bool isTableSource)
        {
            //System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(rootDir);
            System.IO.FileInfo[] files = di.GetFiles("*.tt");

            foreach (System.IO.FileInfo file in files)
            {
                ToolStripMenuItem mi = new ToolStripMenuItem();
                mi.Text = file.Name;
                mi.Tag = file.FullName;
                rootMenu.DropDownItems.Add(mi);
                if (isTableSource)
                    mi.Click += new EventHandler(BuildT4Table);
                else
                    mi.Click += new EventHandler(BuildT4Project);
            }

            System.IO.DirectoryInfo[] dirs = di.GetDirectories();
            foreach (System.IO.DirectoryInfo diChild in dirs)
            {
                ToolStripMenuItem miDirChild = new ToolStripMenuItem();
                miDirChild.Text = diChild.Name;
                rootMenu.DropDownItems.Add(miDirChild);
                RecursionDirectory(diChild, miDirChild, isTableSource);
            }
        }
        void BuildT4Project(object sender, EventArgs e)
        {
            if (Project == null)
            {
                CMessageBox.Show(this, "没有项目文件，请新建或者载入");
                return;
            }
            if (t4SettingFrm == null || t4SettingFrm.IsDisposed)
                t4SettingFrm = new T4SettingFrm(this);
            ToolStripMenuItem xsender = sender as ToolStripMenuItem;
            t4SettingFrm.Tag = Project;
            t4SettingFrm.CodeMode = CodeModes.Project;
            t4SettingFrm.TTFile = xsender.Tag.ToString();
            //t4SettingFrm.LoadSettings();
            //Navigate(t4SettingFrm);
            t4SettingFrm.Show();
        }
        void BuildT4Table(object sender, EventArgs e)
        {
            if (Project == null)
            {
                CMessageBox.Show(this, "没有项目文件，请新建或者载入");
                return;
            }
            if (t4SettingFrm == null || t4SettingFrm.IsDisposed)
                t4SettingFrm = new T4SettingFrm(this);
            //t4SettingFrm.Visibility = Visibility.Collapsed;
            ToolStripMenuItem xsender = sender as ToolStripMenuItem;
            t4SettingFrm.Tag = _Project;
            t4SettingFrm.CodeMode = CodeModes.Table;
            t4SettingFrm.TTFile = xsender.Tag.ToString();
            //t4SettingFrm.LoadSettings();
            //Navigate(t4SettingFrm);
            t4SettingFrm.Show();
        }
        #endregion

        private void Save(object sender, EventArgs e) { SaveProject(); }
        private void OpenProject(object sender, EventArgs e) { LoadProject(""); }
        public bool SaveProject()
        {
            //_Project = treeProject.Tag as Project;
            if (Project == null)
            {
                CMessageBox.Show(this, "没有项目文件，请新建或者载入", "提示");
                return false;
            }

            if (string.IsNullOrEmpty(projectPath))
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = Project.Namespace + ".xml";
                dlg.Filter = "Xml文件|*.xml";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    projectPath = dlg.FileName;
                }
                else
                {
                    return false;
                }
            }

            try
            {
                Project.SaveProject(projectPath);
                treeFrm._Modified = false;
                Helpler.ChangeTitle(true, treeFrm);
                treeFrm.projectPath = projectPath;
                CMessageBox.Show(this, "项目保存成功", "提示");
                return true;
            }
            catch (Exception ex)
            {
                CMessageBox.Show(this, "文件保存失败：\r\n\r\n\t" + ex.Message, "错误提示");
                return false;
            }

        }
        /// <summary>
        /// 从文件加载项目
        /// </summary>
        /// <param name="path"></param>
        public void LoadProject(string path)
        {
            if (string.IsNullOrEmpty(path)) //如果传入的路径为空就打开新的窗口重建
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.Filter = "Xml文件|*.xml";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    path = dlg.FileName;
                }
                else return;
            }
            //projectPath = dlg.FileName;
            if (!File.Exists(path)) //如果找不到这个文件 ,则删除配置文件.
            {
                CMessageBox.Show(this, "该项目文件已经被删除或被迁移", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //从菜单里面移除
                ToolStripMenuItem mi = mLocalHistory.DropDownItems.Find(path, true)[0] as ToolStripMenuItem;
                mLocalHistory.DropDownItems.Remove(mi);
                //从列表里面移除
                ListItem li = listHistory.Items.Find(s => s.Value == path);
                listHistory.Items.Remove(li);

                //从配置文件移除
                LocalHistory lh = Program.history.LocalHistory.Find(s => s.SolutionPath == path);
                Program.history.LocalHistory.Remove(lh);
                return;
            }
            Project = Project.Load(path);
            if (!string.IsNullOrEmpty(Project.Namespace))
            {
                TreeFrm treeFrm = new TreeFrm(this);
                treeFrm.projectPath = path;

                treeFrm.Project = Project;
                projectPath = path;
                treeFrm.Text = Project.Namespace;
                treeFrm.UpdateUI();
                mainTab.TabPages.Add(treeFrm.Text);
                foreach (Control con in treeFrm.Controls)
                {
                    mainTab.TabPages[mainTab.TabPages.Count - 1].Controls.Add(con);
                    mainTab.SelectedIndex = mainTab.TabPages.Count - 1;
                }
                if (Program.history.LocalHistory == null || Program.history.LocalHistory.Find(s => s.SolutionPath == path) == null)
                {
                    var history = new LocalHistory();
                    history.SolutionPath = path;
                    history.SolutionName = Path.GetFileNameWithoutExtension(path);
                    Program.history.LocalHistory.Add(history);
                }
                //loadtreeFrm.Show();
            }
            else
            {
                CMessageBox.Show(this, "项目载入失败，请检查该文件的格式项目是否是正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //写历史记录到控件列表
        public void RecordHistory()
        {
            ListItem item = new ListItem();
            item.Text = projectPath;
            //item.Value=
            listHistory.Items.Add(item);
        }

        // public void 
        //加载历史记录
        private void LoadHistory()
        {
            //使用最近的项目解决方案
            if (Program.history.LocalHistory.Count > 0)
                foreach (var path in Program.history.LocalHistory)
                {
                    //加载到菜单里面
                    ToolStripMenuItem mi = new ToolStripMenuItem();
                    mi.Text = path.SolutionPath;
                    mi.Name = path.SolutionPath;
                    mLocalHistory.DropDownItems.Add(mi);
                    mi.Click += (s, e) => { LoadProject(path.SolutionPath); };
                    //加载到列表里面
                    ListItem li = new ListItem();
                    li.Text = path.SolutionName;
                    li.Value = path.SolutionPath;
                    listHistory.Items.Add(li);
                }
            //最近数据
            if (Program.history.DataHistory.Count > 0)
                foreach (var path in Program.history.DataHistory)
                {
                    ToolStripMenuItem mi = new ToolStripMenuItem();
                    mi.Text = path.IP + "-" + path.DataBaseName;
                    mi.Tag = path.Key;
                    mDataHistoty.DropDownItems.Add(mi);
                    mi.Click += (s, e) => { LoadDataHistory(path.Key); };
                }
        }
        public void LoadDataHistory(string key)
        {
            DataHistory dh = Program.history.DataHistory.Find(s => s.Key == key);
            if (dh.DataBaseType == DataBaseType.Mssql)
            {

            }
        }
        private void OpenSolutionPath(string path)
        {

        }
        //退出
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
        //程序关闭 保存配置
        private void CloseFrm(object sender, FormClosingEventArgs e)
        {
            XmlDocument xd = new XmlDocument();
            string xml = Helpler.Serialize(Program.history);
            xd.LoadXml(xml);
            xd.Save(Program.confpath);
        }
        //最近打开
        private void OpenHistory(object sender, EventArgs e)
        {
            LoadProject((sender as CListBox).SelectItem.Value);
        }
    }
}

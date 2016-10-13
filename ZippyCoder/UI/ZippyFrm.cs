using ChurSkins;
using System;
using System.Windows;
using System.Windows.Forms;
using ZippyCoder.Entity;
using ZippyCoder.Logic;

namespace ZippyCoder
{
    public partial class ZippyCoderFrm : CForm
    {
        public ZippyCoderFrm()
        {
            InitializeComponent();
            this.mdiClient.ParentForm = this;
            InitT4Tables();
            InitT4Projects();
        }
        private T4SettingFrm _uiT4Setting = null;
        public string projectPath = string.Empty;
        public TreeFrm _treeFrm = null;
        public TableFrm _tableFrm = null;
        public ColFrm _colFrm = null;
        private NewPro _NewPro;
        private ChangeTypes operation = ChangeTypes.None;

        public ChangeTypes Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        private Project _Project;
        public Project Project
        {
            get { return _Project; }
            set { _Project = value; }
        }


        //最小化到托盘
        private void ServerFrm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                // this.Hide();
            }
        }

        //显示面板
        private void AppIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
            if (e.Button != MouseButtons.Right)
                this.Activate();
        }

        public void SaveProject()
        {
            //_Project = treeProject.Tag as Project;
            if (Project == null)
            {
                //MessageBox.Show("", "错误");
                CMessageBox.Show(this, "没有项目文件，请新建或者载入");
                return;
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
                    return;
                }
            }

            try
            {
                Project.SaveProject(projectPath);
                _treeFrm._Modified = false;
                Helpler.ChangeTitle(true, _treeFrm);
                _treeFrm.projectPath = projectPath;
                CMessageBox.Show(this, "项目保存成功");
            }
            catch (Exception ex)
            {
                CMessageBox.Show(this, "文件保存失败：\r\n\r\n\t" + ex.Message);
            }

        }

        private void LoadProject()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Xml文件|*.xml";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                //projectPath = dlg.FileName;
                Project = Project.Load(dlg.FileName);
                if (!string.IsNullOrEmpty(Project.Namespace))
                {
                    TreeFrm loadtreeFrm = new TreeFrm(this);
                    loadtreeFrm.projectPath = dlg.FileName;

                    loadtreeFrm.Project = Project;
                    projectPath = dlg.FileName;
                    loadtreeFrm.Text = Project.Namespace + " - 基础数据结构";
                    loadtreeFrm.UpdateUI();
                    loadtreeFrm.Show();
                }
                else
                {
                    CMessageBox.Show(this, "项目载入失败，请检查该文件的格式项目是否是正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //T4
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
                    mi.Click += new EventHandler(miT4Table_Click);
                else
                    mi.Click += new EventHandler(miT4Project_Click);
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

        void miT4Project_Click(object sender, EventArgs e)
        {
            if (Project == null)
            {
                CMessageBox.Show(this, "没有项目文件，请新建或者载入");
                return;
            }
            if (_uiT4Setting == null || _uiT4Setting.IsDisposed)
                _uiT4Setting = new T4SettingFrm(this);
            ToolStripMenuItem xsender = sender as ToolStripMenuItem;
            _uiT4Setting.Tag = Project;
            _uiT4Setting.CodeMode = CodeModes.Project;
            _uiT4Setting.TTFile = xsender.Tag.ToString();
            //_uiT4Setting.LoadSettings();
            //Navigate(_uiT4Setting);
            _uiT4Setting.Show();
        }
        void miT4Table_Click(object sender, EventArgs e)
        {
            if (Project == null)
            {
                CMessageBox.Show(this, "没有项目文件，请新建或者载入");
                return;
            }
            if (_uiT4Setting == null || _uiT4Setting.IsDisposed)
                _uiT4Setting = new T4SettingFrm(this);
            //_uiT4Setting.Visibility = Visibility.Collapsed;
            ToolStripMenuItem xsender = sender as ToolStripMenuItem;
            _uiT4Setting.Tag = _Project;
            _uiT4Setting.CodeMode = CodeModes.Table;
            _uiT4Setting.TTFile = xsender.Tag.ToString();
            //_uiT4Setting.LoadSettings();
            //Navigate(_uiT4Setting);
            _uiT4Setting.Show();
        }


        //新建项目
        private void btn_new_Click(object sender, EventArgs e)
        {
            if (_NewPro == null || _NewPro.IsDisposed)
                _NewPro = new NewPro(this);
            _NewPro.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void MloadProject_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void MconnectionSql_Click(object sender, EventArgs e)
        {
            connectSQLFrm _connectSQLFrm = new connectSQLFrm(this);
            _connectSQLFrm.Show();
        }

        private void MExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
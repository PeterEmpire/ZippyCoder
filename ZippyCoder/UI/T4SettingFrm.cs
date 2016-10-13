using ChurSkins;
using System;
using System.Windows.Forms;
using ZippyCoder.Entity;

namespace ZippyCoder
{
    public partial class T4SettingFrm : CForm
    {
        public T4SettingFrm(MainFrm owner)
        {
            InitializeComponent();
            _Owner = owner;
           // this.MdiParent = owner;
        }
        private MainFrm _Owner;
        private Project _Tag;
        public new Project Tag
        {
            get
            {
                return _Tag;
            }
            set
            {
                _Tag = value;
                lvTable.DataSource = null; lvTable.ValueMember = null; lvTable.Items.Clear();
                lvTable.DataSource = _Tag.Tables;
                // lvTable.DisplayMember = _Tag.Tables.ToString();--GetItemText
                lvTable.ValueMember = "Title"; //----lvTable.SelectedValue
                for (int i = 0; i < lvTable.Items.Count; i++)
                {
                    lvTable.SetItemChecked(i, _Tag.Tables[i].IsCoding);
                }
            }
        }
        public CodeModes CodeMode { get; set; }
        public string TTFile { get; set; }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "选择路径";
            dlg.Filter = "*.txt|路径";

            if (dlg.ShowDialog().Equals(true))
            {
                tbxPath.Text = System.IO.Path.GetDirectoryName(dlg.FileName);
            }
        }

        Table currentTable = null;
        bool lvTableSelect = false;
        private void lvTable_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lvTableSelect)
            {
                // MessageBox.Show(e.CurrentValue.ToString());
                // return;
                lvCol.DataSource = null; lvCol.ValueMember = null; lvCol.Items.Clear();
                int i = e.Index;
                //currentTable = lvTable.GetItemText(e.Index) as Table;
                currentTable = _Tag.Tables[i];
                if (e.CurrentValue == CheckState.Checked)
                    _Tag.Tables[i].IsCoding = true;
                else
                    _Tag.Tables[i].IsCoding = false;
                if (currentTable == null) return;
                lvCol.DataSource = currentTable.Cols;
                lvCol.ValueMember = "Title";
            }
        }
        private void lvTable_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lvTable.SelectedItem.ToString());
            lvCol.DataSource = null; lvCol.ValueMember = null; lvCol.Items.Clear();
            currentTable = lvTable.SelectedItem as Table;
            lvCol.DataSource = currentTable.Cols;
            lvCol.ValueMember = "Title";
            for (int i = 0; i < lvCol.Items.Count; i++)
            {
                currentTable.Cols[i].IsCoding = true;
                lvCol.SetItemChecked(i, true);
            }
        }

        private void btnCheckAllTable_CheckedChanged(object sender, EventArgs e)
        {
            bool t = this.btnCheckAllTable.Checked;
            for (int i = 0; i < lvTable.Items.Count; i++)
            {
                _Tag.Tables[i].IsCoding = t;
                lvTable.SetItemChecked(i, t);
            }
            lvTableSelect = false;
            lvCol.DataSource = null;
            lvTable.DataSource = _Tag.Tables;
            //foreach (ZippyCoder.Entity.Table table in _Tag.Tables)
            //{
            //    table.IsCoding = this.btnCheckAllTable.Checked;
            //    lvTable.SetItemChecked(0, true);
            //}
        }

        private void lvTable_Enter(object sender, EventArgs e)
        {
            lvTableSelect = true;
        }

        private void btnCheckAllCols_CheckedChanged(object sender, EventArgs e)
        {
            lvCol.DataSource = null; lvCol.ValueMember = null;
            lvCol.DataSource = currentTable.Cols;
            lvCol.ValueMember = "Title";
            bool t = this.btnCheckAllCols.Checked;
            for (int i = 0; i < lvCol.Items.Count; i++)
            {
                currentTable.Cols[i].IsCoding = t;
                lvCol.SetItemChecked(i, t);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //SaveSettings();
            string outputPath = tbxPath.Text;
            if (System.IO.Directory.Exists(outputPath))
            {
                if (CMessageBox.Show(_Owner, "生成的代码将覆盖此目录的同名文件，是否继续？", "询问", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }

                ZippyCoder.Entity.Project project = Tag;
                if (CodeMode == CodeModes.Project)
                {
                    T4Engine.T4Creator.CreateCode(project, null, TTFile, project.Namespace,
                        tbxNamePattern.Text, tbxFixDel.Text, outputPath, cbxSepDir.Checked);
                }
                else if (CodeMode == CodeModes.Table)
                {
                    //tipCreate.Text = "正在载入 T4 模板...";
                    //spProgress.Visibility = Visibility.Visible;

                    //pbCreate.Maximum = (project.Tables.Where(s => s.IsCoding)).Count();
                    //pbCreate.Value = 0;
                    double value = 0;

                    foreach (ZippyCoder.Entity.Table table in project.Tables)
                    {
                        if (table.IsCoding)
                        {
                            T4Engine.T4Creator.CreateCode(project, table, TTFile, table.Name,
                                tbxNamePattern.Text, tbxFixDel.Text, outputPath, cbxSepDir.Checked);
                            // pbCreate.Dispatcher.Invoke(new Action<System.Windows.DependencyProperty, object>(pbCreate.SetValue), System.Windows.Threading.DispatcherPriority.Background, ProgressBar.ValueProperty, value);
                            // tipCreate.Dispatcher.Invoke(new Action<System.Windows.DependencyProperty, object>(tipCreate.SetValue), System.Windows.Threading.DispatcherPriority.Background, TextBlock.TextProperty, "正在执行生成：" + table.Title + "[" + table.Name + "]...");
                            value++;
                        }
                    }
                }

                if (T4Engine.T4Creator.T4Errors != null && T4Engine.T4Creator.T4Errors.Count > 0)
                {
                    string res = string.Empty;
                    foreach (System.CodeDom.Compiler.CompilerError error in T4Engine.T4Creator.T4Errors)
                    {
                        res += "\r\n" + "行：" + error.Line + " 列：" + error.Column + " ... " + error.ErrorText + error.FileName;
                    }
                    //_Owner.ShowInfo(res);
                    MessageBox.Show(res);
                    //CMessageBox.Show(_Owner, res, "提示", CMessageBoxIcon.OK, CMessageBoxButtons.OK);

                }
                else
                {
                    CMessageBox.Show(_Owner, "生成成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                CMessageBox.Show(_Owner, "目录不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
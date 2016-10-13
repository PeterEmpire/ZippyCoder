using ChurSkins;
using System;
using System.Windows.Forms;
using ZippyCoder.Entity;
using ZippyCoder.Logic;

namespace ZippyCoder
{
    public partial class ProjectFrm : CForm
    {
        private MainFrm _Owner;
        private Project _Project;
        public Project Project
        {
            get
            {
                if (_Project == null) _Project = new Project();
                _Project.Namespace = tbxNamespace.Text;

                _Project.Title = tbxTitle.Text;
                _Project.Remark = tbxRemark.Text;
                return _Project;

            }
            set
            {
                tbxNamespace.Text = value.Namespace;
                //tbxNamespace.Focus();
                tbxTitle.Text = value.Title;
                tbxRemark.Text = value.Remark;
                _Project = value;
            }
        }

        public ProjectFrm(MainFrm owner)
        {
            InitializeComponent();
            this._Owner = owner;
        }
        private void Close(object sender, EventArgs e) { this.Close(); }
        private void Save(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTitle.Text) || string.IsNullOrEmpty(tbxTitle.Text))
            {
                tbxTitle.Focus();
                CMessageBox.Show(Owner, "项目名称或命名空间必须填写!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Visible = false;
            TreeFrm treeFrm = new TreeFrm(_Owner, this);
            //treeFrm.TopMost = true;
            treeFrm.TopLevel = false;   //这个必须有不然会提示:"不能向tabControl中添加顶级控件"        
            //treeFrm.Dock = DockStyle.Fill;
            treeFrm.UpdateProjectNode(Project);
            Helpler.ChangeTitle(false, treeFrm);
            _Owner.mainTab.TabPages.Add(treeFrm.Text);
            //treeFrm.FormBorderStyle = FormBorderStyle.None;
            foreach (Control con in treeFrm.Controls)
            {
                con.Dock = DockStyle.None;
                _Owner.mainTab.TabPages[_Owner.mainTab.TabPages.Count - 1].Controls.Add(con);
                _Owner.mainTab.SelectedIndex = _Owner.mainTab.TabPages.Count - 1;
            }
            // treeFrm.Show();
            // treeFrm.mod
            //tabControl1.TabPages[0].Controls.Add(form);
            this.Close();

        }
    }
}

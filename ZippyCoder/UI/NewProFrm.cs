using ChurSkins;
using System;
using System.Windows.Forms;
using ZippyCoder.Entity;
using ZippyCoder.Logic;

namespace ZippyCoder
{
    public partial class NewPro : childBaseFrm
    {
        public NewPro(ZippyCoderFrm owner)
        {
            InitializeComponent();
            _Owner = owner;
            this.MdiParent = owner;
        }

        private ZippyCoderFrm _Owner;
        public treeFrm treeFrm;


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


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNamespace.Text))
            {
                tbxNamespace.Focus();
                CMessageBox.Show(_Owner, "命名空间不能为空", "提示", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            this.Visible = false;
            treeFrm = new treeFrm(_Owner, this);
            treeFrm.Show();
            treeFrm.UpdateProjectNode(Project);
            Helpler.ChangeTitle(false, treeFrm);
            this.Close();

        }


    }
}
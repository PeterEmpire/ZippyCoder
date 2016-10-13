using ChurSkins;
using System;
using System.Windows.Forms;
using ZippyCoder.Entity;

namespace ZippyCoder
{
    public partial class TableFrm :CForm
    {
        public TableFrm(TreeFrm treeFrm, MainFrm owner)
        {
            InitializeComponent();
            _treeFrm = treeFrm;
            _Owner = owner;
           // this.MdiParent = owner;
        }

        private TreeFrm _treeFrm;
        private MainFrm _Owner;
        private Table _Table;
        public Table Table
        {
            get
            {
                if (_Table == null) _Table = new Table();
                _Table.Name = tbxName.Text;
                _Table.Title = tbxTitle.Text;
                _Table.Remark = tbxRemark.Text;
                return _Table;
            }
            set
            {
                tbxName.Text = value.Name;
                tbxTitle.Text = value.Title;
                tbxRemark.Text = value.Remark;
                _Table = value;
            }
        }

        private void Save(object sender, EventArgs e)
        {
            _treeFrm.UpdateTableNode(Table);
            this.Close(); 
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close(); 
        } 
    }
}
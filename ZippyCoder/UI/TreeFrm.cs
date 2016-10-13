using ChurSkins;
using System;
using System.Windows.Forms;
using ZippyCoder.Entity;
using ZippyCoder.Logic;

namespace ZippyCoder
{
    public partial class TreeFrm :CForm
    {
        public TreeFrm(MainFrm owner)
        {
            InitializeComponent();
            _Owner = owner;
            // this.MdiParent = owner;
        }
        public TreeFrm(MainFrm owner, ProjectFrm newPro)
        {
            InitializeComponent();
            _Owner = owner;
            _NewPro = newPro;
            this.Project = _NewPro.Project;
            //this.MdiParent = owner;
        }
        private MainFrm _Owner;
        private ProjectFrm _NewPro;
        private TreeNode _CurrentTreeViewItem = null;

        public bool _Modified = false; //是否已经改变
        private Nodes _CurrentNode = Nodes.None;
        private ChangeTypes operation = ChangeTypes.None;
        private Project _Project = null;
        public Project Project
        {
            get { return _Project; }
            set { _Project = value; }
        }
        private TableFrm tableFrm;
        public TableFrm TableFrm
        {
            get
            {
                tableFrm = _Owner.tableFrm;
                if (tableFrm == null || tableFrm.IsDisposed)
                    tableFrm = new TableFrm(this, _Owner);
                _Owner.tableFrm = tableFrm;
                return tableFrm;
            }
            set { tableFrm = value; }
        }
        private ColFrm _uiCol = null;
        public ColFrm UiCol
        {
            get
            {
                _uiCol = _Owner.colFrm;
                if (_uiCol == null || _uiCol.IsDisposed) _uiCol = new ColFrm(_Owner, this);
                _Owner.colFrm = _uiCol;
                return _uiCol;
            }
            set { _uiCol = value; }
        }
        private System.IO.StreamWriter swSqlWriter = null;
        private Col _ClipboardCol = null;
        private Table _ClipboardTable = null;

        private string _projectPath = string.Empty;
        public string projectPath
        {
            get { return _projectPath; }
            set { _projectPath = value; }
        }

        public void UpdateUI()
        {
            TreeNode tviProject = new TreeNode();
            tviProject.Tag = Project;
            tviProject.Text = Project.Title + "[" + Project.Namespace + "]";
            tviProject.Expand();// = true;
            this.treeProject.Nodes.Add(tviProject);

            foreach (Table table in _Project.Tables)
            {
                TreeNode tviTable = new TreeNode();
                tviProject.Nodes.Add(tviTable);
                //tviProject.IsExpanded = true;
                tviTable.Tag = table;
                tviTable.Text = table.Title + "[" + table.Name + "]";

                foreach (Col col in table.Cols)
                {
                    //Helper.BatchTenantID(col);
                    TreeNode tviCol = new TreeNode();
                    tviTable.Nodes.Add(tviCol);
                    //tviTable.IsExpanded = true;
                    tviCol.Tag = col;
                    tviCol.Text = col.Title + "[" + col.Name + "]";
                }
            }

            // tviProject.IsSelected = true;
            _CurrentNode = Nodes.Project;
            _CurrentTreeViewItem = tviProject;
        }

        #region Project/Table/Col 的增删改
        public void UpdateProjectNode(Project project)
        {
            _Modified = true;

            if (_CurrentTreeViewItem == null) //当前选中的item项目不存在，表示新创
            {
                _CurrentTreeViewItem = new TreeNode();
                //treeProject.
                treeProject.Nodes.Add(_CurrentTreeViewItem);
                // _CurrentTreeViewItem.Focus();

                _CurrentNode = Nodes.Project;
            }
            _CurrentTreeViewItem.Tag = project;
            _CurrentTreeViewItem.Text = project.Title + "[" + project.Namespace + "]";

            this.Text = project.Title + "[" + project.Namespace + "]" + " - 基础数据结构";

        }
        public void UpdateTableNode(Table table)
        {
            _Modified = true;
            Helpler.ChangeTitle(false, this);
            if (_CurrentTreeViewItem.Tag is Table) //表示修改
            {
                _CurrentTreeViewItem.Tag = table;
                _CurrentTreeViewItem.Text = table.Title + "[" + table.Name + "]";
            }
            else //新建的时候加入默认列
            {
                _Project.Tables.Add(table);

                TreeNode tviTable = new TreeNode();
                _CurrentTreeViewItem.Nodes.Add(tviTable);
                //_CurrentTreeViewItem.IsExpanded = true;
                _CurrentTreeViewItem.Expand();
                tviTable.Tag = table;
                tviTable.Text = table.Title + "[" + table.Name + "]";

                //CreateDefaultCol(tviTable, table);

            }
        }
        public void UpdateColNode(Col col)
        {
            _Modified = true;
            Helpler.ChangeTitle(false, this);
            if (_CurrentTreeViewItem.Tag is Col)
            {
                _CurrentTreeViewItem.Tag = col;
                _CurrentTreeViewItem.Text = col.Title + "[" + col.Name + "]";
            }
            else if (_CurrentTreeViewItem.Tag is Table)
            {
                Table table = _CurrentTreeViewItem.Tag as Table;
                int insPos = table.Cols.Count;
                if (insPos >= 9)   //懒人列
                {
                    insPos = insPos - 8;
                }
                table.Cols.Insert(insPos, col);

                TreeNode tviCol = new TreeNode();
                _CurrentTreeViewItem.Nodes.Insert(insPos, tviCol);

                _CurrentTreeViewItem.Expand();//IsExpanded = true;
                tviCol.Tag = col;
                tviCol.Text = col.Title + "[" + col.Name + "]";
            }
        }

        private void CreateProject()
        {
            _Project = new Project();
            _NewPro.Project = _Project;
            //Navigate(_uiProject);
        }
        private void CreateTable()
        {
            Table table = new Table();
            tableFrm.Table = table;
            //Navigate(_uiTable);
        }
        private void CreateCol()
        {
            if (_uiCol == null) _uiCol = new ColFrm(_Owner, this);
            Col col = new Col();
            _uiCol.Project = _Project;
            _uiCol.Col = col;
            //Navigate(_uiCol);
        }
        #endregion

        #region node 的增删改
        public void NewNode()
        {
            operation = ChangeTypes.None;
            switch (_CurrentNode)
            {
                case Nodes.None:
                    operation = ChangeTypes.CreateProject;
                    CreateProject();
                    break;
                case Nodes.Project:
                    operation = ChangeTypes.AddTable;
                    CreateTable();
                    break;
                case Nodes.Table:
                    operation = ChangeTypes.AddCol;
                    CreateCol();
                    break;
                case Nodes.Col:
                    CMessageBox.Show(_Owner, "下面不能继续创建了。");
                    break;
            }
        }
        public void DeleteNode()
        {

            if (CMessageBox.Show(_Owner, "是否删除当前节点", "请确认", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            _Modified = true;
            Helpler.ChangeTitle(false, this);
            if (_CurrentNode == Nodes.Table)
            {

                Table table = _CurrentTreeViewItem.Tag as Table;

                operation = ChangeTypes.DropTable;
                WriteSqlLog(null, null); //没有col，但有当前 table，通过 ChangeTypes.DropTable 删除表

                TreeNode parentTV = _CurrentTreeViewItem.Parent as TreeNode;
                parentTV.Nodes.Remove(_CurrentTreeViewItem);
                _Project.Tables.Remove(table);
                CMessageBox.Show(_Owner, "删除成功！", "提示");
            }
            else if (_CurrentNode == Nodes.Col)
            {

                Col col = _CurrentTreeViewItem.Tag as Col;

                operation = ChangeTypes.DropCol;
                WriteSqlLog(col, null);  //删除列

                TreeNode parentTV = _CurrentTreeViewItem.Parent as TreeNode;
                parentTV.Nodes.Remove(_CurrentTreeViewItem);
                Table table = parentTV.Tag as Table;
                table.Cols.Remove(col);
                CMessageBox.Show(_Owner, "删除成功！", "提示");

            }
        }
        public void CopyNode()
        {
            if (_CurrentNode == Nodes.Table)
            {
                _ClipboardTable = _CurrentTreeViewItem.Tag as Table;
                //_ClipboardTable = table;
                System.Windows.DataObject dataobj = new System.Windows.DataObject(typeof(Table), _ClipboardTable);
                Clipboard.SetDataObject(dataobj);
            }
            else if (_CurrentNode == Nodes.Col)
            {
                _ClipboardCol = _CurrentTreeViewItem.Tag as Col;
                //_ClipboardCol = col;
                System.Windows.DataObject dataobj = new System.Windows.DataObject(typeof(Col), _ClipboardCol);
                Clipboard.SetDataObject(dataobj);
            }
        }
        public void PasteNode()
        {
            _Modified = true;
            Helpler.ChangeTitle(false, this);

            if (_CurrentNode == Nodes.Project && (_ClipboardTable != null)) //table 直接加入，因为带有下面的列数据
            {
                operation = ChangeTypes.None;
                Table table = _ClipboardTable;
                table.Name = table.Name;
                TreeNode tviTable = new TreeNode();
                _CurrentTreeViewItem.Nodes.Add(tviTable);
                tviTable.Tag = table;
                tviTable.Text = table.Title + "[" + table.Name + "]";

                foreach (Col col in table.Cols)
                {
                    TreeNode tviCol = new TreeNode();
                    tviTable.Nodes.Add(tviCol);
                    tviTable.Expand();
                    tviCol.Tag = col;
                    tviCol.Text = col.Title + "[" + col.Name + "]";
                }

                _Project.Tables.Add(table);

            }
            else if (_CurrentNode == Nodes.Table && (_ClipboardCol != null))  //列加入的时候，确认一下
            {
                operation = ChangeTypes.AddCol;
                Col col = _ClipboardCol;
                col.Name = col.Name;
                _uiCol.Project = _Project;
                _uiCol.Col = col;
            }
        }
        public void NodeDown()
        {
            try
            {
                TreeNode myParent = _CurrentTreeViewItem.Parent as TreeNode;

                int index = 0;
                for (; index < myParent.Nodes.Count; index++)
                {
                    if (_CurrentTreeViewItem == myParent.Nodes[index])
                    {
                        break;
                    }
                }
                myParent.Nodes.Remove(_CurrentTreeViewItem);
                myParent.Nodes.Insert(index + 1, _CurrentTreeViewItem);

                if (myParent.Tag is Project) //表移动
                {
                    _Project.Tables.Remove(_CurrentTreeViewItem.Tag as Table);
                    _Project.Tables.Insert(index + 1, _CurrentTreeViewItem.Tag as Table);

                }
                else
                {
                    Table table = myParent.Tag as Table;

                    table.Cols.Remove(_CurrentTreeViewItem.Tag as Col);
                    table.Cols.Insert(index + 1, _CurrentTreeViewItem.Tag as Col);
                }
                //_CurrentTreeViewItem.IsSelected = true;
                //ShowInfo("下移成功。");
            }
            catch
            {
                CMessageBox.Show(_Owner, "哥，不能再移动了，放过我吧", "提示");
            }
        }
        public void NodeUp()
        {
            try
            {
                TreeNode myParent = _CurrentTreeViewItem.Parent as TreeNode;

                int index = 0;
                for (; index < myParent.Nodes.Count; index++)
                {
                    if (_CurrentTreeViewItem == myParent.Nodes[index])
                    {
                        break;
                    }
                }
                myParent.Nodes.Remove(_CurrentTreeViewItem);
                myParent.Nodes.Insert(index - 1 >= 0 ? index - 1 : 0, _CurrentTreeViewItem);

                if (myParent.Tag is Project) //表移动
                {
                    _Project.Tables.Remove(_CurrentTreeViewItem.Tag as Table);
                    _Project.Tables.Insert(index - 1 >= 0 ? index - 1 : 0, _CurrentTreeViewItem.Tag as Table);

                }
                else
                {
                    Table table = myParent.Tag as Table;

                    table.Cols.Remove(_CurrentTreeViewItem.Tag as Col);
                    table.Cols.Insert(index - 1 >= 0 ? index - 1 : 0, _CurrentTreeViewItem.Tag as Col);
                }
                //_CurrentTreeViewItem.IsSelected = true;
                //ShowInfo("上移成功。");
            }
            catch
            {
                CMessageBox.Show(_Owner, "哥，不能再移动了，放过我吧", "提示");
            }
        }
        #endregion

        public void WriteSqlLog(Col col, string oldColName)
        {
            if (_CurrentTreeViewItem.Tag is Table)
            {
                SqlMonitor.WriteSqlServerChangeLog(swSqlWriter, _CurrentTreeViewItem.Tag as Table, col, operation, oldColName);
            }
            else if (_CurrentTreeViewItem.Tag is Col)
            {
                TreeNode parentTVI = _CurrentTreeViewItem.Parent as TreeNode;
                if (parentTVI.Tag is Table)
                {
                    SqlMonitor.WriteSqlServerChangeLog(swSqlWriter, parentTVI.Tag as Table, col, operation, oldColName);
                }
            }
        }

        private void mNew_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case ChangeTypes.AlterProject:
                    TableFrm.Show(); TableFrm.Activate();
                    NewNode();
                    break;
                case ChangeTypes.AlterTable:
                    UiCol.Show(); UiCol.Activate();
                    NewNode();
                    break;
            }

        }

        private void treeProject_MouseUp(object sender, MouseEventArgs e)
        {
            //System.Windows.Controls.TreeView myTV = (System.Windows.Controls.TreeView)sender;

            if (treeProject.SelectedNode == null) return;
            _CurrentTreeViewItem = treeProject.SelectedNode as TreeNode;

            if (_CurrentTreeViewItem.Tag is Project)
            {
                operation = ChangeTypes.AlterProject;
                _CurrentNode = Nodes.Project;
                if (_NewPro != null)
                    _NewPro.Project = _Project;
                //Navigate(_uiProject);
            }
            else if (_CurrentTreeViewItem.Tag is Table)
            {
                operation = ChangeTypes.AlterTable;
                _CurrentNode = Nodes.Table;
                if (tableFrm != null)
                    tableFrm.Table = (Table)_CurrentTreeViewItem.Tag;
                //Navigate(_uiTable);

            }
            else if (_CurrentTreeViewItem.Tag is Col)
            {
                operation = ChangeTypes.AlterCol;

                _CurrentNode = Nodes.Col;
                if (_uiCol != null)
                {
                    _uiCol.Project = _Project;
                    _uiCol.Col = (Col)_CurrentTreeViewItem.Tag;
                    //Navigate(_uiCol);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                //if (e.Location.Equals(treeProject.Nodes))
                menu.Show(treeProject, e.Location);
            }
        }

        private void treeFrm_Activated(object sender, EventArgs e)
        {
            _Owner.Project = _Project;
            _Owner.projectPath = _projectPath;
            _Owner.treeFrm = this;
        }

        private void treeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Text.Contains("*"))
            {
                DialogResult dlg = CMessageBox.Show(this, "数据结构已经改变，是否保存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlg == DialogResult.OK)
                {
                    if (!_Owner.SaveProject())
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            _Owner.Project = null;
            _Owner.RecordHistory();
        }

        private void Mcopy_Click(object sender, EventArgs e)
        {
            CopyNode();
        }

        private void Mdel_Click(object sender, EventArgs e)
        {
            DeleteNode();
        }

        private void Mpaste_Click(object sender, EventArgs e)
        {
            PasteNode();
        }

        private void Mup_Click(object sender, EventArgs e)
        {
            NodeUp();
        }

        private void Mdown_Click(object sender, EventArgs e)
        {
            NodeDown();
        }

        private void Mcols_Click(object sender, EventArgs e)
        {
            if (_CurrentNode == Nodes.Table)
                Helpler.CreateLazyCols(_CurrentTreeViewItem, (Table)_CurrentTreeViewItem.Tag);
        }


    }
}
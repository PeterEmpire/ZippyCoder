namespace ZippyCoder
{
    partial class ZippyCoderFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZippyCoderFrm));
            this.tool = new System.Windows.Forms.ToolStrip();
            this.btn_open = new System.Windows.Forms.ToolStripDropDownButton();
            this.MloadProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MconnectionSql = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edits = new System.Windows.Forms.ToolStripDropDownButton();
            this.MnewNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.McopyNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.MpasteNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.MdelNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.McreateCols = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_create = new System.Windows.Forms.ToolStripDropDownButton();
            this.mT4TableCoder = new System.Windows.Forms.ToolStripMenuItem();
            this.mT4ProjectCoder = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.修改列为BigIntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改列为IntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改列为GUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_new = new System.Windows.Forms.ToolStripButton();
            this.btn_copy = new System.Windows.Forms.ToolStripButton();
            this.btn_parse = new System.Windows.Forms.ToolStripButton();
            this.btn_del = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.mdiClient = new ChurSkins.CmdiClient();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool
            // 
            this.tool.BackColor = System.Drawing.Color.Transparent;
            this.tool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_open,
            this.btn_edits,
            this.btn_create,
            this.btn_edit,
            this.toolStripSeparator1,
            this.btn_new,
            this.btn_copy,
            this.btn_parse,
            this.btn_del,
            this.btn_save});
            this.tool.Location = new System.Drawing.Point(7, 54);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(808, 84);
            this.tool.TabIndex = 5;
            this.tool.Text = "toolStrip1";
            // 
            // btn_open
            // 
            this.btn_open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MloadProject,
            this.MconnectionSql,
            this.toolStripSeparator2,
            this.MSaveAs,
            this.MExit});
            this.btn_open.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_open.Image = ((System.Drawing.Image)(resources.GetObject("btn_open.Image")));
            this.btn_open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_open.Name = "btn_open";
            this.btn_open.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_open.Size = new System.Drawing.Size(77, 81);
            this.btn_open.Text = "打开方案";
            this.btn_open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MloadProject
            // 
            this.MloadProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MloadProject.Name = "MloadProject";
            this.MloadProject.Size = new System.Drawing.Size(152, 22);
            this.MloadProject.Text = "导入方案";
            this.MloadProject.Click += new System.EventHandler(this.MloadProject_Click);
            // 
            // MconnectionSql
            // 
            this.MconnectionSql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MconnectionSql.Name = "MconnectionSql";
            this.MconnectionSql.Size = new System.Drawing.Size(152, 22);
            this.MconnectionSql.Text = "连接数据库";
            this.MconnectionSql.Click += new System.EventHandler(this.MconnectionSql_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MSaveAs
            // 
            this.MSaveAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MSaveAs.Name = "MSaveAs";
            this.MSaveAs.Size = new System.Drawing.Size(152, 22);
            this.MSaveAs.Text = "项目另存为";
            // 
            // MExit
            // 
            this.MExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MExit.Name = "MExit";
            this.MExit.Size = new System.Drawing.Size(152, 22);
            this.MExit.Text = "退出";
            this.MExit.Click += new System.EventHandler(this.MExit_Click);
            // 
            // btn_edits
            // 
            this.btn_edits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnewNodes,
            this.McopyNodes,
            this.MpasteNodes,
            this.MdelNodes,
            this.McreateCols});
            this.btn_edits.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_edits.Image = ((System.Drawing.Image)(resources.GetObject("btn_edits.Image")));
            this.btn_edits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_edits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_edits.Name = "btn_edits";
            this.btn_edits.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_edits.Size = new System.Drawing.Size(77, 81);
            this.btn_edits.Text = "编辑方案";
            this.btn_edits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MnewNodes
            // 
            this.MnewNodes.Name = "MnewNodes";
            this.MnewNodes.Size = new System.Drawing.Size(136, 22);
            this.MnewNodes.Text = "新建节点";
            // 
            // McopyNodes
            // 
            this.McopyNodes.Name = "McopyNodes";
            this.McopyNodes.Size = new System.Drawing.Size(136, 22);
            this.McopyNodes.Text = "拷贝节点";
            // 
            // MpasteNodes
            // 
            this.MpasteNodes.Name = "MpasteNodes";
            this.MpasteNodes.Size = new System.Drawing.Size(136, 22);
            this.MpasteNodes.Text = "粘贴节点";
            // 
            // MdelNodes
            // 
            this.MdelNodes.Name = "MdelNodes";
            this.MdelNodes.Size = new System.Drawing.Size(136, 22);
            this.MdelNodes.Text = "删除节点";
            // 
            // McreateCols
            // 
            this.McreateCols.Name = "McreateCols";
            this.McreateCols.Size = new System.Drawing.Size(136, 22);
            this.McreateCols.Text = "新建懒人列";
            // 
            // btn_create
            // 
            this.btn_create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mT4TableCoder,
            this.mT4ProjectCoder});
            this.btn_create.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_create.Name = "btn_create";
            this.btn_create.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_create.Size = new System.Drawing.Size(77, 81);
            this.btn_create.Text = "生成项目";
            this.btn_create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mT4TableCoder
            // 
            this.mT4TableCoder.Name = "mT4TableCoder";
            this.mT4TableCoder.Size = new System.Drawing.Size(112, 22);
            this.mT4TableCoder.Text = "表源";
            // 
            // mT4ProjectCoder
            // 
            this.mT4ProjectCoder.Name = "mT4ProjectCoder";
            this.mT4ProjectCoder.Size = new System.Drawing.Size(112, 22);
            this.mT4ProjectCoder.Text = "项目源";
            // 
            // btn_edit
            // 
            this.btn_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改列为BigIntToolStripMenuItem,
            this.修改列为IntToolStripMenuItem,
            this.修改列为GUIDToolStripMenuItem});
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_edit.Size = new System.Drawing.Size(77, 81);
            this.btn_edit.Text = "快捷修改";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 修改列为BigIntToolStripMenuItem
            // 
            this.修改列为BigIntToolStripMenuItem.Name = "修改列为BigIntToolStripMenuItem";
            this.修改列为BigIntToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.修改列为BigIntToolStripMenuItem.Text = "修改列为BigInt";
            // 
            // 修改列为IntToolStripMenuItem
            // 
            this.修改列为IntToolStripMenuItem.Name = "修改列为IntToolStripMenuItem";
            this.修改列为IntToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.修改列为IntToolStripMenuItem.Text = "修改列为Int";
            // 
            // 修改列为GUIDToolStripMenuItem
            // 
            this.修改列为GUIDToolStripMenuItem.Name = "修改列为GUIDToolStripMenuItem";
            this.修改列为GUIDToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.修改列为GUIDToolStripMenuItem.Text = "修改列为GUID";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 84);
            // 
            // btn_new
            // 
            this.btn_new.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_new.Name = "btn_new";
            this.btn_new.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_new.Size = new System.Drawing.Size(68, 81);
            this.btn_new.Text = "新建";
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_copy.Image = ((System.Drawing.Image)(resources.GetObject("btn_copy.Image")));
            this.btn_copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_copy.Size = new System.Drawing.Size(68, 81);
            this.btn_copy.Text = "复制";
            this.btn_copy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_parse
            // 
            this.btn_parse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_parse.Image = ((System.Drawing.Image)(resources.GetObject("btn_parse.Image")));
            this.btn_parse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_parse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_parse.Name = "btn_parse";
            this.btn_parse.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_parse.Size = new System.Drawing.Size(68, 81);
            this.btn_parse.Text = "粘贴";
            this.btn_parse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_del
            // 
            this.btn_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_del.Name = "btn_del";
            this.btn_del.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_del.Size = new System.Drawing.Size(68, 81);
            this.btn_del.Text = "删除";
            this.btn_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_save.Size = new System.Drawing.Size(68, 81);
            this.btn_save.Text = "保存";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // mdiClient
            // 
            this.mdiClient.AutoScroll = false;
            this.mdiClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdiClient.ParentForm = this;
            // 
            // ZippyCoderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.BackToColor = false;
            this.ClientSize = new System.Drawing.Size(822, 532);
            this.Controls.Add(this.tool);
            this.ForeColor = System.Drawing.Color.Tomato;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(669, 461);
            this.Name = "ZippyCoderFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 26, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZippyCoder";
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripDropDownButton btn_open;
        private System.Windows.Forms.ToolStripMenuItem MloadProject;
        private System.Windows.Forms.ToolStripMenuItem MconnectionSql;
        private System.Windows.Forms.ToolStripDropDownButton btn_edits;
        private System.Windows.Forms.ToolStripMenuItem MnewNodes;
        private System.Windows.Forms.ToolStripMenuItem McopyNodes;
        private System.Windows.Forms.ToolStripMenuItem MpasteNodes;
        private System.Windows.Forms.ToolStripMenuItem MdelNodes;
        private System.Windows.Forms.ToolStripMenuItem McreateCols;
        private System.Windows.Forms.ToolStripDropDownButton btn_create;
        private System.Windows.Forms.ToolStripMenuItem mT4TableCoder;
        private System.Windows.Forms.ToolStripMenuItem mT4ProjectCoder;
        private System.Windows.Forms.ToolStripDropDownButton btn_edit;
        private System.Windows.Forms.ToolStripMenuItem 修改列为BigIntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改列为IntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改列为GUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_new;
        private System.Windows.Forms.ToolStripButton btn_copy;
        private System.Windows.Forms.ToolStripButton btn_parse;
        private System.Windows.Forms.ToolStripButton btn_del;
        private System.Windows.Forms.ToolStripButton btn_save;
        private ChurSkins.CmdiClient mdiClient;
        private System.Windows.Forms.ToolStripMenuItem MSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MExit;
    }
}


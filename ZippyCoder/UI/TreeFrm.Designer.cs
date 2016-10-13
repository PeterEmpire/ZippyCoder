namespace ZippyCoder
{
    partial class TreeFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeFrm));
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mNew = new System.Windows.Forms.ToolStripMenuItem();
            this.Mcopy = new System.Windows.Forms.ToolStripMenuItem();
            this.Mpaste = new System.Windows.Forms.ToolStripMenuItem();
            this.Medit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdel = new System.Windows.Forms.ToolStripMenuItem();
            this.Mcols = new System.Windows.Forms.ToolStripMenuItem();
            this.Mup = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdown = new System.Windows.Forms.ToolStripMenuItem();
            this.treeProject = new System.Windows.Forms.TreeView();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNew,
            this.Mcopy,
            this.Mpaste,
            this.Medit,
            this.Mdel,
            this.Mcols,
            this.Mup,
            this.Mdown});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(119, 180);
            // 
            // mNew
            // 
            this.mNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mNew.Name = "mNew";
            this.mNew.Size = new System.Drawing.Size(118, 22);
            this.mNew.Text = "新建(&N)";
            this.mNew.Click += new System.EventHandler(this.mNew_Click);
            // 
            // Mcopy
            // 
            this.Mcopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Mcopy.Name = "Mcopy";
            this.Mcopy.Size = new System.Drawing.Size(118, 22);
            this.Mcopy.Text = "拷贝(&C)";
            this.Mcopy.Click += new System.EventHandler(this.Mcopy_Click);
            // 
            // Mpaste
            // 
            this.Mpaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Mpaste.Name = "Mpaste";
            this.Mpaste.Size = new System.Drawing.Size(118, 22);
            this.Mpaste.Text = "粘贴(&P)";
            this.Mpaste.Click += new System.EventHandler(this.Mpaste_Click);
            // 
            // Medit
            // 
            this.Medit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Medit.Name = "Medit";
            this.Medit.Size = new System.Drawing.Size(118, 22);
            this.Medit.Text = "修改";
            // 
            // Mdel
            // 
            this.Mdel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Mdel.Name = "Mdel";
            this.Mdel.Size = new System.Drawing.Size(118, 22);
            this.Mdel.Text = "删除(&D)";
            this.Mdel.Click += new System.EventHandler(this.Mdel_Click);
            // 
            // Mcols
            // 
            this.Mcols.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Mcols.Name = "Mcols";
            this.Mcols.Size = new System.Drawing.Size(118, 22);
            this.Mcols.Text = "懒人列";
            this.Mcols.Click += new System.EventHandler(this.Mcols_Click);
            // 
            // Mup
            // 
            this.Mup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Mup.Name = "Mup";
            this.Mup.Size = new System.Drawing.Size(118, 22);
            this.Mup.Text = "上移(&A)";
            this.Mup.Click += new System.EventHandler(this.Mup_Click);
            // 
            // Mdown
            // 
            this.Mdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Mdown.Name = "Mdown";
            this.Mdown.Size = new System.Drawing.Size(118, 22);
            this.Mdown.Text = "下移(&S)";
            this.Mdown.Click += new System.EventHandler(this.Mdown_Click);
            // 
            // treeProject
            // 
            this.treeProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeProject.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.treeProject.Location = new System.Drawing.Point(1, 31);
            this.treeProject.Name = "treeProject";
            this.treeProject.Size = new System.Drawing.Size(367, 380);
            this.treeProject.TabIndex = 0;
            this.treeProject.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeProject_MouseUp);
            // 
            // TreeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderPadding = new System.Windows.Forms.Padding(1);
            this.ClientSize = new System.Drawing.Size(369, 412);
            this.Controls.Add(this.treeProject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TreeFrm";
            this.ShowCaptionPlace = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基础数据结构";
            this.Activated += new System.EventHandler(this.treeFrm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.treeFrm_FormClosing);
            this.Click += new System.EventHandler(this.treeFrm_Activated);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeProject;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mNew;
        private System.Windows.Forms.ToolStripMenuItem Mcopy;
        private System.Windows.Forms.ToolStripMenuItem Mpaste;
        private System.Windows.Forms.ToolStripMenuItem Mdel;
        private System.Windows.Forms.ToolStripMenuItem Mcols;
        private System.Windows.Forms.ToolStripMenuItem Mup;
        private System.Windows.Forms.ToolStripMenuItem Mdown;
        private System.Windows.Forms.ToolStripMenuItem Medit;




    }
}


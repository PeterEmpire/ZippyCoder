namespace ZippyCoder
{
    partial class NewPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPro));
            this.CLabel1 = new ChurSkins.CLabel();
            this.CLabel2 = new ChurSkins.CLabel();
            this.CLabel3 = new ChurSkins.CLabel();
            this.tbxNamespace = new ChurSkins.CTextBox();
            this.tbxTitle = new ChurSkins.CTextBox();
            this.tbxRemark = new ChurSkins.CTextBox();
            this.btn_save = new ChurSkins.CButton();
            this.btn_cancel = new ChurSkins.CButton();
            this.SuspendLayout();
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel1.Location = new System.Drawing.Point(22, 39);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.RoundBorder = false;
            this.CLabel1.Size = new System.Drawing.Size(68, 17);
            this.CLabel1.TabIndex = 0;
            this.CLabel1.Text = "空间命名：";
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel2.Location = new System.Drawing.Point(22, 86);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.RoundBorder = false;
            this.CLabel2.Size = new System.Drawing.Size(68, 17);
            this.CLabel2.TabIndex = 1;
            this.CLabel2.Text = "项目名称：";
            // 
            // CLabel3
            // 
            this.CLabel3.AutoSize = true;
            this.CLabel3.BackColor = System.Drawing.Color.Transparent;
            this.CLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel3.Location = new System.Drawing.Point(22, 133);
            this.CLabel3.Name = "CLabel3";
            this.CLabel3.RoundBorder = false;
            this.CLabel3.Size = new System.Drawing.Size(68, 17);
            this.CLabel3.TabIndex = 2;
            this.CLabel3.Text = "项目说明：";
            // 
            // tbxNamespace
            // 
            this.tbxNamespace.BackColor = System.Drawing.Color.Transparent;
            this.tbxNamespace.IsNum = false;
            this.tbxNamespace.IsPasswordChat = '\0';
            this.tbxNamespace.IsSystemPasswordChar = false;
            this.tbxNamespace.Location = new System.Drawing.Point(96, 39);
            this.tbxNamespace.MaxLength = 32767;
            this.tbxNamespace.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxNamespace.Name = "tbxNamespace";
            this.tbxNamespace.ReadOnly = false;
            this.tbxNamespace.Size = new System.Drawing.Size(178, 24);
            this.tbxNamespace.TabIndex = 3;
            this.tbxNamespace.WaterText = "";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = System.Drawing.Color.Transparent;
            this.tbxTitle.IsNum = false;
            this.tbxTitle.IsPasswordChat = '\0';
            this.tbxTitle.IsSystemPasswordChar = false;
            this.tbxTitle.Location = new System.Drawing.Point(96, 86);
            this.tbxTitle.MaxLength = 32767;
            this.tbxTitle.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.ReadOnly = false;
            this.tbxTitle.Size = new System.Drawing.Size(178, 24);
            this.tbxTitle.TabIndex = 4;
            this.tbxTitle.WaterText = "";
            // 
            // tbxRemark
            // 
            this.tbxRemark.BackColor = System.Drawing.Color.Transparent;
            this.tbxRemark.IsNum = false;
            this.tbxRemark.IsPasswordChat = '\0';
            this.tbxRemark.IsSystemPasswordChar = false;
            this.tbxRemark.Location = new System.Drawing.Point(96, 133);
            this.tbxRemark.MaxLength = 32767;
            this.tbxRemark.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.ReadOnly = false;
            this.tbxRemark.Size = new System.Drawing.Size(262, 90);
            this.tbxRemark.TabIndex = 5;
            this.tbxRemark.WaterText = "";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BgColor = System.Drawing.Color.Black;
            this.btn_save.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.ImageWidth = 18;
            this.btn_save.Location = new System.Drawing.Point(96, 243);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 29);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "保 存";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BgColor = System.Drawing.Color.Black;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.ImageWidth = 18;
            this.btn_cancel.Location = new System.Drawing.Point(199, 243);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取 消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // NewPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(380, 295);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tbxRemark);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.tbxNamespace);
            this.Controls.Add(this.CLabel3);
            this.Controls.Add(this.CLabel2);
            this.Controls.Add(this.CLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPro";
            this.Padding = new System.Windows.Forms.Padding(3, 26, 3, 3);
            this.Shadow = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建项目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChurSkins.CLabel CLabel1;
        private ChurSkins.CLabel CLabel2;
        private ChurSkins.CLabel CLabel3;
        private ChurSkins.CTextBox tbxNamespace;
        private ChurSkins.CTextBox tbxTitle;
        private ChurSkins.CTextBox tbxRemark;
        private ChurSkins.CButton btn_save;
        private ChurSkins.CButton btn_cancel;


    }
}


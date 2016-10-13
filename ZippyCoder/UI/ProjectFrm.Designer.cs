namespace ZippyCoder
{
    partial class ProjectFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectFrm));
            this.cLabel1 = new ChurSkins.CLabel();
            this.cLabel2 = new ChurSkins.CLabel();
            this.cLabel3 = new ChurSkins.CLabel();
            this.tbxTitle = new ChurSkins.CTextBox();
            this.tbxNamespace = new ChurSkins.CTextBox();
            this.tbxRemark = new ChurSkins.CTextBox();
            this.cButton1 = new ChurSkins.CButton();
            this.cButton2 = new ChurSkins.CButton();
            this.SuspendLayout();
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel1.Location = new System.Drawing.Point(41, 47);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel1.Size = new System.Drawing.Size(59, 17);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "项目名称:";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel2.Location = new System.Drawing.Point(41, 89);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel2.Size = new System.Drawing.Size(59, 17);
            this.cLabel2.TabIndex = 0;
            this.cLabel2.Text = "空间命名:";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel3.Location = new System.Drawing.Point(41, 126);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel3.Size = new System.Drawing.Size(59, 17);
            this.cLabel3.TabIndex = 0;
            this.cLabel3.Text = "项目说明:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = System.Drawing.Color.Transparent;
            this.tbxTitle.IsPasswordChat = '\0';
            this.tbxTitle.IsSystemPasswordChar = false;
            this.tbxTitle.Location = new System.Drawing.Point(106, 42);
            this.tbxTitle.MaxLength = 32767;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.ReadOnly = false;
            this.tbxTitle.Size = new System.Drawing.Size(237, 26);
            this.tbxTitle.TabIndex = 1;
            this.tbxTitle.WaterText = "";
            // 
            // tbxNamespace
            // 
            this.tbxNamespace.BackColor = System.Drawing.Color.Transparent;
            this.tbxNamespace.IsPasswordChat = '\0';
            this.tbxNamespace.IsSystemPasswordChar = false;
            this.tbxNamespace.Location = new System.Drawing.Point(106, 84);
            this.tbxNamespace.MaxLength = 32767;
            this.tbxNamespace.Name = "tbxNamespace";
            this.tbxNamespace.ReadOnly = false;
            this.tbxNamespace.Size = new System.Drawing.Size(237, 26);
            this.tbxNamespace.TabIndex = 1;
            this.tbxNamespace.WaterText = "";
            // 
            // tbxRemark
            // 
            this.tbxRemark.BackColor = System.Drawing.Color.Transparent;
            this.tbxRemark.IsPasswordChat = '\0';
            this.tbxRemark.IsSystemPasswordChar = false;
            this.tbxRemark.Location = new System.Drawing.Point(106, 126);
            this.tbxRemark.MaxLength = 32767;
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.ReadOnly = false;
            this.tbxRemark.Size = new System.Drawing.Size(237, 87);
            this.tbxRemark.TabIndex = 1;
            this.tbxRemark.WaterText = "";
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.Transparent;
            this.cButton1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cButton1.ForeColor = System.Drawing.Color.Black;
            this.cButton1.ImageWidth = 18;
            this.cButton1.Location = new System.Drawing.Point(171, 242);
            this.cButton1.Name = "cButton1";
            this.cButton1.RoundPadding = new System.Windows.Forms.Padding(5);
            this.cButton1.Size = new System.Drawing.Size(75, 27);
            this.cButton1.TabIndex = 2;
            this.cButton1.Text = "取 消";
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.Close);
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.Transparent;
            this.cButton2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cButton2.ForeColor = System.Drawing.Color.Black;
            this.cButton2.ImageWidth = 18;
            this.cButton2.Location = new System.Drawing.Point(268, 242);
            this.cButton2.Name = "cButton2";
            this.cButton2.RoundPadding = new System.Windows.Forms.Padding(5);
            this.cButton2.Size = new System.Drawing.Size(75, 27);
            this.cButton2.TabIndex = 2;
            this.cButton2.Text = "确 定";
            this.cButton2.UseVisualStyleBackColor = false;
            this.cButton2.Click += new System.EventHandler(this.Save);
            // 
            // ProjectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(402, 291);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.tbxRemark);
            this.Controls.Add(this.tbxNamespace);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.cLabel3);
            this.Controls.Add(this.cLabel2);
            this.Controls.Add(this.cLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectFrm";
            this.ShowCaptionPlace = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建项目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChurSkins.CLabel cLabel1;
        private ChurSkins.CLabel cLabel2;
        private ChurSkins.CLabel cLabel3;
        private ChurSkins.CTextBox tbxTitle;
        private ChurSkins.CTextBox tbxNamespace;
        private ChurSkins.CTextBox tbxRemark;
        private ChurSkins.CButton cButton1;
        private ChurSkins.CButton cButton2;
    }
}
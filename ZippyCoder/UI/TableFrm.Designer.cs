namespace ZippyCoder
{
    partial class TableFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableFrm));
            this.CLabel1 = new ChurSkins.CLabel();
            this.CLabel2 = new ChurSkins.CLabel();
            this.CLabel3 = new ChurSkins.CLabel();
            this.tbxName = new ChurSkins.CTextBox();
            this.tbxTitle = new ChurSkins.CTextBox();
            this.tbxRemark = new ChurSkins.CTextBox();
            this.btnSave = new ChurSkins.CButton();
            this.btnCancel = new ChurSkins.CButton();
            this.SuspendLayout();
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel1.Location = new System.Drawing.Point(18, 44);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel1.Size = new System.Drawing.Size(44, 17);
            this.CLabel1.TabIndex = 0;
            this.CLabel1.Text = "表名：";
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel2.Location = new System.Drawing.Point(18, 84);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel2.Size = new System.Drawing.Size(44, 17);
            this.CLabel2.TabIndex = 1;
            this.CLabel2.Text = "标题：";
            // 
            // CLabel3
            // 
            this.CLabel3.AutoSize = true;
            this.CLabel3.BackColor = System.Drawing.Color.Transparent;
            this.CLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel3.Location = new System.Drawing.Point(18, 124);
            this.CLabel3.Name = "CLabel3";
            this.CLabel3.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel3.Size = new System.Drawing.Size(44, 17);
            this.CLabel3.TabIndex = 2;
            this.CLabel3.Text = "备注：";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Transparent;
            this.tbxName.IsPasswordChat = '\0';
            this.tbxName.IsSystemPasswordChar = false;
            this.tbxName.Location = new System.Drawing.Point(68, 44);
            this.tbxName.MaxLength = 32767;
            this.tbxName.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = false;
            this.tbxName.Size = new System.Drawing.Size(178, 28);
            this.tbxName.TabIndex = 3;
            this.tbxName.WaterText = "";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = System.Drawing.Color.Transparent;
            this.tbxTitle.IsPasswordChat = '\0';
            this.tbxTitle.IsSystemPasswordChar = false;
            this.tbxTitle.Location = new System.Drawing.Point(68, 84);
            this.tbxTitle.MaxLength = 32767;
            this.tbxTitle.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.ReadOnly = false;
            this.tbxTitle.Size = new System.Drawing.Size(178, 28);
            this.tbxTitle.TabIndex = 4;
            this.tbxTitle.WaterText = "";
            // 
            // tbxRemark
            // 
            this.tbxRemark.BackColor = System.Drawing.Color.Transparent;
            this.tbxRemark.IsPasswordChat = '\0';
            this.tbxRemark.IsSystemPasswordChar = false;
            this.tbxRemark.Location = new System.Drawing.Point(68, 124);
            this.tbxRemark.MaxLength = 32767;
            this.tbxRemark.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.ReadOnly = false;
            this.tbxRemark.Size = new System.Drawing.Size(236, 79);
            this.tbxRemark.TabIndex = 5;
            this.tbxRemark.WaterText = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImageWidth = 18;
            this.btnSave.Location = new System.Drawing.Point(160, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageWidth = 18;
            this.btnCancel.Location = new System.Drawing.Point(68, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.Close);
            // 
            // TableFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(336, 274);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxRemark);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.CLabel3);
            this.Controls.Add(this.CLabel2);
            this.Controls.Add(this.CLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TableFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 26, 3, 3);
            this.ShowCaptionPlace = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "表(实体)属性";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChurSkins.CLabel CLabel1;
        private ChurSkins.CLabel CLabel2;
        private ChurSkins.CLabel CLabel3;
        private ChurSkins.CTextBox tbxName;
        private ChurSkins.CTextBox tbxTitle;
        private ChurSkins.CTextBox tbxRemark;
        private ChurSkins.CButton btnSave;
        private ChurSkins.CButton btnCancel; 
    }
}


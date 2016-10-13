namespace ZippyCoder
{
    partial class connectSQLFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectSQLFrm));
            this.CLabel1 = new ChurSkins.CLabel();
            this.CLabel2 = new ChurSkins.CLabel();
            this.CLabel3 = new ChurSkins.CLabel();
            this.CLabel4 = new ChurSkins.CLabel();
            this.btnSave = new ChurSkins.CButton();
            this.btnCancel = new ChurSkins.CButton();
            this.tbxServer = new ChurSkins.CTextBox();
            this.tbxUserName = new ChurSkins.CTextBox();
            this.tbxPassword = new ChurSkins.CTextBox();
            this.ddlDatabase = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel1.Location = new System.Drawing.Point(24, 44);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.RoundBorder = false;
            this.CLabel1.Size = new System.Drawing.Size(56, 17);
            this.CLabel1.TabIndex = 0;
            this.CLabel1.Text = "服务器：";
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel2.Location = new System.Drawing.Point(36, 81);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.RoundBorder = false;
            this.CLabel2.Size = new System.Drawing.Size(44, 17);
            this.CLabel2.TabIndex = 1;
            this.CLabel2.Text = "帐号：";
            // 
            // CLabel3
            // 
            this.CLabel3.AutoSize = true;
            this.CLabel3.BackColor = System.Drawing.Color.Transparent;
            this.CLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel3.Location = new System.Drawing.Point(36, 118);
            this.CLabel3.Name = "CLabel3";
            this.CLabel3.RoundBorder = false;
            this.CLabel3.Size = new System.Drawing.Size(44, 17);
            this.CLabel3.TabIndex = 2;
            this.CLabel3.Text = "密码：";
            // 
            // CLabel4
            // 
            this.CLabel4.AutoSize = true;
            this.CLabel4.BackColor = System.Drawing.Color.Transparent;
            this.CLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel4.Location = new System.Drawing.Point(24, 155);
            this.CLabel4.Name = "CLabel4";
            this.CLabel4.RoundBorder = false;
            this.CLabel4.Size = new System.Drawing.Size(56, 17);
            this.CLabel4.TabIndex = 3;
            this.CLabel4.Text = "数据库：";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BgColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImageWidth = 18;
            this.btnSave.Location = new System.Drawing.Point(89, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "确 定";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BgColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageWidth = 18;
            this.btnCancel.Location = new System.Drawing.Point(187, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxServer
            // 
            this.tbxServer.BackColor = System.Drawing.Color.Transparent;
            this.tbxServer.IsNum = false;
            this.tbxServer.IsPasswordChat = '\0';
            this.tbxServer.IsSystemPasswordChar = false;
            this.tbxServer.Location = new System.Drawing.Point(89, 40);
            this.tbxServer.MaxLength = 32767;
            this.tbxServer.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxServer.Name = "tbxServer";
            this.tbxServer.ReadOnly = false;
            this.tbxServer.Size = new System.Drawing.Size(178, 24);
            this.tbxServer.TabIndex = 6;
            this.tbxServer.WaterText = "请填写服务器IP";
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbxUserName.IsNum = false;
            this.tbxUserName.IsPasswordChat = '\0';
            this.tbxUserName.IsSystemPasswordChar = false;
            this.tbxUserName.Location = new System.Drawing.Point(89, 78);
            this.tbxUserName.MaxLength = 32767;
            this.tbxUserName.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.ReadOnly = false;
            this.tbxUserName.Size = new System.Drawing.Size(178, 24);
            this.tbxUserName.TabIndex = 7;
            this.tbxUserName.WaterText = "帐号密码为空则使用本地账户";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbxPassword.IsNum = false;
            this.tbxPassword.IsPasswordChat = '●';
            this.tbxPassword.IsSystemPasswordChar = true;
            this.tbxPassword.Location = new System.Drawing.Point(89, 116);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ReadOnly = false;
            this.tbxPassword.Size = new System.Drawing.Size(178, 24);
            this.tbxPassword.TabIndex = 8;
            this.tbxPassword.WaterText = "";
            // 
            // ddlDatabase
            // 
            this.ddlDatabase.FormattingEnabled = true;
            this.ddlDatabase.Location = new System.Drawing.Point(91, 154);
            this.ddlDatabase.Name = "ddlDatabase";
            this.ddlDatabase.Size = new System.Drawing.Size(149, 20);
            this.ddlDatabase.TabIndex = 9;
            this.ddlDatabase.Enter += new System.EventHandler(this.ddlDatabase_Enter);
            // 
            // connectSQLFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(307, 246);
            this.Controls.Add(this.ddlDatabase);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.tbxServer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CLabel4);
            this.Controls.Add(this.CLabel3);
            this.Controls.Add(this.CLabel2);
            this.Controls.Add(this.CLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "connectSQLFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 26, 3, 3);
            this.Shadow = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接数据库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChurSkins.CLabel CLabel1;
        private ChurSkins.CLabel CLabel2;
        private ChurSkins.CLabel CLabel3;
        private ChurSkins.CLabel CLabel4;
        private ChurSkins.CButton btnSave;
        private ChurSkins.CButton btnCancel;
        private ChurSkins.CTextBox tbxServer;
        private ChurSkins.CTextBox tbxUserName;
        private ChurSkins.CTextBox tbxPassword;
        private System.Windows.Forms.ComboBox ddlDatabase;



    }
}


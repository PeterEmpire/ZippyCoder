namespace ZippyCoder
{
    partial class ConnectSqlServerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectSqlServerFrm));
            this.cLabel1 = new ChurSkins.CLabel();
            this.cLabel2 = new ChurSkins.CLabel();
            this.cLabel3 = new ChurSkins.CLabel();
            this.combbDatabase = new System.Windows.Forms.ComboBox();
            this.cButton1 = new ChurSkins.CButton();
            this.cButton2 = new ChurSkins.CButton();
            this.cButton3 = new ChurSkins.CButton();
            this.tbxServer = new ChurSkins.CTextBox();
            this.tbxUserName = new ChurSkins.CTextBox();
            this.tbxPassword = new ChurSkins.CTextBox();
            this.cLabel4 = new ChurSkins.CLabel();
            this.SuspendLayout();
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel1.Location = new System.Drawing.Point(47, 64);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel1.Size = new System.Drawing.Size(56, 17);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "服务器：";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel2.Location = new System.Drawing.Point(59, 106);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel2.Size = new System.Drawing.Size(44, 17);
            this.cLabel2.TabIndex = 1;
            this.cLabel2.Text = "账号：";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel3.Location = new System.Drawing.Point(55, 148);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel3.Size = new System.Drawing.Size(48, 17);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "密 码：";
            // 
            // combbDatabase
            // 
            this.combbDatabase.BackColor = System.Drawing.SystemColors.Control;
            this.combbDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbDatabase.FormattingEnabled = true;
            this.combbDatabase.ItemHeight = 22;
            this.combbDatabase.Location = new System.Drawing.Point(112, 183);
            this.combbDatabase.Name = "combbDatabase";
            this.combbDatabase.Size = new System.Drawing.Size(131, 28);
            this.combbDatabase.TabIndex = 3;
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.Transparent;
            this.cButton1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cButton1.ForeColor = System.Drawing.Color.Black;
            this.cButton1.ImageWidth = 18;
            this.cButton1.Location = new System.Drawing.Point(249, 183);
            this.cButton1.Name = "cButton1";
            this.cButton1.RoundPadding = new System.Windows.Forms.Padding(5);
            this.cButton1.Size = new System.Drawing.Size(75, 29);
            this.cButton1.TabIndex = 4;
            this.cButton1.Text = "链接数据库";
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.LoadDatabase);
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.Transparent;
            this.cButton2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cButton2.ForeColor = System.Drawing.Color.Black;
            this.cButton2.ImageWidth = 18;
            this.cButton2.Location = new System.Drawing.Point(249, 241);
            this.cButton2.Name = "cButton2";
            this.cButton2.RoundPadding = new System.Windows.Forms.Padding(5);
            this.cButton2.Size = new System.Drawing.Size(75, 29);
            this.cButton2.TabIndex = 5;
            this.cButton2.Text = "确 .定";
            this.cButton2.UseVisualStyleBackColor = false;
            this.cButton2.Click += new System.EventHandler(this.Save);
            // 
            // cButton3
            // 
            this.cButton3.BackColor = System.Drawing.Color.Transparent;
            this.cButton3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cButton3.ForeColor = System.Drawing.Color.Black;
            this.cButton3.ImageWidth = 18;
            this.cButton3.Location = new System.Drawing.Point(149, 241);
            this.cButton3.Name = "cButton3";
            this.cButton3.RoundPadding = new System.Windows.Forms.Padding(5);
            this.cButton3.Size = new System.Drawing.Size(75, 29);
            this.cButton3.TabIndex = 6;
            this.cButton3.Text = "取 消";
            this.cButton3.UseVisualStyleBackColor = false;
            this.cButton3.Click += new System.EventHandler(this.Close);
            // 
            // tbxServer
            // 
            this.tbxServer.BackColor = System.Drawing.Color.Transparent;
            this.tbxServer.IsPasswordChat = '\0';
            this.tbxServer.IsSystemPasswordChar = false;
            this.tbxServer.Location = new System.Drawing.Point(112, 57);
            this.tbxServer.MaxLength = 32767;
            this.tbxServer.Name = "tbxServer";
            this.tbxServer.ReadOnly = false;
            this.tbxServer.Size = new System.Drawing.Size(212, 30);
            this.tbxServer.TabIndex = 7;
            this.tbxServer.Text = "localhost";
            this.tbxServer.WaterText = "IP 地址";
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbxUserName.IsPasswordChat = '\0';
            this.tbxUserName.IsSystemPasswordChar = false;
            this.tbxUserName.Location = new System.Drawing.Point(112, 99);
            this.tbxUserName.MaxLength = 32767;
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.ReadOnly = false;
            this.tbxUserName.Size = new System.Drawing.Size(212, 30);
            this.tbxUserName.TabIndex = 7;
            this.tbxUserName.Text = "sa";
            this.tbxUserName.WaterText = "";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbxPassword.IsPasswordChat = '●';
            this.tbxPassword.IsSystemPasswordChar = true;
            this.tbxPassword.Location = new System.Drawing.Point(112, 141);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ReadOnly = false;
            this.tbxPassword.Size = new System.Drawing.Size(212, 30);
            this.tbxPassword.TabIndex = 7;
            this.tbxPassword.WaterText = "";
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel4.Location = new System.Drawing.Point(47, 189);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel4.Size = new System.Drawing.Size(56, 17);
            this.cLabel4.TabIndex = 2;
            this.cLabel4.Text = "数据库：";
            // 
            // ConnectSqlServerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(380, 287);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.tbxServer);
            this.Controls.Add(this.cButton3);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.combbDatabase);
            this.Controls.Add(this.cLabel4);
            this.Controls.Add(this.cLabel3);
            this.Controls.Add(this.cLabel2);
            this.Controls.Add(this.cLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectSqlServerFrm";
            this.ShowCaptionPlace = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "链接SqlServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChurSkins.CLabel cLabel1;
        private ChurSkins.CLabel cLabel2;
        private ChurSkins.CLabel cLabel3;
        private System.Windows.Forms.ComboBox combbDatabase;
        private ChurSkins.CButton cButton1;
        private ChurSkins.CButton cButton2;
        private ChurSkins.CButton cButton3;
        private ChurSkins.CTextBox tbxServer;
        private ChurSkins.CTextBox tbxUserName;
        private ChurSkins.CTextBox tbxPassword;
        private ChurSkins.CLabel cLabel4;
    }
}
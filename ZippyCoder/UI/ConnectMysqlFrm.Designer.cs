namespace ZippyCoder
{
    partial class ConnectMysqlFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectMysqlFrm));
            this.txtPassword = new ChurSkins.CTextBox();
            this.txtUser = new ChurSkins.CTextBox();
            this.txtHost = new ChurSkins.CTextBox();
            this.btnCancel = new ChurSkins.CButton();
            this.btnOk = new ChurSkins.CButton();
            this.btnTryConnect = new ChurSkins.CButton();
            this.comDatabaseList = new System.Windows.Forms.ComboBox();
            this.cLabel4 = new ChurSkins.CLabel();
            this.cLabel3 = new ChurSkins.CLabel();
            this.cLabel2 = new ChurSkins.CLabel();
            this.cLabel1 = new ChurSkins.CLabel();
            this.cLabel5 = new ChurSkins.CLabel();
            this.txtPort = new ChurSkins.CTextBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.IsPasswordChat = '●';
            this.txtPassword.IsSystemPasswordChar = true;
            this.txtPassword.Location = new System.Drawing.Point(106, 173);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(212, 30);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.WaterText = "";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.IsPasswordChat = '\0';
            this.txtUser.IsSystemPasswordChar = false;
            this.txtUser.Location = new System.Drawing.Point(106, 132);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = false;
            this.txtUser.Size = new System.Drawing.Size(212, 30);
            this.txtUser.TabIndex = 17;
            this.txtUser.Text = "root";
            this.txtUser.WaterText = "";
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.Color.Transparent;
            this.txtHost.IsPasswordChat = '\0';
            this.txtHost.IsSystemPasswordChar = false;
            this.txtHost.Location = new System.Drawing.Point(106, 50);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Name = "txtHost";
            this.txtHost.ReadOnly = false;
            this.txtHost.Size = new System.Drawing.Size(212, 30);
            this.txtHost.TabIndex = 18;
            this.txtHost.Text = "localhost";
            this.txtHost.WaterText = "IP 地址";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageWidth = 18;
            this.btnCancel.Location = new System.Drawing.Point(148, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.ImageWidth = 18;
            this.btnOk.Location = new System.Drawing.Point(243, 268);
            this.btnOk.Name = "btnOk";
            this.btnOk.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnOk.Size = new System.Drawing.Size(75, 29);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "确 .定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnTryConnect
            // 
            this.btnTryConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnTryConnect.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnTryConnect.ForeColor = System.Drawing.Color.Black;
            this.btnTryConnect.ImageWidth = 18;
            this.btnTryConnect.Location = new System.Drawing.Point(243, 214);
            this.btnTryConnect.Name = "btnTryConnect";
            this.btnTryConnect.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnTryConnect.Size = new System.Drawing.Size(75, 29);
            this.btnTryConnect.TabIndex = 13;
            this.btnTryConnect.Text = "链接数据库";
            this.btnTryConnect.UseVisualStyleBackColor = false;
            this.btnTryConnect.Click += new System.EventHandler(this.btnTryConnect_Click);
            // 
            // comDatabaseList
            // 
            this.comDatabaseList.BackColor = System.Drawing.SystemColors.Control;
            this.comDatabaseList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comDatabaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDatabaseList.FormattingEnabled = true;
            this.comDatabaseList.ItemHeight = 22;
            this.comDatabaseList.Location = new System.Drawing.Point(106, 215);
            this.comDatabaseList.Name = "comDatabaseList";
            this.comDatabaseList.Size = new System.Drawing.Size(131, 28);
            this.comDatabaseList.TabIndex = 12;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel4.Location = new System.Drawing.Point(41, 221);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel4.Size = new System.Drawing.Size(47, 17);
            this.cLabel4.TabIndex = 10;
            this.cLabel4.Text = "数据库:";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel3.Location = new System.Drawing.Point(53, 180);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel3.Size = new System.Drawing.Size(35, 17);
            this.cLabel3.TabIndex = 11;
            this.cLabel3.Text = "密码:";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel2.Location = new System.Drawing.Point(41, 139);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel2.Size = new System.Drawing.Size(47, 17);
            this.cLabel2.TabIndex = 9;
            this.cLabel2.Text = "用户名:";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel1.Location = new System.Drawing.Point(41, 57);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel1.Size = new System.Drawing.Size(47, 17);
            this.cLabel1.TabIndex = 8;
            this.cLabel1.Text = "服务器:";
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.BackColor = System.Drawing.Color.Transparent;
            this.cLabel5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cLabel5.Location = new System.Drawing.Point(53, 98);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cLabel5.Size = new System.Drawing.Size(35, 17);
            this.cLabel5.TabIndex = 8;
            this.cLabel5.Text = "端口:";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.Transparent;
            this.txtPort.IsPasswordChat = '\0';
            this.txtPort.IsSystemPasswordChar = false;
            this.txtPort.Location = new System.Drawing.Point(106, 91);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = false;
            this.txtPort.Size = new System.Drawing.Size(212, 30);
            this.txtPort.TabIndex = 18;
            this.txtPort.Text = "3306";
            this.txtPort.WaterText = "IP 地址";
            // 
            // ConnectMysqlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(380, 322);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnTryConnect);
            this.Controls.Add(this.comDatabaseList);
            this.Controls.Add(this.cLabel4);
            this.Controls.Add(this.cLabel3);
            this.Controls.Add(this.cLabel5);
            this.Controls.Add(this.cLabel2);
            this.Controls.Add(this.cLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectMysqlFrm";
            this.ShowCaptionPlace = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "连接MySql服务器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChurSkins.CTextBox txtPassword;
        private ChurSkins.CTextBox txtUser;
        private ChurSkins.CTextBox txtHost;
        private ChurSkins.CButton btnCancel;
        private ChurSkins.CButton btnOk;
        private ChurSkins.CButton btnTryConnect;
        private System.Windows.Forms.ComboBox comDatabaseList;
        private ChurSkins.CLabel cLabel4;
        private ChurSkins.CLabel cLabel3;
        private ChurSkins.CLabel cLabel2;
        private ChurSkins.CLabel cLabel1;
        private ChurSkins.CLabel cLabel5;
        private ChurSkins.CTextBox txtPort;
    }
}
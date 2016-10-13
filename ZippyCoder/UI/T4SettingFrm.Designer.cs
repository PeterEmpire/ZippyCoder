namespace ZippyCoder
{
    partial class T4SettingFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T4SettingFrm));
            this.CLabel1 = new ChurSkins.CLabel();
            this.CLabel2 = new ChurSkins.CLabel();
            this.CLabel3 = new ChurSkins.CLabel();
            this.CLabel4 = new ChurSkins.CLabel();
            this.CLabel5 = new ChurSkins.CLabel();
            this.CLabel6 = new ChurSkins.CLabel();
            this.btnCheckAllTable = new ChurSkins.CCheckBox();
            this.btnCheckAllCols = new ChurSkins.CCheckBox();
            this.btnOk = new ChurSkins.CButton();
            this.btnCancel = new ChurSkins.CButton();
            this.CLabel7 = new ChurSkins.CLabel();
            this.cbxSepDir = new ChurSkins.CCheckBox();
            this.CLabel8 = new ChurSkins.CLabel();
            this.tbxPath = new ChurSkins.CTextBox();
            this.tbxNamePattern = new ChurSkins.CTextBox();
            this.tbxFixDel = new ChurSkins.CTextBox();
            this.btnChooseFile = new ChurSkins.CButton();
            this.lvCol = new System.Windows.Forms.CheckedListBox();
            this.lvTable = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel1.ForeColor = System.Drawing.Color.Black;
            this.CLabel1.Location = new System.Drawing.Point(22, 49);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel1.Size = new System.Drawing.Size(68, 17);
            this.CLabel1.TabIndex = 0;
            this.CLabel1.Text = "生成路径：";
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel2.ForeColor = System.Drawing.Color.Black;
            this.CLabel2.Location = new System.Drawing.Point(22, 88);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel2.Size = new System.Drawing.Size(72, 17);
            this.CLabel2.TabIndex = 1;
            this.CLabel2.Text = "文件加缀 ：";
            // 
            // CLabel3
            // 
            this.CLabel3.AutoSize = true;
            this.CLabel3.BackColor = System.Drawing.Color.Transparent;
            this.CLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel3.ForeColor = System.Drawing.Color.Black;
            this.CLabel3.Location = new System.Drawing.Point(22, 127);
            this.CLabel3.Name = "CLabel3";
            this.CLabel3.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel3.Size = new System.Drawing.Size(72, 17);
            this.CLabel3.TabIndex = 2;
            this.CLabel3.Text = "文件去缀 ：";
            // 
            // CLabel4
            // 
            this.CLabel4.AutoSize = true;
            this.CLabel4.BackColor = System.Drawing.Color.Transparent;
            this.CLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel4.ForeColor = System.Drawing.Color.Black;
            this.CLabel4.Location = new System.Drawing.Point(22, 163);
            this.CLabel4.Name = "CLabel4";
            this.CLabel4.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel4.Size = new System.Drawing.Size(72, 17);
            this.CLabel4.TabIndex = 3;
            this.CLabel4.Text = "独立目录 ：";
            // 
            // CLabel5
            // 
            this.CLabel5.AutoSize = true;
            this.CLabel5.BackColor = System.Drawing.Color.Transparent;
            this.CLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel5.ForeColor = System.Drawing.Color.Black;
            this.CLabel5.Location = new System.Drawing.Point(19, 198);
            this.CLabel5.Name = "CLabel5";
            this.CLabel5.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel5.Size = new System.Drawing.Size(164, 17);
            this.CLabel5.TabIndex = 4;
            this.CLabel5.Text = "请钩选你要生成的表（实体）";
            // 
            // CLabel6
            // 
            this.CLabel6.AutoSize = true;
            this.CLabel6.BackColor = System.Drawing.Color.Transparent;
            this.CLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel6.ForeColor = System.Drawing.Color.Black;
            this.CLabel6.Location = new System.Drawing.Point(296, 88);
            this.CLabel6.Name = "CLabel6";
            this.CLabel6.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel6.Size = new System.Drawing.Size(88, 17);
            this.CLabel6.TabIndex = 5;
            this.CLabel6.Text = "语法：{0}__List";
            // 
            // btnCheckAllTable
            // 
            this.btnCheckAllTable.AutoSize = true;
            this.btnCheckAllTable.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckAllTable.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCheckAllTable.ForeColor = System.Drawing.Color.Black;
            this.btnCheckAllTable.Location = new System.Drawing.Point(22, 362);
            this.btnCheckAllTable.Name = "btnCheckAllTable";
            this.btnCheckAllTable.Size = new System.Drawing.Size(80, 21);
            this.btnCheckAllTable.TabIndex = 8;
            this.btnCheckAllTable.Text = "全选/反选";
            this.btnCheckAllTable.UseVisualStyleBackColor = false;
            this.btnCheckAllTable.CheckedChanged += new System.EventHandler(this.btnCheckAllTable_CheckedChanged);
            // 
            // btnCheckAllCols
            // 
            this.btnCheckAllCols.AutoSize = true;
            this.btnCheckAllCols.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckAllCols.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCheckAllCols.ForeColor = System.Drawing.Color.Black;
            this.btnCheckAllCols.Location = new System.Drawing.Point(273, 362);
            this.btnCheckAllCols.Name = "btnCheckAllCols";
            this.btnCheckAllCols.Size = new System.Drawing.Size(80, 21);
            this.btnCheckAllCols.TabIndex = 9;
            this.btnCheckAllCols.Text = "全选/反选";
            this.btnCheckAllCols.UseVisualStyleBackColor = false;
            this.btnCheckAllCols.CheckedChanged += new System.EventHandler(this.btnCheckAllCols_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.ImageWidth = 18;
            this.btnOk.Location = new System.Drawing.Point(273, 395);
            this.btnOk.Name = "btnOk";
            this.btnOk.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnOk.Size = new System.Drawing.Size(83, 30);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "确 定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageWidth = 18;
            this.btnCancel.Location = new System.Drawing.Point(168, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CLabel7
            // 
            this.CLabel7.AutoSize = true;
            this.CLabel7.BackColor = System.Drawing.Color.Transparent;
            this.CLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel7.ForeColor = System.Drawing.Color.Black;
            this.CLabel7.Location = new System.Drawing.Point(296, 127);
            this.CLabel7.Name = "CLabel7";
            this.CLabel7.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel7.Size = new System.Drawing.Size(56, 17);
            this.CLabel7.TabIndex = 12;
            this.CLabel7.Text = "仅去前缀";
            // 
            // cbxSepDir
            // 
            this.cbxSepDir.AutoSize = true;
            this.cbxSepDir.BackColor = System.Drawing.Color.Transparent;
            this.cbxSepDir.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxSepDir.ForeColor = System.Drawing.Color.Black;
            this.cbxSepDir.Location = new System.Drawing.Point(92, 161);
            this.cbxSepDir.Name = "cbxSepDir";
            this.cbxSepDir.Size = new System.Drawing.Size(159, 21);
            this.cbxSepDir.TabIndex = 13;
            this.cbxSepDir.Text = "为每个文件生成一个目录";
            this.cbxSepDir.UseVisualStyleBackColor = false;
            // 
            // CLabel8
            // 
            this.CLabel8.AutoSize = true;
            this.CLabel8.BackColor = System.Drawing.Color.Transparent;
            this.CLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel8.ForeColor = System.Drawing.Color.Black;
            this.CLabel8.Location = new System.Drawing.Point(270, 198);
            this.CLabel8.Name = "CLabel8";
            this.CLabel8.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel8.Size = new System.Drawing.Size(128, 17);
            this.CLabel8.TabIndex = 14;
            this.CLabel8.Text = "请钩选你要生成的字段";
            // 
            // tbxPath
            // 
            this.tbxPath.BackColor = System.Drawing.Color.Transparent;
            this.tbxPath.ForeColor = System.Drawing.Color.Black;
            this.tbxPath.IsPasswordChat = '\0';
            this.tbxPath.IsSystemPasswordChar = false;
            this.tbxPath.Location = new System.Drawing.Point(92, 42);
            this.tbxPath.MaxLength = 32767;
            this.tbxPath.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.ReadOnly = false;
            this.tbxPath.Size = new System.Drawing.Size(292, 30);
            this.tbxPath.TabIndex = 15;
            this.tbxPath.WaterText = "";
            // 
            // tbxNamePattern
            // 
            this.tbxNamePattern.BackColor = System.Drawing.Color.Transparent;
            this.tbxNamePattern.ForeColor = System.Drawing.Color.Black;
            this.tbxNamePattern.IsPasswordChat = '\0';
            this.tbxNamePattern.IsSystemPasswordChar = false;
            this.tbxNamePattern.Location = new System.Drawing.Point(92, 81);
            this.tbxNamePattern.MaxLength = 32767;
            this.tbxNamePattern.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxNamePattern.Name = "tbxNamePattern";
            this.tbxNamePattern.ReadOnly = false;
            this.tbxNamePattern.Size = new System.Drawing.Size(178, 30);
            this.tbxNamePattern.TabIndex = 16;
            this.tbxNamePattern.WaterText = "";
            // 
            // tbxFixDel
            // 
            this.tbxFixDel.BackColor = System.Drawing.Color.Transparent;
            this.tbxFixDel.ForeColor = System.Drawing.Color.Black;
            this.tbxFixDel.IsPasswordChat = '\0';
            this.tbxFixDel.IsSystemPasswordChar = false;
            this.tbxFixDel.Location = new System.Drawing.Point(92, 120);
            this.tbxFixDel.MaxLength = 32767;
            this.tbxFixDel.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxFixDel.Name = "tbxFixDel";
            this.tbxFixDel.ReadOnly = false;
            this.tbxFixDel.Size = new System.Drawing.Size(178, 30);
            this.tbxFixDel.TabIndex = 17;
            this.tbxFixDel.WaterText = "";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseFile.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnChooseFile.ForeColor = System.Drawing.Color.Black;
            this.btnChooseFile.ImageWidth = 18;
            this.btnChooseFile.Location = new System.Drawing.Point(391, 42);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnChooseFile.Size = new System.Drawing.Size(66, 30);
            this.btnChooseFile.TabIndex = 18;
            this.btnChooseFile.Text = "浏览";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lvCol
            // 
            this.lvCol.ForeColor = System.Drawing.Color.Black;
            this.lvCol.FormattingEnabled = true;
            this.lvCol.Location = new System.Drawing.Point(273, 222);
            this.lvCol.Name = "lvCol";
            this.lvCol.Size = new System.Drawing.Size(254, 132);
            this.lvCol.TabIndex = 19;
            // 
            // lvTable
            // 
            this.lvTable.ForeColor = System.Drawing.Color.Black;
            this.lvTable.FormattingEnabled = true;
            this.lvTable.Location = new System.Drawing.Point(22, 222);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(245, 132);
            this.lvTable.TabIndex = 20;
            this.lvTable.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvTable_ItemCheck);
            this.lvTable.Click += new System.EventHandler(this.lvTable_Click);
            this.lvTable.Enter += new System.EventHandler(this.lvTable_Enter);
            // 
            // T4SettingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(551, 441);
            this.Controls.Add(this.lvTable);
            this.Controls.Add(this.lvCol);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.tbxFixDel);
            this.Controls.Add(this.tbxNamePattern);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.CLabel8);
            this.Controls.Add(this.cbxSepDir);
            this.Controls.Add(this.CLabel7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCheckAllCols);
            this.Controls.Add(this.btnCheckAllTable);
            this.Controls.Add(this.CLabel6);
            this.Controls.Add(this.CLabel5);
            this.Controls.Add(this.CLabel4);
            this.Controls.Add(this.CLabel3);
            this.Controls.Add(this.CLabel2);
            this.Controls.Add(this.CLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "T4SettingFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 26, 3, 3);
            this.ShowCaptionPlace = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置T4的生成属性";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChurSkins.CLabel CLabel1;
        private ChurSkins.CLabel CLabel2;
        private ChurSkins.CLabel CLabel3;
        private ChurSkins.CLabel CLabel4;
        private ChurSkins.CLabel CLabel5;
        private ChurSkins.CLabel CLabel6;
        private ChurSkins.CCheckBox btnCheckAllTable;
        private ChurSkins.CCheckBox btnCheckAllCols;
        private ChurSkins.CButton btnOk;
        private ChurSkins.CButton btnCancel;
        private ChurSkins.CLabel CLabel7;
        private ChurSkins.CCheckBox cbxSepDir;
        private ChurSkins.CLabel CLabel8;
        private ChurSkins.CTextBox tbxPath;
        private ChurSkins.CTextBox tbxNamePattern;
        private ChurSkins.CTextBox tbxFixDel;
        private ChurSkins.CButton btnChooseFile;
        private System.Windows.Forms.CheckedListBox lvCol;
        private System.Windows.Forms.CheckedListBox lvTable;



    }
}


namespace ZippyCoder
{
    partial class ColFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColFrm));
            this.CLabel1 = new ChurSkins.CLabel();
            this.CLabel2 = new ChurSkins.CLabel();
            this.CLabel3 = new ChurSkins.CLabel();
            this.CLabel4 = new ChurSkins.CLabel();
            this.CLabel5 = new ChurSkins.CLabel();
            this.CLabel6 = new ChurSkins.CLabel();
            this.CLabel7 = new ChurSkins.CLabel();
            this.tbxName = new ChurSkins.CTextBox();
            this.tbxTitle = new ChurSkins.CTextBox();
            this.tbxLength = new ChurSkins.CTextBox();
            this.tbxDefault = new ChurSkins.CTextBox();
            this.btnSave = new ChurSkins.CButton();
            this.btnCancel = new ChurSkins.CButton();
            this.CLabel8 = new ChurSkins.CLabel();
            this.tbxRemark = new ChurSkins.CTextBox();
            this.cbxPK = new ChurSkins.CCheckBox();
            this.cbxAutoIncreament = new ChurSkins.CCheckBox();
            this.cbxUnique = new ChurSkins.CCheckBox();
            this.cbxIsNull = new ChurSkins.CCheckBox();
            this.cbxIsIndex = new ChurSkins.CCheckBox();
            this.tbxFKTable = new System.Windows.Forms.ComboBox();
            this.tbxFKCol = new System.Windows.Forms.ComboBox();
            this.tbxFKColTitle = new System.Windows.Forms.ComboBox();
            this.cbxFKNoCheck = new ChurSkins.CCheckBox();
            this.cbxFKDeleteCascade = new ChurSkins.CCheckBox();
            this.tbxDataType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLabel1.Location = new System.Drawing.Point(36, 51);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel1.Size = new System.Drawing.Size(68, 17);
            this.CLabel1.TabIndex = 0;
            this.CLabel1.Text = "字段名称：";
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLabel2.Location = new System.Drawing.Point(36, 87);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel2.Size = new System.Drawing.Size(68, 17);
            this.CLabel2.TabIndex = 1;
            this.CLabel2.Text = "字段标题：";
            // 
            // CLabel3
            // 
            this.CLabel3.AutoSize = true;
            this.CLabel3.BackColor = System.Drawing.Color.Transparent;
            this.CLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLabel3.Location = new System.Drawing.Point(36, 122);
            this.CLabel3.Name = "CLabel3";
            this.CLabel3.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel3.Size = new System.Drawing.Size(68, 17);
            this.CLabel3.TabIndex = 2;
            this.CLabel3.Text = "数据类型：";
            // 
            // CLabel4
            // 
            this.CLabel4.AutoSize = true;
            this.CLabel4.BackColor = System.Drawing.Color.Transparent;
            this.CLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLabel4.Location = new System.Drawing.Point(36, 159);
            this.CLabel4.Name = "CLabel4";
            this.CLabel4.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel4.Size = new System.Drawing.Size(80, 17);
            this.CLabel4.TabIndex = 3;
            this.CLabel4.Text = "长度／精度：";
            // 
            // CLabel5
            // 
            this.CLabel5.AutoSize = true;
            this.CLabel5.BackColor = System.Drawing.Color.Transparent;
            this.CLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLabel5.Location = new System.Drawing.Point(36, 195);
            this.CLabel5.Name = "CLabel5";
            this.CLabel5.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel5.Size = new System.Drawing.Size(56, 17);
            this.CLabel5.TabIndex = 4;
            this.CLabel5.Text = "默认值：";
            // 
            // CLabel6
            // 
            this.CLabel6.AutoSize = true;
            this.CLabel6.BackColor = System.Drawing.Color.Transparent;
            this.CLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLabel6.Location = new System.Drawing.Point(36, 227);
            this.CLabel6.Name = "CLabel6";
            this.CLabel6.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel6.Size = new System.Drawing.Size(68, 17);
            this.CLabel6.TabIndex = 5;
            this.CLabel6.Text = "字段属性：";
            // 
            // CLabel7
            // 
            this.CLabel7.AutoSize = true;
            this.CLabel7.BackColor = System.Drawing.Color.Transparent;
            this.CLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLabel7.Location = new System.Drawing.Point(36, 266);
            this.CLabel7.Name = "CLabel7";
            this.CLabel7.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel7.Size = new System.Drawing.Size(68, 17);
            this.CLabel7.TabIndex = 6;
            this.CLabel7.Text = "外键关联：";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Transparent;
            this.tbxName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxName.IsPasswordChat = '\0';
            this.tbxName.IsSystemPasswordChar = false;
            this.tbxName.Location = new System.Drawing.Point(112, 45);
            this.tbxName.MaxLength = 32767;
            this.tbxName.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = false;
            this.tbxName.Size = new System.Drawing.Size(269, 28);
            this.tbxName.TabIndex = 7;
            this.tbxName.WaterText = "";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = System.Drawing.Color.Transparent;
            this.tbxTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxTitle.IsPasswordChat = '\0';
            this.tbxTitle.IsSystemPasswordChar = false;
            this.tbxTitle.Location = new System.Drawing.Point(112, 81);
            this.tbxTitle.MaxLength = 32767;
            this.tbxTitle.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.ReadOnly = false;
            this.tbxTitle.Size = new System.Drawing.Size(269, 28);
            this.tbxTitle.TabIndex = 8;
            this.tbxTitle.WaterText = "";
            // 
            // tbxLength
            // 
            this.tbxLength.BackColor = System.Drawing.Color.Transparent;
            this.tbxLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxLength.IsPasswordChat = '\0';
            this.tbxLength.IsSystemPasswordChar = false;
            this.tbxLength.Location = new System.Drawing.Point(112, 153);
            this.tbxLength.MaxLength = 32767;
            this.tbxLength.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.ReadOnly = false;
            this.tbxLength.Size = new System.Drawing.Size(177, 28);
            this.tbxLength.TabIndex = 10;
            this.tbxLength.WaterText = "";
            // 
            // tbxDefault
            // 
            this.tbxDefault.BackColor = System.Drawing.Color.Transparent;
            this.tbxDefault.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxDefault.IsPasswordChat = '\0';
            this.tbxDefault.IsSystemPasswordChar = false;
            this.tbxDefault.Location = new System.Drawing.Point(112, 189);
            this.tbxDefault.MaxLength = 32767;
            this.tbxDefault.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxDefault.Name = "tbxDefault";
            this.tbxDefault.ReadOnly = false;
            this.tbxDefault.Size = new System.Drawing.Size(308, 28);
            this.tbxDefault.TabIndex = 11;
            this.tbxDefault.WaterText = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImageWidth = 18;
            this.btnSave.Location = new System.Drawing.Point(215, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(78, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageWidth = 18;
            this.btnCancel.Location = new System.Drawing.Point(110, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RoundPadding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CLabel8
            // 
            this.CLabel8.AutoSize = true;
            this.CLabel8.BackColor = System.Drawing.Color.Transparent;
            this.CLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLabel8.Location = new System.Drawing.Point(36, 297);
            this.CLabel8.Name = "CLabel8";
            this.CLabel8.RoundPadding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CLabel8.Size = new System.Drawing.Size(44, 17);
            this.CLabel8.TabIndex = 16;
            this.CLabel8.Text = "备注：";
            // 
            // tbxRemark
            // 
            this.tbxRemark.BackColor = System.Drawing.Color.Transparent;
            this.tbxRemark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxRemark.IsPasswordChat = '\0';
            this.tbxRemark.IsSystemPasswordChar = false;
            this.tbxRemark.Location = new System.Drawing.Point(110, 297);
            this.tbxRemark.MaxLength = 32767;
            this.tbxRemark.MinimumSize = new System.Drawing.Size(20, 24);
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.ReadOnly = false;
            this.tbxRemark.Size = new System.Drawing.Size(439, 100);
            this.tbxRemark.TabIndex = 17;
            this.tbxRemark.WaterText = "";
            // 
            // cbxPK
            // 
            this.cbxPK.AutoSize = true;
            this.cbxPK.BackColor = System.Drawing.Color.Transparent;
            this.cbxPK.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxPK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxPK.Location = new System.Drawing.Point(113, 225);
            this.cbxPK.Name = "cbxPK";
            this.cbxPK.Size = new System.Drawing.Size(51, 21);
            this.cbxPK.TabIndex = 18;
            this.cbxPK.Text = "主键";
            this.cbxPK.UseVisualStyleBackColor = false;
            // 
            // cbxAutoIncreament
            // 
            this.cbxAutoIncreament.AutoSize = true;
            this.cbxAutoIncreament.BackColor = System.Drawing.Color.Transparent;
            this.cbxAutoIncreament.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxAutoIncreament.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxAutoIncreament.Location = new System.Drawing.Point(173, 225);
            this.cbxAutoIncreament.Name = "cbxAutoIncreament";
            this.cbxAutoIncreament.Size = new System.Drawing.Size(63, 21);
            this.cbxAutoIncreament.TabIndex = 19;
            this.cbxAutoIncreament.Text = "自增长";
            this.cbxAutoIncreament.UseVisualStyleBackColor = false;
            // 
            // cbxUnique
            // 
            this.cbxUnique.AutoSize = true;
            this.cbxUnique.BackColor = System.Drawing.Color.Transparent;
            this.cbxUnique.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxUnique.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxUnique.Location = new System.Drawing.Point(245, 225);
            this.cbxUnique.Name = "cbxUnique";
            this.cbxUnique.Size = new System.Drawing.Size(51, 21);
            this.cbxUnique.TabIndex = 20;
            this.cbxUnique.Text = "唯一";
            this.cbxUnique.UseVisualStyleBackColor = false;
            // 
            // cbxIsNull
            // 
            this.cbxIsNull.AutoSize = true;
            this.cbxIsNull.BackColor = System.Drawing.Color.Transparent;
            this.cbxIsNull.Checked = true;
            this.cbxIsNull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIsNull.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxIsNull.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxIsNull.Location = new System.Drawing.Point(305, 225);
            this.cbxIsNull.Name = "cbxIsNull";
            this.cbxIsNull.Size = new System.Drawing.Size(51, 21);
            this.cbxIsNull.TabIndex = 21;
            this.cbxIsNull.Text = "可空";
            this.cbxIsNull.UseVisualStyleBackColor = false;
            // 
            // cbxIsIndex
            // 
            this.cbxIsIndex.AutoSize = true;
            this.cbxIsIndex.BackColor = System.Drawing.Color.Transparent;
            this.cbxIsIndex.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxIsIndex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxIsIndex.Location = new System.Drawing.Point(365, 225);
            this.cbxIsIndex.Name = "cbxIsIndex";
            this.cbxIsIndex.Size = new System.Drawing.Size(51, 21);
            this.cbxIsIndex.TabIndex = 22;
            this.cbxIsIndex.Text = "索引";
            this.cbxIsIndex.UseVisualStyleBackColor = false;
            // 
            // tbxFKTable
            // 
            this.tbxFKTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbxFKTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxFKTable.FormattingEnabled = true;
            this.tbxFKTable.ItemHeight = 20;
            this.tbxFKTable.Location = new System.Drawing.Point(110, 261);
            this.tbxFKTable.Name = "tbxFKTable";
            this.tbxFKTable.Size = new System.Drawing.Size(105, 26);
            this.tbxFKTable.TabIndex = 23;
            // 
            // tbxFKCol
            // 
            this.tbxFKCol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbxFKCol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxFKCol.FormattingEnabled = true;
            this.tbxFKCol.ItemHeight = 20;
            this.tbxFKCol.Location = new System.Drawing.Point(218, 261);
            this.tbxFKCol.Name = "tbxFKCol";
            this.tbxFKCol.Size = new System.Drawing.Size(97, 26);
            this.tbxFKCol.TabIndex = 24;
            // 
            // tbxFKColTitle
            // 
            this.tbxFKColTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbxFKColTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxFKColTitle.FormattingEnabled = true;
            this.tbxFKColTitle.ItemHeight = 20;
            this.tbxFKColTitle.Location = new System.Drawing.Point(318, 261);
            this.tbxFKColTitle.Name = "tbxFKColTitle";
            this.tbxFKColTitle.Size = new System.Drawing.Size(98, 26);
            this.tbxFKColTitle.TabIndex = 25;
            // 
            // cbxFKNoCheck
            // 
            this.cbxFKNoCheck.AutoSize = true;
            this.cbxFKNoCheck.BackColor = System.Drawing.Color.Transparent;
            this.cbxFKNoCheck.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxFKNoCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxFKNoCheck.Location = new System.Drawing.Point(425, 261);
            this.cbxFKNoCheck.Name = "cbxFKNoCheck";
            this.cbxFKNoCheck.Size = new System.Drawing.Size(75, 21);
            this.cbxFKNoCheck.TabIndex = 26;
            this.cbxFKNoCheck.Text = "松散约束";
            this.cbxFKNoCheck.UseVisualStyleBackColor = false;
            // 
            // cbxFKDeleteCascade
            // 
            this.cbxFKDeleteCascade.AutoSize = true;
            this.cbxFKDeleteCascade.BackColor = System.Drawing.Color.Transparent;
            this.cbxFKDeleteCascade.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxFKDeleteCascade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxFKDeleteCascade.Location = new System.Drawing.Point(495, 261);
            this.cbxFKDeleteCascade.Name = "cbxFKDeleteCascade";
            this.cbxFKDeleteCascade.Size = new System.Drawing.Size(75, 21);
            this.cbxFKDeleteCascade.TabIndex = 27;
            this.cbxFKDeleteCascade.Text = "连级删除";
            this.cbxFKDeleteCascade.UseVisualStyleBackColor = false;
            // 
            // tbxDataType
            // 
            this.tbxDataType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbxDataType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxDataType.FormattingEnabled = true;
            this.tbxDataType.ItemHeight = 20;
            this.tbxDataType.Location = new System.Drawing.Point(112, 117);
            this.tbxDataType.Name = "tbxDataType";
            this.tbxDataType.Size = new System.Drawing.Size(174, 26);
            this.tbxDataType.TabIndex = 28;
            // 
            // ColFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.tbxDataType);
            this.Controls.Add(this.cbxFKDeleteCascade);
            this.Controls.Add(this.cbxFKNoCheck);
            this.Controls.Add(this.tbxFKColTitle);
            this.Controls.Add(this.tbxFKCol);
            this.Controls.Add(this.tbxFKTable);
            this.Controls.Add(this.cbxIsIndex);
            this.Controls.Add(this.cbxIsNull);
            this.Controls.Add(this.cbxUnique);
            this.Controls.Add(this.cbxAutoIncreament);
            this.Controls.Add(this.cbxPK);
            this.Controls.Add(this.tbxRemark);
            this.Controls.Add(this.CLabel8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxDefault);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.CLabel7);
            this.Controls.Add(this.CLabel6);
            this.Controls.Add(this.CLabel5);
            this.Controls.Add(this.CLabel4);
            this.Controls.Add(this.CLabel3);
            this.Controls.Add(this.CLabel2);
            this.Controls.Add(this.CLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 26, 3, 3);
            this.ShowCaptionPlace = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字段";
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
        private ChurSkins.CLabel CLabel7;
        private ChurSkins.CTextBox tbxName;
        private ChurSkins.CTextBox tbxTitle;
        private ChurSkins.CTextBox tbxLength;
        private ChurSkins.CTextBox tbxDefault;
        private ChurSkins.CButton btnSave;
        private ChurSkins.CButton btnCancel;
        private ChurSkins.CLabel CLabel8;
        private ChurSkins.CTextBox tbxRemark;
        private ChurSkins.CCheckBox cbxPK;
        private ChurSkins.CCheckBox cbxAutoIncreament;
        private ChurSkins.CCheckBox cbxUnique;
        private ChurSkins.CCheckBox cbxIsNull;
        private ChurSkins.CCheckBox cbxIsIndex;
        private System.Windows.Forms.ComboBox tbxFKTable;
        private System.Windows.Forms.ComboBox tbxFKCol;
        private System.Windows.Forms.ComboBox tbxFKColTitle;
        private ChurSkins.CCheckBox cbxFKNoCheck;
        private ChurSkins.CCheckBox cbxFKDeleteCascade;
        private System.Windows.Forms.ComboBox tbxDataType;



    }
}


namespace Students_Information_Sys
{
    partial class FrmClassUpdate
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblString = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblpClassAdd = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeadTeacher = new System.Windows.Forms.TextBox();
            this.lblHeadTeacher = new System.Windows.Forms.Label();
            this.lblEnrolmentTime = new System.Windows.Forms.Label();
            this.dateTimeEnrolmentTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtClassNum = new System.Windows.Forms.TextBox();
            this.numericUpDownSchoolReform = new System.Windows.Forms.NumericUpDown();
            this.lblSchoolReform = new System.Windows.Forms.Label();
            this.lblClassNum = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblSpecialityName = new System.Windows.Forms.Label();
            this.combCollageName = new System.Windows.Forms.ComboBox();
            this.combSpecialityName = new System.Windows.Forms.ComboBox();
            this.combClassName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tblpClassAdd.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchoolReform)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblString, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 13);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(572, 342);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(572, 342);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.876145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.27248F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.85137F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 342);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblString
            // 
            this.lblString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblString.AutoSize = true;
            this.lblString.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblString.Location = new System.Drawing.Point(196, 3);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(180, 27);
            this.lblString.TabIndex = 0;
            this.lblString.Text = "修改班级信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.tblpClassAdd);
            this.groupBox1.Location = new System.Drawing.Point(3, 36);
            this.groupBox1.MaximumSize = new System.Drawing.Size(606, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "班级详细信息";
            // 
            // tblpClassAdd
            // 
            this.tblpClassAdd.ColumnCount = 4;
            this.tblpClassAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblpClassAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblpClassAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblpClassAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblpClassAdd.Controls.Add(this.label1, 0, 0);
            this.tblpClassAdd.Controls.Add(this.txtHeadTeacher, 3, 1);
            this.tblpClassAdd.Controls.Add(this.lblHeadTeacher, 2, 1);
            this.tblpClassAdd.Controls.Add(this.lblEnrolmentTime, 2, 2);
            this.tblpClassAdd.Controls.Add(this.dateTimeEnrolmentTime, 3, 2);
            this.tblpClassAdd.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tblpClassAdd.Controls.Add(this.txtRemark, 1, 3);
            this.tblpClassAdd.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tblpClassAdd.Controls.Add(this.lblClassName, 0, 2);
            this.tblpClassAdd.Controls.Add(this.lblSpecialityName, 0, 1);
            this.tblpClassAdd.Controls.Add(this.combCollageName, 1, 0);
            this.tblpClassAdd.Controls.Add(this.combSpecialityName, 1, 1);
            this.tblpClassAdd.Controls.Add(this.combClassName, 1, 2);
            this.tblpClassAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpClassAdd.Location = new System.Drawing.Point(3, 17);
            this.tblpClassAdd.Name = "tblpClassAdd";
            this.tblpClassAdd.RowCount = 4;
            this.tblpClassAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpClassAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpClassAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpClassAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblpClassAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpClassAdd.Size = new System.Drawing.Size(560, 241);
            this.tblpClassAdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "学    院";
            // 
            // txtHeadTeacher
            // 
            this.txtHeadTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeadTeacher.Location = new System.Drawing.Point(367, 61);
            this.txtHeadTeacher.Name = "txtHeadTeacher";
            this.txtHeadTeacher.Size = new System.Drawing.Size(190, 21);
            this.txtHeadTeacher.TabIndex = 5;
            // 
            // lblHeadTeacher
            // 
            this.lblHeadTeacher.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHeadTeacher.AutoSize = true;
            this.lblHeadTeacher.Location = new System.Drawing.Point(308, 66);
            this.lblHeadTeacher.Name = "lblHeadTeacher";
            this.lblHeadTeacher.Size = new System.Drawing.Size(53, 12);
            this.lblHeadTeacher.TabIndex = 8;
            this.lblHeadTeacher.Text = "班 主 任";
            // 
            // lblEnrolmentTime
            // 
            this.lblEnrolmentTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEnrolmentTime.AutoSize = true;
            this.lblEnrolmentTime.Location = new System.Drawing.Point(308, 114);
            this.lblEnrolmentTime.Name = "lblEnrolmentTime";
            this.lblEnrolmentTime.Size = new System.Drawing.Size(53, 12);
            this.lblEnrolmentTime.TabIndex = 9;
            this.lblEnrolmentTime.Text = "入学时间";
            // 
            // dateTimeEnrolmentTime
            // 
            this.dateTimeEnrolmentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeEnrolmentTime.Location = new System.Drawing.Point(367, 109);
            this.dateTimeEnrolmentTime.Name = "dateTimeEnrolmentTime";
            this.dateTimeEnrolmentTime.Size = new System.Drawing.Size(190, 21);
            this.dateTimeEnrolmentTime.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblRemark, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 147);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(78, 91);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // lblRemark
            // 
            this.lblRemark.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(22, 16);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(53, 12);
            this.lblRemark.TabIndex = 6;
            this.lblRemark.Text = "备    注";
            // 
            // txtRemark
            // 
            this.txtRemark.AcceptsReturn = true;
            this.txtRemark.AcceptsTab = true;
            this.tblpClassAdd.SetColumnSpan(this.txtRemark, 3);
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Location = new System.Drawing.Point(87, 147);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(470, 91);
            this.txtRemark.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tblpClassAdd.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.56204F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.46715F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.89781F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.07299F));
            this.tableLayoutPanel2.Controls.Add(this.txtClassNum, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownSchoolReform, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSchoolReform, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblClassNum, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(283, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 42);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // txtClassNum
            // 
            this.txtClassNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClassNum.Location = new System.Drawing.Point(83, 10);
            this.txtClassNum.Name = "txtClassNum";
            this.txtClassNum.Size = new System.Drawing.Size(71, 21);
            this.txtClassNum.TabIndex = 3;
            // 
            // numericUpDownSchoolReform
            // 
            this.numericUpDownSchoolReform.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownSchoolReform.Location = new System.Drawing.Point(220, 10);
            this.numericUpDownSchoolReform.Name = "numericUpDownSchoolReform";
            this.numericUpDownSchoolReform.Size = new System.Drawing.Size(50, 21);
            this.numericUpDownSchoolReform.TabIndex = 4;
            // 
            // lblSchoolReform
            // 
            this.lblSchoolReform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSchoolReform.AutoSize = true;
            this.lblSchoolReform.Location = new System.Drawing.Point(161, 15);
            this.lblSchoolReform.Name = "lblSchoolReform";
            this.lblSchoolReform.Size = new System.Drawing.Size(53, 12);
            this.lblSchoolReform.TabIndex = 7;
            this.lblSchoolReform.Text = "学    制";
            // 
            // lblClassNum
            // 
            this.lblClassNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClassNum.AutoSize = true;
            this.lblClassNum.Location = new System.Drawing.Point(24, 15);
            this.lblClassNum.Name = "lblClassNum";
            this.lblClassNum.Size = new System.Drawing.Size(53, 12);
            this.lblClassNum.TabIndex = 5;
            this.lblClassNum.Text = "教室编号";
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(28, 114);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(53, 12);
            this.lblClassName.TabIndex = 3;
            this.lblClassName.Text = "班级名称";
            // 
            // lblSpecialityName
            // 
            this.lblSpecialityName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSpecialityName.AutoSize = true;
            this.lblSpecialityName.Location = new System.Drawing.Point(28, 66);
            this.lblSpecialityName.Name = "lblSpecialityName";
            this.lblSpecialityName.Size = new System.Drawing.Size(53, 12);
            this.lblSpecialityName.TabIndex = 4;
            this.lblSpecialityName.Text = "专    业";
            // 
            // combCollageName
            // 
            this.combCollageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combCollageName.FormattingEnabled = true;
            this.combCollageName.Location = new System.Drawing.Point(87, 14);
            this.combCollageName.Name = "combCollageName";
            this.combCollageName.Size = new System.Drawing.Size(190, 20);
            this.combCollageName.TabIndex = 0;
            // 
            // combSpecialityName
            // 
            this.combSpecialityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combSpecialityName.FormattingEnabled = true;
            this.combSpecialityName.Location = new System.Drawing.Point(87, 62);
            this.combSpecialityName.Name = "combSpecialityName";
            this.combSpecialityName.Size = new System.Drawing.Size(190, 20);
            this.combSpecialityName.TabIndex = 1;
            // 
            // combClassName
            // 
            this.combClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combClassName.FormattingEnabled = true;
            this.combClassName.Location = new System.Drawing.Point(87, 110);
            this.combClassName.Name = "combClassName";
            this.combClassName.Size = new System.Drawing.Size(190, 20);
            this.combClassName.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(566, 36);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(56, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(433, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(244, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmClassUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmClassUpdate";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.Text = "修改班级信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tblpClassAdd.ResumeLayout(false);
            this.tblpClassAdd.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchoolReform)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tblpClassAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeadTeacher;
        private System.Windows.Forms.Label lblHeadTeacher;
        private System.Windows.Forms.Label lblEnrolmentTime;
        private System.Windows.Forms.DateTimePicker dateTimeEnrolmentTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtClassNum;
        private System.Windows.Forms.NumericUpDown numericUpDownSchoolReform;
        private System.Windows.Forms.Label lblSchoolReform;
        private System.Windows.Forms.Label lblClassNum;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblSpecialityName;
        private System.Windows.Forms.ComboBox combCollageName;
        private System.Windows.Forms.ComboBox combSpecialityName;
        private System.Windows.Forms.ComboBox combClassName;
    }
}
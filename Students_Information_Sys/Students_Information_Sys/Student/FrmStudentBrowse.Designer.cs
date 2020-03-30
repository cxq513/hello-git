namespace Students_Information_Sys
{
    partial class FrmStudentBrowse
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.lblStuNumber = new System.Windows.Forms.Label();
            this.lblStuNumberDown = new System.Windows.Forms.Button();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.lblStuNumberUp = new System.Windows.Forms.Button();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.btnPrintingClass = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClassName = new System.Windows.Forms.Label();
            this.btnNameDown = new System.Windows.Forms.Button();
            this.combClassName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNameUp = new System.Windows.Forms.Button();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentBrithday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNativeplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCollage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPolitical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblboss = new System.Windows.Forms.Label();
            this.students_Information_SysDataSet = new Students_Information_Sys.Students_Information_SysDataSet();
            this.studentsInformationSysDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbStudentInfoTableAdapter = new Students_Information_Sys.Students_Information_SysDataSetTableAdapters.tbStudentInfoTableAdapter();
            this.tbStudentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_Information_SysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInformationSysDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvStudentList, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblboss, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 532);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按学号精确查询";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.Controls.Add(this.btnPrinting, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStuNumber, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStuNumberDown, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSearch1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStuNumberUp, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtStudentNumber, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPrintingClass, 6, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(842, 48);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrinting.Location = new System.Drawing.Point(642, 12);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(94, 23);
            this.btnPrinting.TabIndex = 10;
            this.btnPrinting.Text = "打印学生信息";
            this.btnPrinting.UseVisualStyleBackColor = true;
            this.btnPrinting.Click += new System.EventHandler(this.btnPrinting_Click);
            // 
            // lblStuNumber
            // 
            this.lblStuNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStuNumber.AutoSize = true;
            this.lblStuNumber.Location = new System.Drawing.Point(21, 18);
            this.lblStuNumber.Name = "lblStuNumber";
            this.lblStuNumber.Size = new System.Drawing.Size(77, 12);
            this.lblStuNumber.TabIndex = 0;
            this.lblStuNumber.Text = "请输入学号：";
            // 
            // lblStuNumberDown
            // 
            this.lblStuNumberDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStuNumberDown.Location = new System.Drawing.Point(551, 12);
            this.lblStuNumberDown.Name = "lblStuNumberDown";
            this.lblStuNumberDown.Size = new System.Drawing.Size(75, 23);
            this.lblStuNumberDown.TabIndex = 7;
            this.lblStuNumberDown.Text = "学号降序";
            this.lblStuNumberDown.UseVisualStyleBackColor = true;
            this.lblStuNumberDown.Click += new System.EventHandler(this.lblStuNumberDown_Click);
            // 
            // btnSearch1
            // 
            this.btnSearch1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch1.Location = new System.Drawing.Point(349, 12);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 3;
            this.btnSearch1.Text = "查询";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // lblStuNumberUp
            // 
            this.lblStuNumberUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStuNumberUp.Location = new System.Drawing.Point(450, 12);
            this.lblStuNumberUp.Name = "lblStuNumberUp";
            this.lblStuNumberUp.Size = new System.Drawing.Size(75, 23);
            this.lblStuNumberUp.TabIndex = 6;
            this.lblStuNumberUp.Text = "学号升序";
            this.lblStuNumberUp.UseVisualStyleBackColor = true;
            this.lblStuNumberUp.Click += new System.EventHandler(this.lblStuNumberUp_Click);
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStudentNumber.Location = new System.Drawing.Point(104, 13);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(228, 21);
            this.txtStudentNumber.TabIndex = 2;
            this.txtStudentNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentNumber_KeyDown);
            // 
            // btnPrintingClass
            // 
            this.btnPrintingClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintingClass.Location = new System.Drawing.Point(744, 12);
            this.btnPrintingClass.Name = "btnPrintingClass";
            this.btnPrintingClass.Size = new System.Drawing.Size(94, 23);
            this.btnPrintingClass.TabIndex = 11;
            this.btnPrintingClass.Text = "导出班级信息";
            this.btnPrintingClass.UseVisualStyleBackColor = true;
            this.btnPrintingClass.Click += new System.EventHandler(this.btnPrintingClass_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[按照班级查询]";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.Controls.Add(this.lblClassName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnNameDown, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.combClassName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnNameUp, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(842, 43);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(33, 15);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(65, 12);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "学生班级：";
            // 
            // btnNameDown
            // 
            this.btnNameDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNameDown.Location = new System.Drawing.Point(551, 10);
            this.btnNameDown.Name = "btnNameDown";
            this.btnNameDown.Size = new System.Drawing.Size(75, 23);
            this.btnNameDown.TabIndex = 5;
            this.btnNameDown.Text = "姓名降序";
            this.btnNameDown.UseVisualStyleBackColor = true;
            this.btnNameDown.Click += new System.EventHandler(this.btnNameDown_Click);
            // 
            // combClassName
            // 
            this.combClassName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combClassName.FormattingEnabled = true;
            this.combClassName.Location = new System.Drawing.Point(104, 11);
            this.combClassName.Name = "combClassName";
            this.combClassName.Size = new System.Drawing.Size(229, 20);
            this.combClassName.TabIndex = 0;
            this.combClassName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combClassName_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(349, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(652, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(753, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNameUp
            // 
            this.btnNameUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNameUp.Location = new System.Drawing.Point(450, 10);
            this.btnNameUp.Name = "btnNameUp";
            this.btnNameUp.Size = new System.Drawing.Size(75, 23);
            this.btnNameUp.TabIndex = 4;
            this.btnNameUp.Text = "姓名升序";
            this.btnNameUp.UseVisualStyleBackColor = true;
            this.btnNameUp.Click += new System.EventHandler(this.btnNameUp_Click);
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNumber,
            this.StudentName,
            this.StudentSex,
            this.StudentBrithday,
            this.IDnumber,
            this.StudentPhoneNumber,
            this.StudentNation,
            this.StudentNativeplace,
            this.StudentAddress,
            this.SpecialityName,
            this.ClassName,
            this.StudentCollage,
            this.StudentPolitical,
            this.StudentJob,
            this.Remark});
            this.dgvStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentList.Location = new System.Drawing.Point(3, 172);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            this.dgvStudentList.RowTemplate.Height = 23;
            this.dgvStudentList.Size = new System.Drawing.Size(848, 357);
            this.dgvStudentList.TabIndex = 2;
            // 
            // StudentNumber
            // 
            this.StudentNumber.DataPropertyName = "StudentNumber";
            this.StudentNumber.HeaderText = "学号";
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentSex
            // 
            this.StudentSex.DataPropertyName = "StudentSex";
            this.StudentSex.HeaderText = "性别";
            this.StudentSex.Name = "StudentSex";
            this.StudentSex.ReadOnly = true;
            // 
            // StudentBrithday
            // 
            this.StudentBrithday.DataPropertyName = "StudentBrithday";
            this.StudentBrithday.HeaderText = "出生日期";
            this.StudentBrithday.Name = "StudentBrithday";
            this.StudentBrithday.ReadOnly = true;
            // 
            // IDnumber
            // 
            this.IDnumber.DataPropertyName = "IDnumber";
            this.IDnumber.HeaderText = "身份证号";
            this.IDnumber.Name = "IDnumber";
            this.IDnumber.ReadOnly = true;
            // 
            // StudentPhoneNumber
            // 
            this.StudentPhoneNumber.DataPropertyName = "StudentPhoneNumber";
            this.StudentPhoneNumber.HeaderText = "联系电话";
            this.StudentPhoneNumber.Name = "StudentPhoneNumber";
            this.StudentPhoneNumber.ReadOnly = true;
            // 
            // StudentNation
            // 
            this.StudentNation.DataPropertyName = "StudentNation";
            this.StudentNation.HeaderText = "民族";
            this.StudentNation.Name = "StudentNation";
            this.StudentNation.ReadOnly = true;
            // 
            // StudentNativeplace
            // 
            this.StudentNativeplace.DataPropertyName = "StudentNativeplace";
            this.StudentNativeplace.HeaderText = "籍贯";
            this.StudentNativeplace.Name = "StudentNativeplace";
            this.StudentNativeplace.ReadOnly = true;
            // 
            // StudentAddress
            // 
            this.StudentAddress.DataPropertyName = "StudentAddress";
            this.StudentAddress.HeaderText = "家庭住址";
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.ReadOnly = true;
            // 
            // SpecialityName
            // 
            this.SpecialityName.DataPropertyName = "SpecialityName";
            this.SpecialityName.HeaderText = "专业";
            this.SpecialityName.Name = "SpecialityName";
            this.SpecialityName.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "所在班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // StudentCollage
            // 
            this.StudentCollage.DataPropertyName = "StudentCollage";
            this.StudentCollage.HeaderText = "所在学院";
            this.StudentCollage.Name = "StudentCollage";
            this.StudentCollage.ReadOnly = true;
            // 
            // StudentPolitical
            // 
            this.StudentPolitical.DataPropertyName = "StudentPolitical";
            this.StudentPolitical.HeaderText = "政治面貌";
            this.StudentPolitical.Name = "StudentPolitical";
            this.StudentPolitical.ReadOnly = true;
            // 
            // StudentJob
            // 
            this.StudentJob.DataPropertyName = "StudentJob";
            this.StudentJob.HeaderText = "身份";
            this.StudentJob.Name = "StudentJob";
            this.StudentJob.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // lblboss
            // 
            this.lblboss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblboss.AutoSize = true;
            this.lblboss.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblboss.Location = new System.Drawing.Point(337, 0);
            this.lblboss.Name = "lblboss";
            this.lblboss.Size = new System.Drawing.Size(180, 26);
            this.lblboss.TabIndex = 3;
            this.lblboss.Text = "浏览学生信息";
            // 
            // students_Information_SysDataSet
            // 
            this.students_Information_SysDataSet.DataSetName = "Students_Information_SysDataSet";
            this.students_Information_SysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsInformationSysDataSetBindingSource
            // 
            this.studentsInformationSysDataSetBindingSource.DataSource = this.students_Information_SysDataSet;
            this.studentsInformationSysDataSetBindingSource.Position = 0;
            // 
            // tbStudentInfoBindingSource
            // 
            this.tbStudentInfoBindingSource.DataMember = "tbStudentInfo";
            this.tbStudentInfoBindingSource.DataSource = this.studentsInformationSysDataSetBindingSource;
            // 
            // tbStudentInfoTableAdapter
            // 
            this.tbStudentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tbStudentInfoBindingSource1
            // 
            this.tbStudentInfoBindingSource1.DataMember = "tbStudentInfo";
            this.tbStudentInfoBindingSource1.DataSource = this.studentsInformationSysDataSetBindingSource;
            // 
            // FrmStudentBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FrmStudentBrowse";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "浏览学生信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_Information_SysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInformationSysDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Label lblStuNumber;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.ComboBox combClassName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNameDown;
        private System.Windows.Forms.Button lblStuNumberDown;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblboss;
        private System.Windows.Forms.BindingSource studentsInformationSysDataSetBindingSource;
        private Students_Information_SysDataSet students_Information_SysDataSet;
        private System.Windows.Forms.BindingSource tbStudentInfoBindingSource;
        private Students_Information_SysDataSetTableAdapters.tbStudentInfoTableAdapter tbStudentInfoTableAdapter;
        private System.Windows.Forms.BindingSource tbStudentInfoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentBrithday;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNativeplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCollage;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPolitical;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Button btnNameUp;
        private System.Windows.Forms.Button lblStuNumberUp;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Button btnPrintingClass;
    }
}
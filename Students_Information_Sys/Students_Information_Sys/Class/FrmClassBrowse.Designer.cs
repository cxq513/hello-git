namespace Students_Information_Sys
{
    partial class FrmClassBrowse
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.combCollageName = new System.Windows.Forms.ComboBox();
            this.lblCollage = new System.Windows.Forms.Label();
            this.lblSpecialityName = new System.Windows.Forms.Label();
            this.lblEnrolmentTime = new System.Windows.Forms.Label();
            this.combSpecialityName = new System.Windows.Forms.ComboBox();
            this.dateTimeEnrolmentTime = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchByTime = new System.Windows.Forms.Button();
            this.dgvGetClass = new System.Windows.Forms.DataGridView();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolReform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrolmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClassDelect = new System.Windows.Forms.Button();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetClass)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvGetClass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Controls.Add(this.combCollageName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCollage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSpecialityName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEnrolmentTime, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.combSpecialityName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimeEnrolmentTime, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearchByTime, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(962, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // combCollageName
            // 
            this.combCollageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combCollageName.FormattingEnabled = true;
            this.combCollageName.Location = new System.Drawing.Point(79, 16);
            this.combCollageName.Name = "combCollageName";
            this.combCollageName.Size = new System.Drawing.Size(186, 20);
            this.combCollageName.TabIndex = 0;
            // 
            // lblCollage
            // 
            this.lblCollage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCollage.AutoSize = true;
            this.lblCollage.Location = new System.Drawing.Point(8, 20);
            this.lblCollage.Name = "lblCollage";
            this.lblCollage.Size = new System.Drawing.Size(65, 12);
            this.lblCollage.TabIndex = 6;
            this.lblCollage.Text = "请选择学院";
            // 
            // lblSpecialityName
            // 
            this.lblSpecialityName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSpecialityName.AutoSize = true;
            this.lblSpecialityName.Location = new System.Drawing.Point(276, 20);
            this.lblSpecialityName.Name = "lblSpecialityName";
            this.lblSpecialityName.Size = new System.Drawing.Size(65, 12);
            this.lblSpecialityName.TabIndex = 0;
            this.lblSpecialityName.Text = "请选择专业";
            // 
            // lblEnrolmentTime
            // 
            this.lblEnrolmentTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEnrolmentTime.AutoSize = true;
            this.lblEnrolmentTime.Location = new System.Drawing.Point(632, 20);
            this.lblEnrolmentTime.Name = "lblEnrolmentTime";
            this.lblEnrolmentTime.Size = new System.Drawing.Size(53, 12);
            this.lblEnrolmentTime.TabIndex = 1;
            this.lblEnrolmentTime.Text = "入学年份";
            // 
            // combSpecialityName
            // 
            this.combSpecialityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combSpecialityName.FormattingEnabled = true;
            this.combSpecialityName.Location = new System.Drawing.Point(347, 16);
            this.combSpecialityName.Name = "combSpecialityName";
            this.combSpecialityName.Size = new System.Drawing.Size(186, 20);
            this.combSpecialityName.TabIndex = 1;
            // 
            // dateTimeEnrolmentTime
            // 
            this.dateTimeEnrolmentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeEnrolmentTime.Checked = false;
            this.dateTimeEnrolmentTime.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEnrolmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnrolmentTime.Location = new System.Drawing.Point(691, 15);
            this.dateTimeEnrolmentTime.Name = "dateTimeEnrolmentTime";
            this.dateTimeEnrolmentTime.Size = new System.Drawing.Size(186, 21);
            this.dateTimeEnrolmentTime.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(539, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "按专业查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnSearchByTime
            // 
            this.btnSearchByTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchByTime.Location = new System.Drawing.Point(883, 14);
            this.btnSearchByTime.Name = "btnSearchByTime";
            this.btnSearchByTime.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByTime.TabIndex = 4;
            this.btnSearchByTime.Text = "按时间查询";
            this.btnSearchByTime.UseVisualStyleBackColor = true;
            this.btnSearchByTime.Click += new System.EventHandler(this.btnSearchByTime_Click);
            // 
            // dgvGetClass
            // 
            this.dgvGetClass.AllowUserToAddRows = false;
            this.dgvGetClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.ClassName,
            this.SpecialityName,
            this.ClassNum,
            this.SchoolReform,
            this.HeadTeacher,
            this.EnrolmentTime,
            this.Remark});
            this.dgvGetClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGetClass.Location = new System.Drawing.Point(3, 61);
            this.dgvGetClass.Name = "dgvGetClass";
            this.dgvGetClass.RowTemplate.Height = 23;
            this.dgvGetClass.Size = new System.Drawing.Size(962, 288);
            this.dgvGetClass.TabIndex = 1;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "班级编号";
            this.ClassID.Name = "ClassID";
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级名称";
            this.ClassName.Name = "ClassName";
            // 
            // SpecialityName
            // 
            this.SpecialityName.DataPropertyName = "SpecialityName";
            this.SpecialityName.HeaderText = "专业名称";
            this.SpecialityName.Name = "SpecialityName";
            // 
            // ClassNum
            // 
            this.ClassNum.DataPropertyName = "ClassNum";
            this.ClassNum.HeaderText = "教室编号";
            this.ClassNum.Name = "ClassNum";
            // 
            // SchoolReform
            // 
            this.SchoolReform.DataPropertyName = "SchoolReform";
            this.SchoolReform.HeaderText = "学制";
            this.SchoolReform.Name = "SchoolReform";
            // 
            // HeadTeacher
            // 
            this.HeadTeacher.DataPropertyName = "HeadTeacher";
            this.HeadTeacher.HeaderText = "班主任";
            this.HeadTeacher.Name = "HeadTeacher";
            // 
            // EnrolmentTime
            // 
            this.EnrolmentTime.DataPropertyName = "EnrolmentTime";
            this.EnrolmentTime.HeaderText = "入学时间";
            this.EnrolmentTime.Name = "EnrolmentTime";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClassDelect, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClassUpdate, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 355);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(962, 35);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(755, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取    消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClassDelect
            // 
            this.btnClassDelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClassDelect.Location = new System.Drawing.Point(434, 6);
            this.btnClassDelect.Name = "btnClassDelect";
            this.btnClassDelect.Size = new System.Drawing.Size(92, 23);
            this.btnClassDelect.TabIndex = 6;
            this.btnClassDelect.Text = "删除班级信息";
            this.btnClassDelect.UseVisualStyleBackColor = true;
            this.btnClassDelect.Click += new System.EventHandler(this.btnClassDelect_Click);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClassUpdate.Location = new System.Drawing.Point(114, 6);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnClassUpdate.TabIndex = 5;
            this.btnClassUpdate.Text = "修改班级信息";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // FrmClassBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 428);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmClassBrowse";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.Text = "浏览班级信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetClass)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSpecialityName;
        private System.Windows.Forms.Label lblEnrolmentTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox combSpecialityName;
        private System.Windows.Forms.DateTimePicker dateTimeEnrolmentTime;
        private System.Windows.Forms.DataGridView dgvGetClass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClassDelect;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolReform;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrolmentTime;
        private System.Windows.Forms.DataGridViewButtonColumn Remark;
        private System.Windows.Forms.Button btnSearchByTime;
        private System.Windows.Forms.ComboBox combCollageName;
        private System.Windows.Forms.Label lblCollage;
    }
}
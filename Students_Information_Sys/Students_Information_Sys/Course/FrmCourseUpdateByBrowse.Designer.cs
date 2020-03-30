namespace Students_Information_Sys
{
    partial class FrmCourseUpdateByBrowse
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
            this.cc = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.combClassName = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblEnrolmentTime = new System.Windows.Forms.Label();
            this.dtpEnrolmentTime = new System.Windows.Forms.DateTimePicker();
            this.lblSemester = new System.Windows.Forms.Label();
            this.combSemester = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.combCourseName = new System.Windows.Forms.ComboBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.lblTeacherPhoneNumber = new System.Windows.Forms.Label();
            this.txtTeacherPhoneNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblbstring = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.cc.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblbstring, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(516, 262);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(516, 262);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 262);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cc
            // 
            this.cc.Controls.Add(this.tableLayoutPanel2);
            this.cc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cc.Location = new System.Drawing.Point(3, 42);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(510, 177);
            this.cc.TabIndex = 0;
            this.cc.TabStop = false;
            this.cc.Text = "课程信息";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.combClassName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblClass, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEnrolmentTime, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpEnrolmentTime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSemester, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.combSemester, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCourseName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.combCourseName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTeacher, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTeacher, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTeacherPhoneNumber, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTeacherPhoneNumber, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(504, 160);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // combClassName
            // 
            this.combClassName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combClassName.Enabled = false;
            this.combClassName.FormattingEnabled = true;
            this.combClassName.Location = new System.Drawing.Point(78, 16);
            this.combClassName.Name = "combClassName";
            this.combClassName.Size = new System.Drawing.Size(170, 20);
            this.combClassName.TabIndex = 0;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(19, 20);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(53, 12);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "班    级";
            // 
            // lblEnrolmentTime
            // 
            this.lblEnrolmentTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEnrolmentTime.AutoSize = true;
            this.lblEnrolmentTime.Location = new System.Drawing.Point(19, 73);
            this.lblEnrolmentTime.Name = "lblEnrolmentTime";
            this.lblEnrolmentTime.Size = new System.Drawing.Size(53, 12);
            this.lblEnrolmentTime.TabIndex = 1;
            this.lblEnrolmentTime.Text = "入学时间";
            // 
            // dtpEnrolmentTime
            // 
            this.dtpEnrolmentTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEnrolmentTime.Enabled = false;
            this.dtpEnrolmentTime.Location = new System.Drawing.Point(78, 69);
            this.dtpEnrolmentTime.Name = "dtpEnrolmentTime";
            this.dtpEnrolmentTime.Size = new System.Drawing.Size(170, 21);
            this.dtpEnrolmentTime.TabIndex = 1;
            // 
            // lblSemester
            // 
            this.lblSemester.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(19, 127);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(53, 12);
            this.lblSemester.TabIndex = 4;
            this.lblSemester.Text = "学    期";
            // 
            // combSemester
            // 
            this.combSemester.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combSemester.Enabled = false;
            this.combSemester.FormattingEnabled = true;
            this.combSemester.Location = new System.Drawing.Point(78, 123);
            this.combSemester.Name = "combSemester";
            this.combSemester.Size = new System.Drawing.Size(170, 20);
            this.combSemester.TabIndex = 2;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(270, 20);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(53, 12);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "课程名称";
            // 
            // combCourseName
            // 
            this.combCourseName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combCourseName.Enabled = false;
            this.combCourseName.FormattingEnabled = true;
            this.combCourseName.Location = new System.Drawing.Point(329, 16);
            this.combCourseName.Name = "combCourseName";
            this.combCourseName.Size = new System.Drawing.Size(172, 20);
            this.combCourseName.TabIndex = 3;
            // 
            // lblTeacher
            // 
            this.lblTeacher.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(270, 73);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(53, 12);
            this.lblTeacher.TabIndex = 14;
            this.lblTeacher.Text = "任课老师";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTeacher.Location = new System.Drawing.Point(329, 69);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(172, 21);
            this.txtTeacher.TabIndex = 4;
            // 
            // lblTeacherPhoneNumber
            // 
            this.lblTeacherPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTeacherPhoneNumber.AutoSize = true;
            this.lblTeacherPhoneNumber.Location = new System.Drawing.Point(270, 127);
            this.lblTeacherPhoneNumber.Name = "lblTeacherPhoneNumber";
            this.lblTeacherPhoneNumber.Size = new System.Drawing.Size(53, 12);
            this.lblTeacherPhoneNumber.TabIndex = 13;
            this.lblTeacherPhoneNumber.Text = "联系方式";
            // 
            // txtTeacherPhoneNumber
            // 
            this.txtTeacherPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTeacherPhoneNumber.Location = new System.Drawing.Point(329, 122);
            this.txtTeacherPhoneNumber.Name = "txtTeacherPhoneNumber";
            this.txtTeacherPhoneNumber.Size = new System.Drawing.Size(172, 21);
            this.txtTeacherPhoneNumber.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(510, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(90, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 22);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(345, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblbstring
            // 
            this.lblbstring.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblbstring.AutoSize = true;
            this.lblbstring.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblbstring.Location = new System.Drawing.Point(168, 6);
            this.lblbstring.Name = "lblbstring";
            this.lblbstring.Size = new System.Drawing.Size(180, 27);
            this.lblbstring.TabIndex = 2;
            this.lblbstring.Text = "修改课程信息";
            // 
            // FrmCourseUpdateByBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 282);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimumSize = new System.Drawing.Size(552, 320);
            this.Name = "FrmCourseUpdateByBrowse";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改班级信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.cc.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox cc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox combClassName;
        private System.Windows.Forms.Label lblTeacherPhoneNumber;
        private System.Windows.Forms.TextBox txtTeacherPhoneNumber;
        private System.Windows.Forms.Label lblEnrolmentTime;
        private System.Windows.Forms.DateTimePicker dtpEnrolmentTime;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox combSemester;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox combCourseName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblbstring;
    }
}
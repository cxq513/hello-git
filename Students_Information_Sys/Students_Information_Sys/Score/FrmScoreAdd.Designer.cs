namespace Students_Information_Sys
{
    partial class FrmScoreAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreAdd));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpbChosseClassAndTerm = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblterm = new System.Windows.Forms.Label();
            this.combSemester = new System.Windows.Forms.ComboBox();
            this.lblbclasses = new System.Windows.Forms.Label();
            this.combClassName = new System.Windows.Forms.ComboBox();
            this.lblmajor = new System.Windows.Forms.Label();
            this.combSpecialityName = new System.Windows.Forms.ComboBox();
            this.lblCollage = new System.Windows.Forms.Label();
            this.combCollageName = new System.Windows.Forms.ComboBox();
            this.gpbCourse = new System.Windows.Forms.GroupBox();
            this.lvCourseName = new System.Windows.Forms.ListView();
            this.gpbStudentsList = new System.Windows.Forms.GroupBox();
            this.lvStudentName = new System.Windows.Forms.ListView();
            this.gpbGrades = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblstudent = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblgrade = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.lblclass = new System.Windows.Forms.Label();
            this.lblterm2 = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.gpbChosseClassAndTerm.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gpbCourse.SuspendLayout();
            this.gpbStudentsList.SuspendLayout();
            this.gpbGrades.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.gpbChosseClassAndTerm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpbCourse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpbStudentsList, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpbGrades, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 362);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gpbChosseClassAndTerm
            // 
            this.gpbChosseClassAndTerm.Controls.Add(this.tableLayoutPanel4);
            this.gpbChosseClassAndTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbChosseClassAndTerm.Location = new System.Drawing.Point(3, 3);
            this.gpbChosseClassAndTerm.Name = "gpbChosseClassAndTerm";
            this.gpbChosseClassAndTerm.Size = new System.Drawing.Size(255, 175);
            this.gpbChosseClassAndTerm.TabIndex = 0;
            this.gpbChosseClassAndTerm.TabStop = false;
            this.gpbChosseClassAndTerm.Text = "选择班级学期";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.49799F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.50201F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblterm, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.combSemester, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblbclasses, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.combClassName, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblmajor, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.combSpecialityName, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblCollage, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.combCollageName, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(249, 155);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // lblterm
            // 
            this.lblterm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblterm.AutoSize = true;
            this.lblterm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblterm.Location = new System.Drawing.Point(26, 115);
            this.lblterm.Name = "lblterm";
            this.lblterm.Size = new System.Drawing.Size(31, 12);
            this.lblterm.TabIndex = 2;
            this.lblterm.Text = "学期";
            // 
            // combSemester
            // 
            this.combSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combSemester.FormattingEnabled = true;
            this.combSemester.Location = new System.Drawing.Point(79, 111);
            this.combSemester.Name = "combSemester";
            this.combSemester.Size = new System.Drawing.Size(151, 20);
            this.combSemester.TabIndex = 3;
            this.combSemester.SelectedIndexChanged += new System.EventHandler(this.combSemester_SelectedIndexChanged);
            // 
            // lblbclasses
            // 
            this.lblbclasses.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblbclasses.AutoSize = true;
            this.lblbclasses.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblbclasses.Location = new System.Drawing.Point(26, 88);
            this.lblbclasses.Name = "lblbclasses";
            this.lblbclasses.Size = new System.Drawing.Size(31, 12);
            this.lblbclasses.TabIndex = 1;
            this.lblbclasses.Text = "班级";
            // 
            // combClassName
            // 
            this.combClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combClassName.Location = new System.Drawing.Point(79, 84);
            this.combClassName.Name = "combClassName";
            this.combClassName.Size = new System.Drawing.Size(151, 20);
            this.combClassName.TabIndex = 2;
            // 
            // lblmajor
            // 
            this.lblmajor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblmajor.AutoSize = true;
            this.lblmajor.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmajor.Location = new System.Drawing.Point(26, 61);
            this.lblmajor.Name = "lblmajor";
            this.lblmajor.Size = new System.Drawing.Size(31, 12);
            this.lblmajor.TabIndex = 0;
            this.lblmajor.Text = "专业";
            // 
            // combSpecialityName
            // 
            this.combSpecialityName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combSpecialityName.FormattingEnabled = true;
            this.combSpecialityName.Location = new System.Drawing.Point(79, 57);
            this.combSpecialityName.Name = "combSpecialityName";
            this.combSpecialityName.Size = new System.Drawing.Size(151, 20);
            this.combSpecialityName.TabIndex = 1;
            // 
            // lblCollage
            // 
            this.lblCollage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCollage.AutoSize = true;
            this.lblCollage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCollage.Location = new System.Drawing.Point(26, 34);
            this.lblCollage.Name = "lblCollage";
            this.lblCollage.Size = new System.Drawing.Size(31, 12);
            this.lblCollage.TabIndex = 6;
            this.lblCollage.Text = "学院";
            // 
            // combCollageName
            // 
            this.combCollageName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combCollageName.FormattingEnabled = true;
            this.combCollageName.Location = new System.Drawing.Point(79, 30);
            this.combCollageName.Name = "combCollageName";
            this.combCollageName.Size = new System.Drawing.Size(151, 20);
            this.combCollageName.TabIndex = 0;
            // 
            // gpbCourse
            // 
            this.gpbCourse.Controls.Add(this.lvCourseName);
            this.gpbCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbCourse.Location = new System.Drawing.Point(264, 3);
            this.gpbCourse.Name = "gpbCourse";
            this.gpbCourse.Size = new System.Drawing.Size(255, 175);
            this.gpbCourse.TabIndex = 2;
            this.gpbCourse.TabStop = false;
            this.gpbCourse.Text = "课程";
            // 
            // lvCourseName
            // 
            this.lvCourseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCourseName.Location = new System.Drawing.Point(3, 17);
            this.lvCourseName.Name = "lvCourseName";
            this.lvCourseName.Size = new System.Drawing.Size(249, 155);
            this.lvCourseName.TabIndex = 0;
            this.lvCourseName.UseCompatibleStateImageBehavior = false;
            this.lvCourseName.SelectedIndexChanged += new System.EventHandler(this.lvCourseName_SelectedIndexChanged);
            // 
            // gpbStudentsList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gpbStudentsList, 2);
            this.gpbStudentsList.Controls.Add(this.lvStudentName);
            this.gpbStudentsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbStudentsList.Location = new System.Drawing.Point(3, 184);
            this.gpbStudentsList.Name = "gpbStudentsList";
            this.gpbStudentsList.Size = new System.Drawing.Size(516, 175);
            this.gpbStudentsList.TabIndex = 3;
            this.gpbStudentsList.TabStop = false;
            this.gpbStudentsList.Text = "学生名单";
            // 
            // lvStudentName
            // 
            this.lvStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStudentName.Location = new System.Drawing.Point(3, 17);
            this.lvStudentName.Name = "lvStudentName";
            this.lvStudentName.Size = new System.Drawing.Size(510, 155);
            this.lvStudentName.TabIndex = 0;
            this.lvStudentName.UseCompatibleStateImageBehavior = false;
            this.lvStudentName.SelectedIndexChanged += new System.EventHandler(this.lvStudentName_SelectedIndexChanged);
            this.lvStudentName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvStudentName_MouseUp);
            // 
            // gpbGrades
            // 
            this.gpbGrades.Controls.Add(this.tableLayoutPanel2);
            this.gpbGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbGrades.Location = new System.Drawing.Point(525, 3);
            this.gpbGrades.Name = "gpbGrades";
            this.tableLayoutPanel1.SetRowSpan(this.gpbGrades, 2);
            this.gpbGrades.Size = new System.Drawing.Size(256, 356);
            this.gpbGrades.TabIndex = 1;
            this.gpbGrades.TabStop = false;
            this.gpbGrades.Text = "成绩";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.2F));
            this.tableLayoutPanel2.Controls.Add(this.lblstudent, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtScore, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblgrade, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblclass, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblterm2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSemester, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStudentName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCourseName, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 336);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // lblstudent
            // 
            this.lblstudent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblstudent.Location = new System.Drawing.Point(42, 111);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(31, 12);
            this.lblstudent.TabIndex = 1;
            this.lblstudent.Text = "学生";
            // 
            // txtScore
            // 
            this.txtScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtScore.Location = new System.Drawing.Point(89, 201);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(147, 21);
            this.txtScore.TabIndex = 7;
            this.txtScore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScore_KeyDown);
            // 
            // lblgrade
            // 
            this.lblgrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblgrade.Location = new System.Drawing.Point(42, 205);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(31, 12);
            this.lblgrade.TabIndex = 3;
            this.lblgrade.Text = "成绩";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnexit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnok, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 238);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(244, 41);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnexit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(145, 9);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "退    出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnok
            // 
            this.btnok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnok.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnok.Location = new System.Drawing.Point(23, 9);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 8;
            this.btnok.Text = "录入成绩";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblclass
            // 
            this.lblclass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblclass.AutoSize = true;
            this.lblclass.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblclass.Location = new System.Drawing.Point(42, 158);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(31, 12);
            this.lblclass.TabIndex = 0;
            this.lblclass.Text = "课程";
            // 
            // lblterm2
            // 
            this.lblterm2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblterm2.AutoSize = true;
            this.lblterm2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblterm2.Location = new System.Drawing.Point(42, 64);
            this.lblterm2.Name = "lblterm2";
            this.lblterm2.Size = new System.Drawing.Size(31, 12);
            this.lblterm2.TabIndex = 2;
            this.lblterm2.Text = "学期";
            // 
            // txtSemester
            // 
            this.txtSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSemester.Location = new System.Drawing.Point(89, 60);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(147, 21);
            this.txtSemester.TabIndex = 4;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentName.Location = new System.Drawing.Point(89, 107);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(147, 21);
            this.txtStudentName.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourseName.Location = new System.Drawing.Point(89, 154);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(147, 21);
            this.txtCourseName.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NoPicture.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "打开.png");
            // 
            // FrmScoreAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FrmScoreAdd";
            this.Text = "添加学生成绩";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gpbChosseClassAndTerm.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.gpbCourse.ResumeLayout(false);
            this.gpbStudentsList.ResumeLayout(false);
            this.gpbGrades.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gpbChosseClassAndTerm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox combClassName;
        private System.Windows.Forms.ComboBox combSemester;
        private System.Windows.Forms.Label lblmajor;
        private System.Windows.Forms.Label lblterm;
        private System.Windows.Forms.ComboBox combSpecialityName;
        private System.Windows.Forms.Label lblbclasses;
        private System.Windows.Forms.GroupBox gpbCourse;
        private System.Windows.Forms.ListView lvCourseName;
        private System.Windows.Forms.GroupBox gpbStudentsList;
        private System.Windows.Forms.ListView lvStudentName;
        private System.Windows.Forms.GroupBox gpbGrades;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblterm2;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblCollage;
        private System.Windows.Forms.ComboBox combCollageName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}
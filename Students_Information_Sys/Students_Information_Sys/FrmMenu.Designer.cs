namespace Students_Information_Sys
{
    partial class FrmMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblPwdUpdate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSorceSearch = new System.Windows.Forms.Label();
            this.lblCourseSearch = new System.Windows.Forms.Label();
            this.lblStudentSerach = new System.Windows.Forms.Label();
            this.lblClassSerach = new System.Windows.Forms.Label();
            this.lblSpecialityBrowse = new System.Windows.Forms.Label();
            this.lblCollageBrowse = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 559);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.lblExit, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPwdUpdate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblUser, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSorceSearch, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCourseSearch, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStudentSerach, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblClassSerach, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSpecialityBrowse, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCollageBrowse, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 253);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Image = global::Students_Information_Sys.Properties.Resources.power_exit_31_466666666667px_1122609_easyicon_net;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblExit.Location = new System.Drawing.Point(190, 183);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(60, 55);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "退出系统";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblPwdUpdate
            // 
            this.lblPwdUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPwdUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPwdUpdate.Image = global::Students_Information_Sys.Properties.Resources.man_key;
            this.lblPwdUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPwdUpdate.Location = new System.Drawing.Point(102, 183);
            this.lblPwdUpdate.Name = "lblPwdUpdate";
            this.lblPwdUpdate.Size = new System.Drawing.Size(60, 55);
            this.lblPwdUpdate.TabIndex = 7;
            this.lblPwdUpdate.Text = "更改密码";
            this.lblPwdUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPwdUpdate.Click += new System.EventHandler(this.lblPwdUpdate_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.Image = global::Students_Information_Sys.Properties.Resources.User;
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUser.Location = new System.Drawing.Point(14, 183);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 55);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "用户管理";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblSorceSearch
            // 
            this.lblSorceSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSorceSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSorceSearch.Image = global::Students_Information_Sys.Properties.Resources.Application;
            this.lblSorceSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSorceSearch.Location = new System.Drawing.Point(190, 98);
            this.lblSorceSearch.Name = "lblSorceSearch";
            this.lblSorceSearch.Size = new System.Drawing.Size(60, 55);
            this.lblSorceSearch.TabIndex = 5;
            this.lblSorceSearch.Text = "成绩查询";
            this.lblSorceSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSorceSearch.Click += new System.EventHandler(this.lblSorceSearch_Click);
            // 
            // lblCourseSearch
            // 
            this.lblCourseSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCourseSearch.Image = global::Students_Information_Sys.Properties.Resources.moleskine_Umband;
            this.lblCourseSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCourseSearch.Location = new System.Drawing.Point(102, 98);
            this.lblCourseSearch.Name = "lblCourseSearch";
            this.lblCourseSearch.Size = new System.Drawing.Size(60, 55);
            this.lblCourseSearch.TabIndex = 4;
            this.lblCourseSearch.Text = "课程查询";
            this.lblCourseSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCourseSearch.Click += new System.EventHandler(this.lblCourseSearch_Click);
            // 
            // lblStudentSerach
            // 
            this.lblStudentSerach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentSerach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStudentSerach.Image = global::Students_Information_Sys.Properties.Resources.card;
            this.lblStudentSerach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStudentSerach.Location = new System.Drawing.Point(14, 98);
            this.lblStudentSerach.Name = "lblStudentSerach";
            this.lblStudentSerach.Size = new System.Drawing.Size(60, 55);
            this.lblStudentSerach.TabIndex = 3;
            this.lblStudentSerach.Text = "学生查询";
            this.lblStudentSerach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblStudentSerach.Click += new System.EventHandler(this.lblStudentSerach_Click);
            // 
            // lblClassSerach
            // 
            this.lblClassSerach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassSerach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClassSerach.Image = global::Students_Information_Sys.Properties.Resources.Blackboard;
            this.lblClassSerach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClassSerach.Location = new System.Drawing.Point(190, 14);
            this.lblClassSerach.Name = "lblClassSerach";
            this.lblClassSerach.Size = new System.Drawing.Size(60, 55);
            this.lblClassSerach.TabIndex = 2;
            this.lblClassSerach.Text = "班级查询";
            this.lblClassSerach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblClassSerach.Click += new System.EventHandler(this.lblClassSerach_Click);
            // 
            // lblSpecialityBrowse
            // 
            this.lblSpecialityBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpecialityBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSpecialityBrowse.Image = global::Students_Information_Sys.Properties.Resources.Test_tubes;
            this.lblSpecialityBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSpecialityBrowse.Location = new System.Drawing.Point(102, 14);
            this.lblSpecialityBrowse.Name = "lblSpecialityBrowse";
            this.lblSpecialityBrowse.Size = new System.Drawing.Size(60, 55);
            this.lblSpecialityBrowse.TabIndex = 1;
            this.lblSpecialityBrowse.Text = "专业浏览";
            this.lblSpecialityBrowse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSpecialityBrowse.Click += new System.EventHandler(this.lblSpecialityBrowse_Click);
            // 
            // lblCollageBrowse
            // 
            this.lblCollageBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCollageBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCollageBrowse.Image = global::Students_Information_Sys.Properties.Resources.School;
            this.lblCollageBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCollageBrowse.Location = new System.Drawing.Point(14, 14);
            this.lblCollageBrowse.Name = "lblCollageBrowse";
            this.lblCollageBrowse.Size = new System.Drawing.Size(60, 55);
            this.lblCollageBrowse.TabIndex = 0;
            this.lblCollageBrowse.Text = "学院浏览";
            this.lblCollageBrowse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCollageBrowse.Click += new System.EventHandler(this.lblCollageBrowse_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmMenu";
            this.Text = "菜单";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblPwdUpdate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSorceSearch;
        private System.Windows.Forms.Label lblCourseSearch;
        private System.Windows.Forms.Label lblStudentSerach;
        private System.Windows.Forms.Label lblClassSerach;
        private System.Windows.Forms.Label lblSpecialityBrowse;
        private System.Windows.Forms.Label lblCollageBrowse;
    }
}
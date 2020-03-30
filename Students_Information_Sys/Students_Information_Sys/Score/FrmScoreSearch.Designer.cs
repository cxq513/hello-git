namespace Students_Information_Sys
{
    partial class FrmScoreSearch
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
            this.gpbInformation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblmajor = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.combSpecialityName = new System.Windows.Forms.ComboBox();
            this.lblterms = new System.Windows.Forms.Label();
            this.combClassName = new System.Windows.Forms.ComboBox();
            this.lblyears = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblclasses = new System.Windows.Forms.Label();
            this.gpbStudensList = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gpbgrades = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.自动编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnScoerSearch = new System.Windows.Forms.Button();
            this.btnScorePrinting = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gpbInformation.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gpbStudensList.SuspendLayout();
            this.gpbgrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gpbInformation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpbStudensList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gpbgrades, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.86188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.13812F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 362);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gpbInformation
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gpbInformation, 2);
            this.gpbInformation.Controls.Add(this.tableLayoutPanel3);
            this.gpbInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbInformation.Location = new System.Drawing.Point(3, 3);
            this.gpbInformation.Name = "gpbInformation";
            this.gpbInformation.Size = new System.Drawing.Size(878, 71);
            this.gpbInformation.TabIndex = 0;
            this.gpbInformation.TabStop = false;
            this.gpbInformation.Text = "基本信息";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.06881F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.224771F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54587F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblmajor, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox4, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.combSpecialityName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblterms, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.combClassName, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblyears, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblclasses, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(872, 51);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // lblmajor
            // 
            this.lblmajor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblmajor.AutoSize = true;
            this.lblmajor.Location = new System.Drawing.Point(11, 19);
            this.lblmajor.Name = "lblmajor";
            this.lblmajor.Size = new System.Drawing.Size(29, 12);
            this.lblmajor.TabIndex = 0;
            this.lblmajor.Text = "专业";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(697, 15);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(148, 20);
            this.comboBox4.TabIndex = 3;
            // 
            // combSpecialityName
            // 
            this.combSpecialityName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combSpecialityName.FormattingEnabled = true;
            this.combSpecialityName.Location = new System.Drawing.Point(46, 15);
            this.combSpecialityName.Name = "combSpecialityName";
            this.combSpecialityName.Size = new System.Drawing.Size(169, 20);
            this.combSpecialityName.TabIndex = 0;
            // 
            // lblterms
            // 
            this.lblterms.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblterms.AutoSize = true;
            this.lblterms.Location = new System.Drawing.Point(662, 19);
            this.lblterms.Name = "lblterms";
            this.lblterms.Size = new System.Drawing.Size(29, 12);
            this.lblterms.TabIndex = 3;
            this.lblterms.Text = "学期";
            // 
            // combClassName
            // 
            this.combClassName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combClassName.FormattingEnabled = true;
            this.combClassName.Location = new System.Drawing.Point(480, 15);
            this.combClassName.Name = "combClassName";
            this.combClassName.Size = new System.Drawing.Size(148, 20);
            this.combClassName.TabIndex = 2;
            // 
            // lblyears
            // 
            this.lblyears.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblyears.AutoSize = true;
            this.lblyears.Location = new System.Drawing.Point(225, 19);
            this.lblyears.Name = "lblyears";
            this.lblyears.Size = new System.Drawing.Size(53, 12);
            this.lblyears.TabIndex = 1;
            this.lblyears.Text = "入学年份";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // lblclasses
            // 
            this.lblclasses.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblclasses.AutoSize = true;
            this.lblclasses.Location = new System.Drawing.Point(445, 19);
            this.lblclasses.Name = "lblclasses";
            this.lblclasses.Size = new System.Drawing.Size(29, 12);
            this.lblclasses.TabIndex = 2;
            this.lblclasses.Text = "班级";
            // 
            // gpbStudensList
            // 
            this.gpbStudensList.Controls.Add(this.listView1);
            this.gpbStudensList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbStudensList.Location = new System.Drawing.Point(3, 80);
            this.gpbStudensList.Name = "gpbStudensList";
            this.tableLayoutPanel1.SetRowSpan(this.gpbStudensList, 2);
            this.gpbStudensList.Size = new System.Drawing.Size(436, 279);
            this.gpbStudensList.TabIndex = 1;
            this.gpbStudensList.TabStop = false;
            this.gpbStudensList.Text = "学生名单";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 259);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gpbgrades
            // 
            this.gpbgrades.Controls.Add(this.dataGridView1);
            this.gpbgrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbgrades.Location = new System.Drawing.Point(445, 80);
            this.gpbgrades.Name = "gpbgrades";
            this.gpbgrades.Size = new System.Drawing.Size(436, 227);
            this.gpbgrades.TabIndex = 2;
            this.gpbgrades.TabStop = false;
            this.gpbgrades.Text = "成绩清单";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.自动编号,
            this.课程,
            this.分数});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(430, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // 自动编号
            // 
            this.自动编号.HeaderText = "自动编号";
            this.自动编号.Name = "自动编号";
            // 
            // 课程
            // 
            this.课程.HeaderText = "课程";
            this.课程.Name = "课程";
            // 
            // 分数
            // 
            this.分数.HeaderText = "分数";
            this.分数.Name = "分数";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnScoerSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnScorePrinting, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnexit, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(445, 313);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 46);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnScoerSearch
            // 
            this.btnScoerSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScoerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScoerSearch.Location = new System.Drawing.Point(35, 11);
            this.btnScoerSearch.Name = "btnScoerSearch";
            this.btnScoerSearch.Size = new System.Drawing.Size(75, 23);
            this.btnScoerSearch.TabIndex = 0;
            this.btnScoerSearch.Text = "查询成绩";
            this.btnScoerSearch.UseVisualStyleBackColor = true;
            // 
            // btnScorePrinting
            // 
            this.btnScorePrinting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScorePrinting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScorePrinting.Location = new System.Drawing.Point(180, 11);
            this.btnScorePrinting.Name = "btnScorePrinting";
            this.btnScorePrinting.Size = new System.Drawing.Size(75, 23);
            this.btnScorePrinting.TabIndex = 1;
            this.btnScorePrinting.Text = "打印成绩";
            this.btnScorePrinting.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Location = new System.Drawing.Point(325, 11);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "退    出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // FrmScoreSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "FrmScoreSearch";
            this.Text = "查询成绩信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gpbInformation.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gpbStudensList.ResumeLayout(false);
            this.gpbgrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gpbInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblmajor;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox combSpecialityName;
        private System.Windows.Forms.Label lblterms;
        private System.Windows.Forms.ComboBox combClassName;
        private System.Windows.Forms.Label lblyears;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblclasses;
        private System.Windows.Forms.GroupBox gpbStudensList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gpbgrades;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 自动编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分数;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnScoerSearch;
        private System.Windows.Forms.Button btnScorePrinting;
        private System.Windows.Forms.Button btnexit;
    }
}
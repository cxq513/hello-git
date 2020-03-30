namespace Students_Information_Sys
{
    partial class FrmCollageBrowse
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
            this.dgvCollage = new System.Windows.Forms.DataGridView();
            this.CollageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改学院信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCollageInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_Information_SysDataSet1 = new Students_Information_Sys.Students_Information_SysDataSet1();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSpecialityUpdate = new System.Windows.Forms.Button();
            this.btnCollageDelect = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.tbCollageInfoTableAdapter = new Students_Information_Sys.Students_Information_SysDataSet1TableAdapters.tbCollageInfoTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCollageInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_Information_SysDataSet1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(644, 422);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.33649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.66351F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 422);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCollage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所有学院信息";
            // 
            // dgvCollage
            // 
            this.dgvCollage.AllowUserToAddRows = false;
            this.dgvCollage.AutoGenerateColumns = false;
            this.dgvCollage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCollage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollageID,
            this.CollageName,
            this.Remark});
            this.dgvCollage.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCollage.DataSource = this.tbCollageInfoBindingSource;
            this.dgvCollage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCollage.Location = new System.Drawing.Point(3, 17);
            this.dgvCollage.Name = "dgvCollage";
            this.dgvCollage.RowTemplate.Height = 23;
            this.dgvCollage.Size = new System.Drawing.Size(622, 342);
            this.dgvCollage.TabIndex = 0;
            // 
            // CollageID
            // 
            this.CollageID.DataPropertyName = "CollageID";
            this.CollageID.HeaderText = "编号";
            this.CollageID.Name = "CollageID";
            this.CollageID.ReadOnly = true;
            // 
            // CollageName
            // 
            this.CollageName.DataPropertyName = "CollageName";
            this.CollageName.HeaderText = "学院名称";
            this.CollageName.Name = "CollageName";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "学院描述";
            this.Remark.Name = "Remark";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改学院信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // 修改学院信息ToolStripMenuItem
            // 
            this.修改学院信息ToolStripMenuItem.Name = "修改学院信息ToolStripMenuItem";
            this.修改学院信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改学院信息ToolStripMenuItem.Text = "修改学院信息";
            // 
            // tbCollageInfoBindingSource
            // 
            this.tbCollageInfoBindingSource.DataMember = "tbCollageInfo";
            this.tbCollageInfoBindingSource.DataSource = this.students_Information_SysDataSet1;
            // 
            // students_Information_SysDataSet1
            // 
            this.students_Information_SysDataSet1.DataSetName = "Students_Information_SysDataSet1";
            this.students_Information_SysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSpecialityUpdate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCollageDelect, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Quit, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 376);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(628, 38);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSpecialityUpdate
            // 
            this.btnSpecialityUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpecialityUpdate.Location = new System.Drawing.Point(67, 7);
            this.btnSpecialityUpdate.Name = "btnSpecialityUpdate";
            this.btnSpecialityUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSpecialityUpdate.TabIndex = 0;
            this.btnSpecialityUpdate.Text = "修改";
            this.btnSpecialityUpdate.UseVisualStyleBackColor = true;
            this.btnSpecialityUpdate.Click += new System.EventHandler(this.btnSpecialityUpdate_Click);
            // 
            // btnCollageDelect
            // 
            this.btnCollageDelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCollageDelect.Location = new System.Drawing.Point(276, 7);
            this.btnCollageDelect.Name = "btnCollageDelect";
            this.btnCollageDelect.Size = new System.Drawing.Size(75, 23);
            this.btnCollageDelect.TabIndex = 1;
            this.btnCollageDelect.Text = "删除";
            this.btnCollageDelect.UseVisualStyleBackColor = true;
            this.btnCollageDelect.Click += new System.EventHandler(this.btnCollageDelect_Click);
            // 
            // Quit
            // 
            this.Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quit.Location = new System.Drawing.Point(485, 7);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "退出";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // tbCollageInfoTableAdapter
            // 
            this.tbCollageInfoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCollageBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FrmCollageBrowse";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "浏览学院信息";
            this.Load += new System.EventHandler(this.FrmCollageBrowse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCollageInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_Information_SysDataSet1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSpecialityUpdate;
        private System.Windows.Forms.Button btnCollageDelect;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.DataGridView dgvCollage;
        private Students_Information_SysDataSet1 students_Information_SysDataSet1;
        private System.Windows.Forms.BindingSource tbCollageInfoBindingSource;
        private Students_Information_SysDataSet1TableAdapters.tbCollageInfoTableAdapter tbCollageInfoTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改学院信息ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}
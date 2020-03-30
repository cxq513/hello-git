namespace Students_Information_Sys
{
    partial class FrmSpecialityBrowse
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
            this.dgvSpeciality = new System.Windows.Forms.DataGridView();
            this.SpecialityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSpecialityInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_Information_SysDataSet3 = new Students_Information_Sys.Students_Information_SysDataSet3();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSpecialityUpdate = new System.Windows.Forms.Button();
            this.btnSpecialityDelect = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.tbSpecialityInfoTableAdapter = new Students_Information_Sys.Students_Information_SysDataSet3TableAdapters.tbSpecialityInfoTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeciality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpecialityInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_Information_SysDataSet3)).BeginInit();
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSpeciality);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所有专业信息";
            // 
            // dgvSpeciality
            // 
            this.dgvSpeciality.AllowUserToAddRows = false;
            this.dgvSpeciality.AllowUserToOrderColumns = true;
            this.dgvSpeciality.AutoGenerateColumns = false;
            this.dgvSpeciality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpeciality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeciality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecialityID,
            this.CollageName,
            this.SpecialityName,
            this.Remark});
            this.dgvSpeciality.DataSource = this.tbSpecialityInfoBindingSource;
            this.dgvSpeciality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpeciality.Location = new System.Drawing.Point(3, 17);
            this.dgvSpeciality.MinimumSize = new System.Drawing.Size(622, 342);
            this.dgvSpeciality.Name = "dgvSpeciality";
            this.dgvSpeciality.RowTemplate.Height = 23;
            this.dgvSpeciality.Size = new System.Drawing.Size(622, 342);
            this.dgvSpeciality.TabIndex = 0;
            // 
            // SpecialityID
            // 
            this.SpecialityID.DataPropertyName = "SpecialityID";
            this.SpecialityID.HeaderText = "编号";
            this.SpecialityID.Name = "SpecialityID";
            this.SpecialityID.ReadOnly = true;
            // 
            // CollageName
            // 
            this.CollageName.DataPropertyName = "CollageName";
            this.CollageName.HeaderText = "所属学院";
            this.CollageName.Name = "CollageName";
            // 
            // SpecialityName
            // 
            this.SpecialityName.DataPropertyName = "SpecialityName";
            this.SpecialityName.HeaderText = "专业名称";
            this.SpecialityName.Name = "SpecialityName";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "专业描述";
            this.Remark.Name = "Remark";
            // 
            // tbSpecialityInfoBindingSource
            // 
            this.tbSpecialityInfoBindingSource.DataMember = "tbSpecialityInfo";
            this.tbSpecialityInfoBindingSource.DataSource = this.students_Information_SysDataSet3;
            // 
            // students_Information_SysDataSet3
            // 
            this.students_Information_SysDataSet3.DataSetName = "Students_Information_SysDataSet3";
            this.students_Information_SysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSpecialityUpdate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSpecialityDelect, 1, 0);
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
            // btnSpecialityDelect
            // 
            this.btnSpecialityDelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpecialityDelect.Location = new System.Drawing.Point(276, 7);
            this.btnSpecialityDelect.Name = "btnSpecialityDelect";
            this.btnSpecialityDelect.Size = new System.Drawing.Size(75, 23);
            this.btnSpecialityDelect.TabIndex = 1;
            this.btnSpecialityDelect.Text = "删除";
            this.btnSpecialityDelect.UseVisualStyleBackColor = true;
            this.btnSpecialityDelect.Click += new System.EventHandler(this.btnSpecialityDelect_Click);
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
            // tbSpecialityInfoTableAdapter
            // 
            this.tbSpecialityInfoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSpecialityBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FrmSpecialityBrowse";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "浏览专业信息";
            this.Load += new System.EventHandler(this.FrmSpecialityBrowse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeciality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpecialityInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_Information_SysDataSet3)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSpeciality;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSpecialityUpdate;
        private System.Windows.Forms.Button btnSpecialityDelect;
        private System.Windows.Forms.Button Quit;
        private Students_Information_SysDataSet3 students_Information_SysDataSet3;
        private System.Windows.Forms.BindingSource tbSpecialityInfoBindingSource;
        private Students_Information_SysDataSet3TableAdapters.tbSpecialityInfoTableAdapter tbSpecialityInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}
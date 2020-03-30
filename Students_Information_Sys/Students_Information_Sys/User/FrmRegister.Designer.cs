namespace Students_Information_Sys
{
    partial class FrmRegister
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPwd = new System.Windows.Forms.Label();
            this.lblUserRPwd = new System.Windows.Forms.Label();
            this.PwdQuestion = new System.Windows.Forms.Label();
            this.PwdAnser = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.txtPwdAgin = new System.Windows.Forms.TextBox();
            this.combPwdQuestion = new System.Windows.Forms.ComboBox();
            this.txtPwdAnswer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserPwd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUserRPwd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PwdQuestion, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PwdAnser, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUserPwd, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPwdAgin, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.combPwdQuestion, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPwdAnswer, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(76, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用 户 名";
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserPwd.AutoSize = true;
            this.lblUserPwd.Location = new System.Drawing.Point(76, 91);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(53, 12);
            this.lblUserPwd.TabIndex = 1;
            this.lblUserPwd.Text = "密    码";
            // 
            // lblUserRPwd
            // 
            this.lblUserRPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserRPwd.AutoSize = true;
            this.lblUserRPwd.Location = new System.Drawing.Point(76, 127);
            this.lblUserRPwd.Name = "lblUserRPwd";
            this.lblUserRPwd.Size = new System.Drawing.Size(53, 12);
            this.lblUserRPwd.TabIndex = 2;
            this.lblUserRPwd.Text = "确认密码";
            // 
            // PwdQuestion
            // 
            this.PwdQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PwdQuestion.AutoSize = true;
            this.PwdQuestion.Location = new System.Drawing.Point(76, 163);
            this.PwdQuestion.Name = "PwdQuestion";
            this.PwdQuestion.Size = new System.Drawing.Size(53, 12);
            this.PwdQuestion.TabIndex = 3;
            this.PwdQuestion.Text = "密保问题";
            // 
            // PwdAnser
            // 
            this.PwdAnser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PwdAnser.AutoSize = true;
            this.PwdAnser.Location = new System.Drawing.Point(76, 199);
            this.PwdAnser.Name = "PwdAnser";
            this.PwdAnser.Size = new System.Drawing.Size(53, 12);
            this.PwdAnser.TabIndex = 4;
            this.PwdAnser.Text = "答    案";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(147, 50);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserPwd.Location = new System.Drawing.Point(147, 86);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(201, 21);
            this.txtUserPwd.TabIndex = 1;
            // 
            // txtPwdAgin
            // 
            this.txtPwdAgin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwdAgin.Location = new System.Drawing.Point(147, 122);
            this.txtPwdAgin.Name = "txtPwdAgin";
            this.txtPwdAgin.Size = new System.Drawing.Size(201, 21);
            this.txtPwdAgin.TabIndex = 2;
            // 
            // combPwdQuestion
            // 
            this.combPwdQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combPwdQuestion.FormattingEnabled = true;
            this.combPwdQuestion.Items.AddRange(new object[] {
            "你小学老师的名字是？",
            "你最喜欢的宠物是？",
            "你配偶的名字是？",
            "你最喜欢的品牌是？",
            "你第一个手机品牌是？"});
            this.combPwdQuestion.Location = new System.Drawing.Point(147, 159);
            this.combPwdQuestion.Name = "combPwdQuestion";
            this.combPwdQuestion.Size = new System.Drawing.Size(201, 20);
            this.combPwdQuestion.TabIndex = 3;
            // 
            // txtPwdAnswer
            // 
            this.txtPwdAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwdAnswer.Location = new System.Drawing.Point(147, 194);
            this.txtPwdAnswer.Name = "txtPwdAnswer";
            this.txtPwdAnswer.Size = new System.Drawing.Size(201, 21);
            this.txtPwdAnswer.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOk, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(147, 226);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(201, 30);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 24);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "注册";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(103, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 330);
            this.MinimumSize = new System.Drawing.Size(430, 330);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserPwd;
        private System.Windows.Forms.Label lblUserRPwd;
        private System.Windows.Forms.Label PwdQuestion;
        private System.Windows.Forms.Label PwdAnser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.TextBox txtPwdAgin;
        private System.Windows.Forms.ComboBox combPwdQuestion;
        private System.Windows.Forms.TextBox txtPwdAnswer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
    }
}
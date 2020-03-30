namespace Students_Information_Sys
{
    partial class FrmPwdQuestionANDPwd
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PwdQuestion = new System.Windows.Forms.Label();
            this.combPwdQuestion = new System.Windows.Forms.ComboBox();
            this.PwdAnser = new System.Windows.Forms.Label();
            this.txtPwdAnswer = new System.Windows.Forms.TextBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.lblUserPwd = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.PwdQuestion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.combPwdQuestion, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.PwdAnser, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPwdAnswer, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUserPwd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserPwd, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 216);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOk, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(141, 154);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 30);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 24);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(98, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PwdQuestion
            // 
            this.PwdQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PwdQuestion.AutoSize = true;
            this.PwdQuestion.Location = new System.Drawing.Point(72, 91);
            this.PwdQuestion.Name = "PwdQuestion";
            this.PwdQuestion.Size = new System.Drawing.Size(53, 12);
            this.PwdQuestion.TabIndex = 3;
            this.PwdQuestion.Text = "密保问题";
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
            this.combPwdQuestion.Location = new System.Drawing.Point(141, 87);
            this.combPwdQuestion.Name = "combPwdQuestion";
            this.combPwdQuestion.Size = new System.Drawing.Size(191, 20);
            this.combPwdQuestion.TabIndex = 1;
            // 
            // PwdAnser
            // 
            this.PwdAnser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PwdAnser.AutoSize = true;
            this.PwdAnser.Location = new System.Drawing.Point(72, 127);
            this.PwdAnser.Name = "PwdAnser";
            this.PwdAnser.Size = new System.Drawing.Size(53, 12);
            this.PwdAnser.TabIndex = 4;
            this.PwdAnser.Text = "答    案";
            // 
            // txtPwdAnswer
            // 
            this.txtPwdAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwdAnswer.Location = new System.Drawing.Point(141, 122);
            this.txtPwdAnswer.Name = "txtPwdAnswer";
            this.txtPwdAnswer.Size = new System.Drawing.Size(191, 21);
            this.txtPwdAnswer.TabIndex = 2;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserPwd.Location = new System.Drawing.Point(141, 50);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(191, 21);
            this.txtUserPwd.TabIndex = 3;
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserPwd.AutoSize = true;
            this.lblUserPwd.Location = new System.Drawing.Point(72, 55);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(53, 12);
            this.lblUserPwd.TabIndex = 1;
            this.lblUserPwd.Text = "密    码";
            // 
            // FrmPwdQuestionANDPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 216);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmPwdQuestionANDPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入密码和密保答案";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label PwdQuestion;
        private System.Windows.Forms.ComboBox combPwdQuestion;
        private System.Windows.Forms.Label lblUserPwd;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.Label PwdAnser;
        private System.Windows.Forms.TextBox txtPwdAnswer;
    }
}
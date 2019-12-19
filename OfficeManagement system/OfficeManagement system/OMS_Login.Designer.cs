namespace OfficeManagement_system
{
    partial class OMS_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPassWord = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPassWord = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.LabelForgetPassword = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(70, 130);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(59, 35);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "登录";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click_1);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(70, 40);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(183, 21);
            this.TextBoxName.TabIndex = 1;
            // 
            // TextBoxPassWord
            // 
            this.TextBoxPassWord.Location = new System.Drawing.Point(70, 82);
            this.TextBoxPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxPassWord.Name = "TextBoxPassWord";
            this.TextBoxPassWord.Size = new System.Drawing.Size(183, 21);
            this.TextBoxPassWord.TabIndex = 2;
            this.TextBoxPassWord.UseSystemPasswordChar = true;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(20, 40);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(41, 12);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "账户：";
            // 
            // LabelPassWord
            // 
            this.LabelPassWord.AutoSize = true;
            this.LabelPassWord.Location = new System.Drawing.Point(20, 84);
            this.LabelPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassWord.Name = "LabelPassWord";
            this.LabelPassWord.Size = new System.Drawing.Size(41, 12);
            this.LabelPassWord.TabIndex = 4;
            this.LabelPassWord.Text = "密码：";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(154, 130);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(54, 35);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "取消";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // LabelForgetPassword
            // 
            this.LabelForgetPassword.AutoSize = true;
            this.LabelForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelForgetPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelForgetPassword.Location = new System.Drawing.Point(256, 84);
            this.LabelForgetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelForgetPassword.Name = "LabelForgetPassword";
            this.LabelForgetPassword.Size = new System.Drawing.Size(65, 12);
            this.LabelForgetPassword.TabIndex = 6;
            this.LabelForgetPassword.Text = "忘了密码？";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelLogin.Location = new System.Drawing.Point(256, 42);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(53, 12);
            this.LabelLogin.TabIndex = 7;
            this.LabelLogin.Text = "我要注册";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_Click);
            // 
            // OMS_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 195);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelForgetPassword);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.LabelPassWord);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxPassWord);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OMS_Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPassWord;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPassWord;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label LabelForgetPassword;
        private System.Windows.Forms.Label LabelLogin;
    }
}


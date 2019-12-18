namespace OfficeManagement_system
{
    partial class OMS_Enroll
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnrollTextBoxName = new System.Windows.Forms.TextBox();
            this.EnrollTextBoxPassword = new System.Windows.Forms.TextBox();
            this.EnrollTextBoxBriefDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EnrollDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnrollButtonOK = new System.Windows.Forms.Button();
            this.EnrollButtonNO = new System.Windows.Forms.Button();
            this.EnrollRButtonTrue = new System.Windows.Forms.RadioButton();
            this.EnrollRButtonFalse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "简介：";
            // 
            // EnrollTextBoxName
            // 
            this.EnrollTextBoxName.Location = new System.Drawing.Point(125, 56);
            this.EnrollTextBoxName.Name = "EnrollTextBoxName";
            this.EnrollTextBoxName.Size = new System.Drawing.Size(148, 25);
            this.EnrollTextBoxName.TabIndex = 1;
            // 
            // EnrollTextBoxPassword
            // 
            this.EnrollTextBoxPassword.Location = new System.Drawing.Point(125, 100);
            this.EnrollTextBoxPassword.Name = "EnrollTextBoxPassword";
            this.EnrollTextBoxPassword.Size = new System.Drawing.Size(148, 25);
            this.EnrollTextBoxPassword.TabIndex = 1;
            // 
            // EnrollTextBoxBriefDescription
            // 
            this.EnrollTextBoxBriefDescription.Location = new System.Drawing.Point(125, 234);
            this.EnrollTextBoxBriefDescription.Name = "EnrollTextBoxBriefDescription";
            this.EnrollTextBoxBriefDescription.Size = new System.Drawing.Size(200, 25);
            this.EnrollTextBoxBriefDescription.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "生日：";
            // 
            // EnrollDateTimePicker
            // 
            this.EnrollDateTimePicker.Location = new System.Drawing.Point(125, 191);
            this.EnrollDateTimePicker.Name = "EnrollDateTimePicker";
            this.EnrollDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.EnrollDateTimePicker.TabIndex = 2;
            // 
            // EnrollButtonOK
            // 
            this.EnrollButtonOK.Location = new System.Drawing.Point(81, 294);
            this.EnrollButtonOK.Name = "EnrollButtonOK";
            this.EnrollButtonOK.Size = new System.Drawing.Size(78, 40);
            this.EnrollButtonOK.TabIndex = 3;
            this.EnrollButtonOK.Text = "确定";
            this.EnrollButtonOK.UseVisualStyleBackColor = true;
            this.EnrollButtonOK.Click += new System.EventHandler(this.EnrollButtonOK_Click);
            // 
            // EnrollButtonNO
            // 
            this.EnrollButtonNO.Location = new System.Drawing.Point(195, 294);
            this.EnrollButtonNO.Name = "EnrollButtonNO";
            this.EnrollButtonNO.Size = new System.Drawing.Size(78, 40);
            this.EnrollButtonNO.TabIndex = 3;
            this.EnrollButtonNO.Text = "取消";
            this.EnrollButtonNO.UseVisualStyleBackColor = true;
            // 
            // EnrollRButtonTrue
            // 
            this.EnrollRButtonTrue.AutoSize = true;
            this.EnrollRButtonTrue.Checked = true;
            this.EnrollRButtonTrue.Location = new System.Drawing.Point(125, 151);
            this.EnrollRButtonTrue.Name = "EnrollRButtonTrue";
            this.EnrollRButtonTrue.Size = new System.Drawing.Size(43, 19);
            this.EnrollRButtonTrue.TabIndex = 4;
            this.EnrollRButtonTrue.TabStop = true;
            this.EnrollRButtonTrue.Text = "男";
            this.EnrollRButtonTrue.UseVisualStyleBackColor = true;
            // 
            // EnrollRButtonFalse
            // 
            this.EnrollRButtonFalse.AutoSize = true;
            this.EnrollRButtonFalse.Location = new System.Drawing.Point(195, 151);
            this.EnrollRButtonFalse.Name = "EnrollRButtonFalse";
            this.EnrollRButtonFalse.Size = new System.Drawing.Size(43, 19);
            this.EnrollRButtonFalse.TabIndex = 4;
            this.EnrollRButtonFalse.TabStop = true;
            this.EnrollRButtonFalse.Text = "女";
            this.EnrollRButtonFalse.UseVisualStyleBackColor = true;
            // 
            // OMS_Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 374);
            this.Controls.Add(this.EnrollRButtonFalse);
            this.Controls.Add(this.EnrollRButtonTrue);
            this.Controls.Add(this.EnrollButtonNO);
            this.Controls.Add(this.EnrollButtonOK);
            this.Controls.Add(this.EnrollDateTimePicker);
            this.Controls.Add(this.EnrollTextBoxBriefDescription);
            this.Controls.Add(this.EnrollTextBoxPassword);
            this.Controls.Add(this.EnrollTextBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OMS_Enroll";
            this.Text = "OMS_Enroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnrollTextBoxName;
        private System.Windows.Forms.TextBox EnrollTextBoxPassword;
        private System.Windows.Forms.TextBox EnrollTextBoxBriefDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EnrollDateTimePicker;
        private System.Windows.Forms.Button EnrollButtonOK;
        private System.Windows.Forms.Button EnrollButtonNO;
        private System.Windows.Forms.RadioButton EnrollRButtonTrue;
        private System.Windows.Forms.RadioButton EnrollRButtonFalse;
    }
}
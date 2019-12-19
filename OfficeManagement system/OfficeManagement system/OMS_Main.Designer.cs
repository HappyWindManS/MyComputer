namespace OfficeManagement_system
{
    partial class OMS_Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EmployeeManage = new System.Windows.Forms.TabPage();
            this.TGOneButSign = new System.Windows.Forms.Button();
            this.TGoneRBGirl = new System.Windows.Forms.RadioButton();
            this.TGOneRBMan = new System.Windows.Forms.RadioButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.TGOneTextIntro = new System.Windows.Forms.TextBox();
            this.TGOneTextAge = new System.Windows.Forms.TextBox();
            this.TPoneTextName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentLibrary = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AttendanceManage = new System.Windows.Forms.TabPage();
            this.FileManage = new System.Windows.Forms.TabPage();
            this.StaffManage = new System.Windows.Forms.TabPage();
            this.Affair = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.EmployeeManage.SuspendLayout();
            this.DocumentLibrary.SuspendLayout();
            this.AttendanceManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EmployeeManage);
            this.tabControl1.Controls.Add(this.DocumentLibrary);
            this.tabControl1.Controls.Add(this.AttendanceManage);
            this.tabControl1.Controls.Add(this.FileManage);
            this.tabControl1.Controls.Add(this.StaffManage);
            this.tabControl1.Controls.Add(this.Affair);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // EmployeeManage
            // 
            this.EmployeeManage.Controls.Add(this.TGOneButSign);
            this.EmployeeManage.Controls.Add(this.TGoneRBGirl);
            this.EmployeeManage.Controls.Add(this.TGOneRBMan);
            this.EmployeeManage.Controls.Add(this.textBox7);
            this.EmployeeManage.Controls.Add(this.TGOneTextIntro);
            this.EmployeeManage.Controls.Add(this.TGOneTextAge);
            this.EmployeeManage.Controls.Add(this.TPoneTextName);
            this.EmployeeManage.Controls.Add(this.label4);
            this.EmployeeManage.Controls.Add(this.label3);
            this.EmployeeManage.Controls.Add(this.label2);
            this.EmployeeManage.Controls.Add(this.label11);
            this.EmployeeManage.Controls.Add(this.label1);
            this.EmployeeManage.Location = new System.Drawing.Point(4, 22);
            this.EmployeeManage.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeManage.Name = "EmployeeManage";
            this.EmployeeManage.Padding = new System.Windows.Forms.Padding(2);
            this.EmployeeManage.Size = new System.Drawing.Size(626, 371);
            this.EmployeeManage.TabIndex = 0;
            this.EmployeeManage.Text = "个人信息";
            this.EmployeeManage.UseVisualStyleBackColor = true;
            // 
            // TGOneButSign
            // 
            this.TGOneButSign.Location = new System.Drawing.Point(391, 289);
            this.TGOneButSign.Name = "TGOneButSign";
            this.TGOneButSign.Size = new System.Drawing.Size(206, 58);
            this.TGOneButSign.TabIndex = 4;
            this.TGOneButSign.Text = "签到";
            this.TGOneButSign.UseVisualStyleBackColor = true;
            this.TGOneButSign.Click += new System.EventHandler(this.TGOneButSign_Click);
            // 
            // TGoneRBGirl
            // 
            this.TGoneRBGirl.AutoSize = true;
            this.TGoneRBGirl.Enabled = false;
            this.TGoneRBGirl.Location = new System.Drawing.Point(181, 87);
            this.TGoneRBGirl.Name = "TGoneRBGirl";
            this.TGoneRBGirl.Size = new System.Drawing.Size(35, 16);
            this.TGoneRBGirl.TabIndex = 2;
            this.TGoneRBGirl.TabStop = true;
            this.TGoneRBGirl.Text = "女";
            this.TGoneRBGirl.UseVisualStyleBackColor = true;
            // 
            // TGOneRBMan
            // 
            this.TGOneRBMan.AutoSize = true;
            this.TGOneRBMan.Enabled = false;
            this.TGOneRBMan.Location = new System.Drawing.Point(100, 87);
            this.TGOneRBMan.Name = "TGOneRBMan";
            this.TGOneRBMan.Size = new System.Drawing.Size(35, 16);
            this.TGOneRBMan.TabIndex = 2;
            this.TGOneRBMan.TabStop = true;
            this.TGOneRBMan.Text = "男";
            this.TGOneRBMan.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(391, 64);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(206, 219);
            this.textBox7.TabIndex = 1;
            // 
            // TGOneTextIntro
            // 
            this.TGOneTextIntro.Enabled = false;
            this.TGOneTextIntro.Location = new System.Drawing.Point(100, 186);
            this.TGOneTextIntro.Multiline = true;
            this.TGOneTextIntro.Name = "TGOneTextIntro";
            this.TGOneTextIntro.Size = new System.Drawing.Size(157, 161);
            this.TGOneTextIntro.TabIndex = 1;
            // 
            // TGOneTextAge
            // 
            this.TGOneTextAge.Enabled = false;
            this.TGOneTextAge.Location = new System.Drawing.Point(100, 134);
            this.TGOneTextAge.Name = "TGOneTextAge";
            this.TGOneTextAge.Size = new System.Drawing.Size(157, 21);
            this.TGOneTextAge.TabIndex = 1;
            // 
            // TPoneTextName
            // 
            this.TPoneTextName.Enabled = false;
            this.TPoneTextName.Location = new System.Drawing.Point(100, 33);
            this.TPoneTextName.Name = "TPoneTextName";
            this.TPoneTextName.Size = new System.Drawing.Size(157, 21);
            this.TPoneTextName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "简介：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "通知：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // DocumentLibrary
            // 
            this.DocumentLibrary.Controls.Add(this.label9);
            this.DocumentLibrary.Controls.Add(this.listBox1);
            this.DocumentLibrary.Controls.Add(this.textBox4);
            this.DocumentLibrary.Controls.Add(this.textBox2);
            this.DocumentLibrary.Controls.Add(this.textBox5);
            this.DocumentLibrary.Controls.Add(this.textBox3);
            this.DocumentLibrary.Controls.Add(this.textBox1);
            this.DocumentLibrary.Controls.Add(this.button3);
            this.DocumentLibrary.Controls.Add(this.button2);
            this.DocumentLibrary.Controls.Add(this.button1);
            this.DocumentLibrary.Controls.Add(this.label8);
            this.DocumentLibrary.Controls.Add(this.label6);
            this.DocumentLibrary.Controls.Add(this.label7);
            this.DocumentLibrary.Controls.Add(this.label5);
            this.DocumentLibrary.Location = new System.Drawing.Point(4, 22);
            this.DocumentLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.DocumentLibrary.Name = "DocumentLibrary";
            this.DocumentLibrary.Padding = new System.Windows.Forms.Padding(2);
            this.DocumentLibrary.Size = new System.Drawing.Size(626, 371);
            this.DocumentLibrary.TabIndex = 1;
            this.DocumentLibrary.Text = "文件借阅";
            this.DocumentLibrary.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(25, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 280);
            this.listBox1.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(442, 271);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 21);
            this.textBox4.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 21);
            this.textBox2.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(25, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 21);
            this.textBox5.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(442, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 21);
            this.textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "搜索";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "归还";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "借阅";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "文件位置：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "文件种类：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "文件编号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "文件名称：";
            // 
            // AttendanceManage
            // 
            this.AttendanceManage.Controls.Add(this.listBox2);
            this.AttendanceManage.Controls.Add(this.label10);
            this.AttendanceManage.Location = new System.Drawing.Point(4, 22);
            this.AttendanceManage.Margin = new System.Windows.Forms.Padding(2);
            this.AttendanceManage.Name = "AttendanceManage";
            this.AttendanceManage.Size = new System.Drawing.Size(626, 371);
            this.AttendanceManage.TabIndex = 2;
            this.AttendanceManage.Text = "考勤管理";
            this.AttendanceManage.UseVisualStyleBackColor = true;
            // 
            // FileManage
            // 
            this.FileManage.Location = new System.Drawing.Point(4, 22);
            this.FileManage.Margin = new System.Windows.Forms.Padding(2);
            this.FileManage.Name = "FileManage";
            this.FileManage.Size = new System.Drawing.Size(626, 371);
            this.FileManage.TabIndex = 3;
            this.FileManage.Text = "文件管理";
            this.FileManage.UseVisualStyleBackColor = true;
            // 
            // StaffManage
            // 
            this.StaffManage.Location = new System.Drawing.Point(4, 22);
            this.StaffManage.Margin = new System.Windows.Forms.Padding(2);
            this.StaffManage.Name = "StaffManage";
            this.StaffManage.Size = new System.Drawing.Size(626, 371);
            this.StaffManage.TabIndex = 4;
            this.StaffManage.Text = "员工管理";
            this.StaffManage.UseVisualStyleBackColor = true;
            // 
            // Affair
            // 
            this.Affair.Location = new System.Drawing.Point(4, 22);
            this.Affair.Margin = new System.Windows.Forms.Padding(2);
            this.Affair.Name = "Affair";
            this.Affair.Size = new System.Drawing.Size(626, 371);
            this.Affair.TabIndex = 5;
            this.Affair.Text = "事务";
            this.Affair.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "考勤记录：";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(38, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(566, 292);
            this.listBox2.TabIndex = 1;
            // 
            // OMS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 412);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OMS_Main";
            this.Text = "OMS_Main";
            this.Load += new System.EventHandler(this.OMS_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.EmployeeManage.ResumeLayout(false);
            this.EmployeeManage.PerformLayout();
            this.DocumentLibrary.ResumeLayout(false);
            this.DocumentLibrary.PerformLayout();
            this.AttendanceManage.ResumeLayout(false);
            this.AttendanceManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EmployeeManage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage DocumentLibrary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage AttendanceManage;
        private System.Windows.Forms.TabPage FileManage;
        private System.Windows.Forms.TabPage StaffManage;
        private System.Windows.Forms.TabPage Affair;
        private System.Windows.Forms.Button TGOneButSign;
        private System.Windows.Forms.RadioButton TGoneRBGirl;
        private System.Windows.Forms.RadioButton TGOneRBMan;
        private System.Windows.Forms.TextBox TGOneTextIntro;
        private System.Windows.Forms.TextBox TGOneTextAge;
        private System.Windows.Forms.TextBox TPoneTextName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label10;
    }
}
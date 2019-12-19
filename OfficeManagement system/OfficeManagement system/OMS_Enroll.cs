using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeManagement_system
{
    public partial class OMS_Enroll : Form
    {
        public OMS_Enroll()
        {
            InitializeComponent();
        }

        private void EnrollButtonOK_Click(object sender, EventArgs e)
        {
            string Name = EnrollTextBoxName.Text;
            string Password = EnrollTextBoxPassword.Text;
            bool Sex = EnrollRButtonTrue.Checked;
            int Age = (DateTime.Now - EnrollDateTimePicker.Value).Days/365;
            string Position = "超级管理员";
            string BriefDescription = EnrollTextBoxBriefDescription.Text;
            DateTime Birthday = EnrollDateTimePicker.Value;
            if (new EmployeeBLL().InsertEmployee(Name,Password,Sex,Age,Position,Birthday,BriefDescription))
            {
                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }

        private void EnrollButtonNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

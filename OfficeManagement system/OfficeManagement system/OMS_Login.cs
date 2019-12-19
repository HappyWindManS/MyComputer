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
    public partial class OMS_Login : Form
    {
        public OMS_Login()
        {
            InitializeComponent();
        }

        private void LabelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            OMS_Enroll enroll = new OMS_Enroll();
            enroll.ShowDialog();
            this.Show();
        }

        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {
            if (new EmployeeBLL().Login(TextBoxName.Text, TextBoxPassWord.Text))
            {
                MessageBox.Show("登录成功");
                this.Hide();
                var employee = new EmployeeBLL().GetAllEmployee();
                OMS_Main main = new OMS_Main(TextBoxName.Text);
                main.Show();
                this.Close();            
            }
            else
            {
                MessageBox.Show("登录失败，用户名或密码错误");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            TextBoxName.Text = null;
            TextBoxPassWord.Text = null;
        }
    }
}

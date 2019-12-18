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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

        }

        private void LabelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            OMS_Enroll enroll = new OMS_Enroll();
            enroll.ShowDialog();
            this.Show();
        }
    }
}

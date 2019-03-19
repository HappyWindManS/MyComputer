using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 英语ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult languageChange = MessageBox.Show("是否切换成英文？", "请确认",MessageBoxButtons.OKCancel);
            if(languageChange==DialogResult.OK)
            {

            }
            else
            {

            }
        }
    }
}

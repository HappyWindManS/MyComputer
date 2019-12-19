using BusinessLogicLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeManagement_system
{
    public partial class OMS_Main : Form
    {
        private List<Employee> _employee;
        private List<Attendance> _attendance;
        private List<Conferee> _conferee;
        private List<FileBorrowingLog> _borrowingLog;
        private List<Paper> _paper;
        private List<PaperSort> _paperSort;
        private List<Meeting> _meeting;
        public OMS_Main()
        {
            InitializeComponent();
        }

        private void OMS_Main_Load(object sender, EventArgs e)
        {
            _employee = new EmployeeBLL().GetAll();
            _attendance = new AttendanceBLL().GetAll();
            _conferee = new ConfereeBLL().GetAll();
            _borrowingLog = new FileBorrowingLogBLL().GetAll();
            _paper = new PaperBLL().GetAll();
            _meeting = new MeetingBLL().GetAll();
            _paperSort = new PaperSortBLL().GetAll();
        }

        private void TGOneButSign_Click(object sender, EventArgs e)
        {
            if (TGOneButSign.Text == "签到")
            {

            }
        }


    }
}

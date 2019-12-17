using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 考勤
    /// </summary>
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SignInTime { get; set; }
        public DateTime SignOutTime { get; set; }

        public Attendance()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 参会人
    /// </summary>
    public class Conferee
    {
        public int ConfereeId { get; set; }
        public int MeetingId { get; set; }
        public DateTime MeetingTime { get; set; }
        public int EmployeeId { get; set; }
        public Conferee()
        {

        }
    }
}

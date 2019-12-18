using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 会议
    /// </summary>
    public class Meeting
    {  
        public int MeetingId { get; set; }
        public DateTime MeetingTime { get; set; }
        public string Registrar { get; set; }
        public string BriefDescription { get; set; }
        public Meeting()
        {

        }
    }
}

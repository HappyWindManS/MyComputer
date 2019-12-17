using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZGKdata.Data_Table;

namespace ZKGDataAPI.ReptileModel
{
    public class MajorScoreModel
    {
        public string dual_class_name { get; set; }
        public string f211 { get; set; }
        public string f985 { get; set; }
        public string id { get; set; }
        public string is_important { get; set; }
        public string levell { get; set; }
        public string name { get; set; }
        public virtual SchoolScoreModel school_id { get; set; }
        public string school_nature { get; set; }
        public string school_sp_id { get; set; }
        public string school_type { get; set; }
        public string special_id { get; set; }
        public string spname { get; set; }
        public string type_name { get; set; }
        public string year { get; set; }
    }
}

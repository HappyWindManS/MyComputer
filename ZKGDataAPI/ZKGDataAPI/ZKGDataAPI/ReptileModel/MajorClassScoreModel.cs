﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGKdata.Data_Table
{
    public class MajorClassScoreModel
    {
        public string average { get; set; }
        public string year { get; set; }
        public string min { get; set; }
        public virtual RegionModel school_id { get; set; }
        public string min_section { get; set; }
        public string max { get; set; }
        public string special_id { get; set; }
        public string local_province_name { get; set; }
        public string local_batch_name { get; set; }
        public string spname { get; set; }
        public string name { get; set; }
        public string local_type_name { get; set; }
        public string dual_class_name { get; set; }
        public string proscore { get; set; }
 
      
        
    }
}

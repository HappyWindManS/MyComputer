using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGKdata.Data_Table
{
    public class RegionModel
    {
       
        public string name { get; set; }
        [Key]
        public string code { get; set; }
    }
}

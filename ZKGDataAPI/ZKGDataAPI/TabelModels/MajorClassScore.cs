using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZGKdata.Data_Table;

namespace ZKGDataAPI.TabelModels
{
    public class MajorClassScore: MajorClassScoreModel
    {
        [Key]
        public Guid guid { get; set; }       
        public MajorClassScore()
        {
            this.guid = new Guid();
        }
    }
}

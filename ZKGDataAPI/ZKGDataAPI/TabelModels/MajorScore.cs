using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZKGDataAPI.ReptileModel;

namespace ZKGDataAPI.TabelModels
{
    public class MajorScore:MajorScoreModel
    {
        [Key]
        public Guid guid { get; set; }
        public MajorScore()
        {
            this.guid = new Guid();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZKGDataAPI.TabelModels;

namespace ZGKdata.Data_Table
{
    public class User
    {     
        [Key]
        public Guid ID { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string headPortrait { get; set; }
        public string synopsis { get; set; }
        public DateTime birthday { get; set; }
        public string eMail { get; set; }
        public string phoneNum { get; set; }
        public Role role { get; set; }
        public User()
        {
            this.ID = Guid.NewGuid();
        }
    }
}

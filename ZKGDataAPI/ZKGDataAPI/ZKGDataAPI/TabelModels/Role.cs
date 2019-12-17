using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZKGDataAPI.TabelModels
{
    public class Role
    { 
        public Guid guid { get; set; }
        public RoleTypeEnum RoleType { get; set; }   
        public string ChineseFullName { get; set; } // 中文全名
        public string MobileNumber { get; set; }    // 移动电话
        public bool ModifyUserRole { get; set; }
        public bool ModifyData { get; set; }
        public bool Comment { get; set; }
        public bool UserControl { get; set; }
        public string AvatarPath { get; set; }   //头像   
        public Role()
        {
            this.guid = Guid.NewGuid();
        }
    }
}

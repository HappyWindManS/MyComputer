using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 员工
    /// </summary>
   public class Employee
    {
        public int EmployeeID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public int Age { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public string Position { get; set; }
        public DateTime Birthday { get; set; }
        public string BriefDescription { get; set; }
        public Employee()
        {
            
        }
    }
}

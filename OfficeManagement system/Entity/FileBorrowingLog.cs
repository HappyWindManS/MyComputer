using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 文件借阅记录
    /// </summary>
    public class FileBorrowingLog
    {
        public int FBLId { get; set; }
        public int PaperId { get; set; }
        public DateTime BorrowDate { get; set; }
        public int EmployeeId { get; set; }
        /// <summary>
        /// 归还时间
        /// </summary>
        public DateTime ReturnTime { get; set; }
        public FileBorrowingLog()
        {

        }
    }
}

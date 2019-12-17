using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 文件
    /// </summary>
    public class Paper
    {
        public int PaperId { get; set; }
        public string Name { get; set; }
        public int SortId { get; set; }
        public string PaperLocation { get; set; }
        public Paper()
        {

        }
    }
}

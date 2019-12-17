﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// 自定义不能访问数据库的异常类
    /// </summary>
    class DBException:Exception
    {
        public DBException(Exception innerException) : base("不能访问数据库", innerException) { }
    }
}

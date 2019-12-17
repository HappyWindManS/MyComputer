using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// 数据维护统一接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICRUD<T>
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Edit(T entity);
        List<T> GetAll();
        T GetByID(int id);
    }
}

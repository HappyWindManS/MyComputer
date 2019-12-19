using DataAccessLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PaperSortBLL
    {
        private SqlCommand cmd;
        public PaperSortBLL()
        {
            cmd = new SqlCommand();
            //指定SQL命令为执行存储过程
            cmd.CommandType = CommandType.StoredProcedure;

        }

        public DataSet GetAllPaperSort()
        {
            cmd.CommandText = "GetAllPaperSort";
            return DBAccess.QueryData(cmd);
        }

        public bool InsertPaperSort(string Name)
        {
            cmd.CommandText = "InsertPaperSort";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@Name",Name) ,
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeletePaperSort(string PaperSortId)
        {
            cmd.CommandText = "DeletePaperSort";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PaperSortID", SqlDbType.Int).Value = PaperSortId;
            int i = DBAccess.ExecuteSQL(cmd);
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool UpdatePaperSort(int PaperSortid, string Name)
        {
            cmd.CommandText = "UpdatePaperSortInfo";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@PaperSortID",PaperSortid) ,
               new SqlParameter("@Name",Name) 
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<PaperSort> GetAll()
        {
            cmd.CommandText = "GetAllPaperSort";
            cmd.Parameters.Clear();
            var list = new List<PaperSort>();
            var data = DBAccess.ReadData(cmd);
            while (data.Read())
            {
                var e = new PaperSort();
                e.Name = Convert.ToString(data["Name"]);
                e.PaperSortId = Convert.ToInt32(data["PaperSortId"]);
                list.Add(e);
            }
            data.Close();
            return list;
        }
    }
}

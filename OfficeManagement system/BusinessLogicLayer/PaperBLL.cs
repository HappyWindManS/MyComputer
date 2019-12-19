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
    public class PaperBLL
    {
        private SqlCommand cmd;
        public PaperBLL()
        {
            cmd = new SqlCommand();
            //指定SQL命令为执行存储过程
            cmd.CommandType = CommandType.StoredProcedure;

        }

        public DataSet GetAllPaper()
        {
            cmd.CommandText = "GetAllPaper";
            return DBAccess.QueryData(cmd);
        }

        public bool InsertPaper(string Name,int SortId, string PaperLocation)
        {
            cmd.CommandText = "InsertPaper";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@Name",Name) ,
               new SqlParameter("@SortId",SortId) ,
               new SqlParameter("@PaperLocation",PaperLocation)
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeletePaper(string PaperId)
        {
            cmd.CommandText = "DeletePaper";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PaperID", SqlDbType.Int).Value = PaperId;
            int i = DBAccess.ExecuteSQL(cmd);
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool UpdatePaper(int Paperid, string Name, int SortId, string PaperLocation)
        {
            cmd.CommandText = "UpdatePaperInfo";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@PaperID",Paperid) ,
               new SqlParameter("@Name",Name) ,
               new SqlParameter("@SortId",SortId) ,
               new SqlParameter("@PaperLocation",PaperLocation)
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Paper> GetAll()
        {
            cmd.CommandText = "GetAllPaper";
            cmd.Parameters.Clear();
            var list = new List<Paper>();
            var data = DBAccess.ReadData(cmd);
            while (data.Read())
            {
                var e = new Paper();
                e.Name = Convert.ToString(data["Name"]);
                e.PaperId = Convert.ToInt32(data["PaperId"]);
                e.PaperLocation = Convert.ToString(data["PaperLocation"]);
                e.SortId = Convert.ToInt32(data["SortId"]);
                list.Add(e);
            }
            data.Close();
            return list;
        }
    }
}

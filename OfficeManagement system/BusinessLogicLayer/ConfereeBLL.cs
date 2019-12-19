using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ConfereeBLL
    {
        private SqlCommand cmd;
        public ConfereeBLL()
        {
            cmd = new SqlCommand();
            //指定SQL命令为执行存储过程
            cmd.CommandType = CommandType.StoredProcedure;

        }

        public DataSet GetAllConferee()
        {
            cmd.CommandText = "GetAllConferee";
            return DBAccess.QueryData(cmd);
        }

        public bool InsertConferee(int MeetingId, DateTime MeetingTime, int EmployeeId)
        {
            cmd.CommandText = "InsertConferee";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@MeetingId",MeetingId) ,
               new SqlParameter("@MeetingTime",MeetingTime) ,
               new SqlParameter("@EmployeeId",EmployeeId) 
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeleteConferee(string ConfereeId)
        {
            cmd.CommandText = "DeleteConferee";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ConfereeID", SqlDbType.Int).Value = ConfereeId;
            int i = DBAccess.ExecuteSQL(cmd);
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool UpdateConferee(int Confereeid, int MeetingId, DateTime MeetingTime, int EmployeeId)
        {
            cmd.CommandText = "UpdateConfereeInfo";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@ConfereeID",Confereeid) ,
                new SqlParameter("@MeetingId",MeetingId) ,
               new SqlParameter("@MeetingTime",MeetingTime) ,
               new SqlParameter("@EmployeeId",EmployeeId)
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}

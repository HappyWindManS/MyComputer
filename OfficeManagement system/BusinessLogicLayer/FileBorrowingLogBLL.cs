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
    public class FileBorrowingLogBLL
    {
        private SqlCommand cmd;
        public FileBorrowingLogBLL()
        {
            cmd = new SqlCommand();
            //指定SQL命令为执行存储过程
            cmd.CommandType = CommandType.StoredProcedure;

        }

        public DataSet GetAllFileBorrowingLog()
        {
            cmd.CommandText = "GetAllFileBorrowingLog";
            return DBAccess.QueryData(cmd);
        }

        public bool InsertFileBorrowingLog(int PaperId, DateTime BorowDate, int EmployeeId,DateTime ReturnTime)
        {
            cmd.CommandText = "InsertFileBorrowingLog";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@PaperId",PaperId) ,
               new SqlParameter("@BorowDate",BorowDate) ,
               new SqlParameter("@EmployeeId",EmployeeId),
               new SqlParameter("@BorowDate",ReturnTime) 
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeleteFileBorrowingLog(string FileBorrowingLogId)
        {
            cmd.CommandText = "DeleteFileBorrowingLog";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@FileBorrowingLogID", SqlDbType.Int).Value = FileBorrowingLogId;
            int i = DBAccess.ExecuteSQL(cmd);
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool UpdateFileBorrowingLog(int FileBorrowingLogid, int PaperId, DateTime BorowDate, 
            int EmployeeId, DateTime ReturnTime)
        {
            cmd.CommandText = "UpdateFileBorrowingLogInfo";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@FBLID",FileBorrowingLogid) ,
               new SqlParameter("@PaperId",PaperId) ,
               new SqlParameter("@BorowDate",BorowDate) ,
               new SqlParameter("@EmployeeId",EmployeeId),
               new SqlParameter("@BorowDate",ReturnTime)
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

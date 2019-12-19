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
    public class AttendanceBLL
    {
        private SqlCommand cmd;
        public AttendanceBLL()
        {
            cmd = new SqlCommand();
            //指定SQL命令为执行存储过程
            cmd.CommandType = CommandType.StoredProcedure;

        }

        public DataSet GetAllAttendance()
        {
            cmd.CommandText = "GetAllAttendance";
            return DBAccess.QueryData(cmd);
        }

        public bool InsertAttendance(int EmployeeId, DateTime SignInTime, DateTime SignOutTime)
        {
            cmd.CommandText = "InsertAttendance";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@EmployeeId",EmployeeId) ,
               new SqlParameter("@SignInTime",SignInTime) ,
               new SqlParameter("@SignOutTime",SignOutTime)
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeleteAttendance(string AttendanceId)
        {
            cmd.CommandText = "DeleteAttendance";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@AttendanceID", SqlDbType.Int).Value = AttendanceId;
            int i = DBAccess.ExecuteSQL(cmd);
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool UpdateAttendance(int Attendanceid,int EmployeeId, DateTime SignInTime, DateTime SignOutTime)
        {
            cmd.CommandText = "UpdateAttendanceInfo";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@AttendanceID",Attendanceid) ,
               new SqlParameter("@EmployeeId",EmployeeId) ,
               new SqlParameter("@SignInTime",SignInTime) ,
               new SqlParameter("@SignOutTime",SignOutTime)
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Attendance> GetAll()
        {
            cmd.CommandText = "GetAllAttendance";
            cmd.Parameters.Clear();
            var list = new List<Attendance>();
            var data = DBAccess.ReadData(cmd);
            while (data.Read())
            {
                var e = new Attendance();
                e.AttendanceId = Convert.ToInt32(data["AttendanceId"]);
                e.EmployeeId = Convert.ToInt32(data["EmployeeId"]);
                e.SignInTime = Convert.ToDateTime(data["SignInTime"]);
                e.SignOutTime = Convert.ToDateTime(data["SignOutTime"]);            
                list.Add(e);
            }
            data.Close();
            return list;
        }
    }
}

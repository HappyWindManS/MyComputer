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
    public class EmployeeBLL
    {
        private SqlCommand cmd;
        public EmployeeBLL()
        {
            cmd = new SqlCommand();
            //指定SQL命令为执行存储过程
            cmd.CommandType = CommandType.StoredProcedure;

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Employeeid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string EmployeeName, string password)
        {
            cmd.CommandText = "EmployeeLogin";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeName", SqlDbType.Char, 10).Value = EmployeeName;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 20).Value = password;
            var ds = DBAccess.QueryData(cmd);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }

        public DataSet GetAllEmployee()
        {
            cmd.CommandText = "GetAllEmployee";
            return DBAccess.QueryData(cmd);
        }

        public bool InsertEmployee(string Name, string PassWord,
          bool Sex, int Age, string Position, DateTime Birthday, string BriefDescription)
        {
            cmd.CommandText = "InsertEmployee";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@Name",Name) ,
               new SqlParameter("@Password",PassWord) ,
               new SqlParameter("@Sex",Sex) ,
               new SqlParameter("@Age",Age) ,
               new SqlParameter("@Position",Position) ,
               new SqlParameter("@Birthday",Birthday) ,
               new SqlParameter("@BriefDescription",BriefDescription)};
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeleteEmployee(string EmployeeId)
        {
            cmd.CommandText = "DeleteEmployee";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeId;
            int i = DBAccess.ExecuteSQL(cmd);
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool UpdateEmployee(int Employeeid,string Name, string PassWord,
          bool Sex, int Age, string Position, DateTime Birthday,string BriefDescription)
        {
            cmd.CommandText = "UpdateEmployeeInfo";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@EmployeeID",Employeeid) ,
               new SqlParameter("@Name",Name) ,
               new SqlParameter("@Password",PassWord) ,
               new SqlParameter("@Sex",Sex) ,
               new SqlParameter("@Age",Age) ,
               new SqlParameter("@Position",Position) ,
               new SqlParameter("@Birthday",Birthday) ,
               new SqlParameter("@BriefDescription",BriefDescription)};
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}

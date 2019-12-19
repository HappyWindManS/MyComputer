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
    public class MeetingBLL
    {
        private SqlCommand cmd;
        public MeetingBLL()
        {
            cmd = new SqlCommand();
            //指定SQL命令为执行存储过程
            cmd.CommandType = CommandType.StoredProcedure;

        }

        public DataSet GetAllMeeting()
        {
            cmd.CommandText = "GetAllMeeting";
            return DBAccess.QueryData(cmd);
        }

        public bool InsertMeeting(DateTime MeetingTime, string Registrat,string BriefDescription)
        {
            cmd.CommandText = "InsertMeeting";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@MeetingTime",MeetingTime) ,
               new SqlParameter("@Registrat",Registrat) ,
               new SqlParameter("@BriefDescription",BriefDescription)
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeleteMeeting(string MeetingId)
        {
            cmd.CommandText = "DeleteMeeting";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@MeetingID", SqlDbType.Int).Value = MeetingId;
            int i = DBAccess.ExecuteSQL(cmd);
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool UpdateMeeting(int Meetingid, DateTime MeetingTime, string Registrat, string BriefDescription)
        {
            cmd.CommandText = "UpdateMeetingInfo";
            cmd.Parameters.Clear();
            //定义参数数组对存储过程参数进行赋值
            SqlParameter[] parms = new SqlParameter[]{
               new SqlParameter("@MeetingID",Meetingid) ,
               new SqlParameter("@MeetingTime",MeetingTime) ,
               new SqlParameter("@Registrat",Registrat) ,
               new SqlParameter("@BriefDescription",BriefDescription)
            };
            cmd.Parameters.AddRange(parms);
            var result = DBAccess.ExecuteSQL(cmd);
            if (result > 0)
                return true;
            else
                return false;
        }
        public List<Meeting> GetAll()
        {
            cmd.CommandText = "GetAllMeeting";
            cmd.Parameters.Clear();
            var list = new List<Meeting>();
            var data = DBAccess.ReadData(cmd);
            while (data.Read())
            {
                var e = new Meeting();
                e.MeetingTime = Convert.ToDateTime(data["BorrowDate"]);
                e.BriefDescription = Convert.ToString(data["BriefDescription"]);
                e.MeetingId = Convert.ToInt32(data["MeetingId"]);
                e.Registrar = Convert.ToString(data["Registrar"]);
                list.Add(e);
            }
            data.Close();
            return list;
        }
    }
}

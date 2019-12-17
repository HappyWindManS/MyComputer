using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// 执行SQL语句（SqlCommand命令）
    /// </summary>
    public class DBAccess
    {
        private static readonly string SqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ToString();
        /// <summary>
        /// 执行增删改等返回受影响行数的公共方法
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static int ExecuteSQL(SqlCommand cmd)
        {
            var conn = new SqlConnection(SqlConnectionString);
            cmd.Connection = conn;
            try
            {
                conn.Open();
                var Result = cmd.ExecuteNonQuery();
                return Result;
            }
            catch (Exception ex)
            {
                throw new DBException(ex);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        /// <summary>
        /// 执行查询结果为记录集的方法
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static DataSet QueryData(SqlCommand cmd)
        {
            var conn = new SqlConnection(SqlConnectionString);
            cmd.Connection = conn;
            var ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                sda.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new DBException(ex);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return ds;
        }

        /// <summary>
        /// 执行返回单行单列的sql命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static object GetScalar(SqlCommand cmd)
        {
            var conn = new SqlConnection(SqlConnectionString);
            cmd.Connection = conn;
            var obj = new object();
            try
            {
                conn.Open();
                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DBException(ex);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return obj;
        }

        /// <summary>
        /// 执行查询命令，读取查询的结果记录
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static SqlDataReader ReadData(SqlCommand cmd)
        {
            var conn = new SqlConnection(SqlConnectionString);
            cmd.Connection = conn;
            SqlDataReader read;
            try
            {
                conn.Open();
                read = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return read;
            }
            catch (Exception ex)
            {
                throw new DBException(ex);
            } 
        }
    }
}

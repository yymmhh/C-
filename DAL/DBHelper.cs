using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace MySchool.Dal
{
	public static class DBHelper
	{
		//链接字符串
		private static readonly string CONN_STR = ConfigurationManager.ConnectionStrings["con"].ToString();

		public static DataTable ExcuteDateSet(string sql,params SqlParameter [] sqlps)
		{
			using (SqlConnection conn = new SqlConnection(CONN_STR))
			{
				try
				{
				
					SqlCommand cmd = new SqlCommand(sql,conn);

					cmd.Parameters.AddRange(sqlps);
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataSet set = new DataSet();
					adapter.Fill(set);
					return set.Tables[0];
				}
				catch (Exception ex)
				{
                    	
					throw;
                }

			}
		}

	
		/// <summary>
		/// 返回读取器的方法
		/// </summary>
		/// <param name="sql"></param>
		/// <returns></returns>
		

		public static object ExcuteScalar(string sql)
		{
			using (SqlConnection conn = new SqlConnection(CONN_STR))
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(sql, conn);
					return cmd.ExecuteScalar();
				}
				catch (Exception)
				{
					return null;
				}
			}
		}

		/// <summary>
		/// 增删改查得通用方法
		/// （没有事务功能）
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="cmdType"></param>
		/// <param name="pes"></param>
		/// <returns></returns>
		public static int ExcuteNonQuery(string sql,params SqlParameter[] pes)
		{
			using (SqlConnection conn = new SqlConnection(CONN_STR))
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand(sql, conn);
				
				cmd.Parameters.AddRange(pes);
				
				//将命令器执行类型更改存储过程(默认是sql）
			
				return cmd.ExecuteNonQuery();
			}
		}

		/// <summary>
		/// 增删改查的通用方法
		/// (带事务功能)
		/// </summary>
		/// <param name="sql"></param>
		/// <returns></returns>
		public static int ExcuteNonQueryByTrans(string sql,params MySqlParameter [] sqlps)
		{
			int rows = 0;
			using (SqlConnection conn = new SqlConnection(CONN_STR))
			{
				
				SqlCommand cmd = new SqlCommand(sql, conn);
				
					conn.Open();
				
					
					return cmd.ExecuteNonQuery();
					
				
				
			}
		}
	}
}

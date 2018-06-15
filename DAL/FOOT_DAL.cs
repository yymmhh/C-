using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;
using MySchool.Dal;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
public	class FOOT_DAL
	{

	/// <summary>
	/// 主要的查询
	/// </summary>
	/// <param name="name"></param>
	/// <param name="type"></param>
	/// <param name="people"></param>
	/// <returns></returns>
	public List<Super> GetDB(string name,string count,string people){
		//这是试图查询 
		string sql = "SELECT * FROM view_cha where 1=1  ";
		//试图的SQL语句
//            SELECT COUNT, n2.teamname AS zhu,n1.teamname AS ke,competitiontime,competitionposition,score,entryperson
//  FROM scheduleinfo INNER JOIN teaminfo n2
// ON  scheduleinfo.hostteamid = n2.id
//INNER JOIN teaminfo n1  ON scheduleinfo.awayteamid = n1.id

// WHERE 1 = 1


        List<SqlParameter> sqlps=new List<SqlParameter>();
		

		//对于多个参数的判断
		if (!string.IsNullOrWhiteSpace(name))
		{
			sql += "  AND zhu like '%'+@name+'%'";
			sqlps.Add(new SqlParameter("@name", name));

		}

		if (!string.IsNullOrWhiteSpace(count))
		{
			sql += "  and COUNT=@count";
			sqlps.Add(new SqlParameter("@count",count));
		}

		
		if (!string.IsNullOrWhiteSpace(people))
		{
			sql += "  and author like '%'+@author+'%'";
			sqlps.Add(new SqlParameter("@author", people));
		}

		DataTable dt = DBHelper.ExcuteDateSet(sql, sqlps.ToArray());
		List<Super> list = new List<Super>();

		try
		{
			foreach (DataRow item in dt.Rows)
			{

				Super info = new Super();
				info.count = Convert.ToInt32(item["count"].ToString());
				info.zhu = item["zhu"].ToString();
				info.ke = item["ke"].ToString();
				info.competitiontime = item["competitiontime"].ToString();
				info.competitionposition = item["competitionposition"].ToString();
				info.score = item["score"].ToString();
				info.entryperson = item["entryperson"].ToString();
				

				list.Add(info);



			}
		}
		catch (Exception)
		{
			
			throw;
		}
	


		return list;



	}

	/// <summary>
	/// 新增
	/// </summary>
	/// <param name="su"></param>
	/// <returns></returns>
        public int FootAdd(Super su)
        {
            string sql = @"INSERT INTO scheduleinfo
            (
             count,
            hostteamid,
             awayteamid,
             competitiontime,
             competitionposition,
             score,
             entryperson,
             entrytime)
VALUES(
        @count,
        @hostteamid,
        @awayteamid,
        @competitiontime,
        @competitionposition,
        @score,
        @entryperson,
        @entrytime)";

            SqlParameter[] sqlps = new SqlParameter[8];
            sqlps[0] = new SqlParameter("@count", su.count);
            sqlps[1] = new SqlParameter("@hostteamid", su.hostteamid);
            sqlps[2] = new SqlParameter("@awayteamid", su.awayteamid);
            sqlps[3] = new SqlParameter("@competitiontime", su.competitiontime);
            sqlps[4] = new SqlParameter("@competitionposition", su.competitionposition);
            sqlps[5] = new SqlParameter("@score", su.score);
            sqlps[6] = new SqlParameter("@entryperson", su.entryperson);
            sqlps[7] = new SqlParameter("@entrytime", su.entrytime);

            return DBHelper.ExcuteNonQuery(sql,sqlps);


        }

	/// <summary>
	/// 查询combox
	/// </summary>
	/// <returns></returns>
        public List<teaminfo> GetCBO()
        {
            string sql= "SELECT* FROM teaminfo";
             DataTable dt= DBHelper.ExcuteDateSet(sql);
            List<teaminfo> list = new List<teaminfo>();

            foreach (DataRow item in dt.Rows)
            {

                teaminfo info = new teaminfo();
                info.id = Convert.ToInt32(item["id"].ToString());
                info.teamname = item["teamname"].ToString();
              

                list.Add(info);



            }
            return list;
        }
	//删除
		public int Delete(string count)
		{
			string sql = "delete  dbo.scheduleinfo where COUNT=@count";
			SqlParameter [] sqlps = new SqlParameter[1];
			sqlps[0] = new SqlParameter("@count",count);
			return DBHelper.ExcuteNonQuery(sql,sqlps);
		}

	//修改
		public int update(Super su)
		{
			string sql = @"update  scheduleinfo  set competitiontime=@competitiontime,competitionposition=@competitionposition,score=@score,entryperson=@entryperson
,hostteamid=@hostteamid,awayteamid=@awayteamid
   where count=@count";
			SqlParameter[] sqlps = new SqlParameter[7];
			sqlps[0] = new SqlParameter("@competitiontime",su.competitiontime.ToString());
			sqlps[1] = new SqlParameter("@competitionposition",su.competitionposition);
			sqlps[2] = new SqlParameter("@score", su.score);
			sqlps[3] = new SqlParameter("@entryperson", su.entryperson);
			sqlps[4] = new SqlParameter("@count", su.count);
			sqlps[5] = new SqlParameter("@hostteamid", su.hostteamid);
			sqlps[6] = new SqlParameter("@awayteamid", su.awayteamid);
			return DBHelper.ExcuteNonQuery(sql,sqlps);
		}




	


	

	}
}

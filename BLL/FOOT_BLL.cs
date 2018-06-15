using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
	public class FOOT_BLL
	{
		 FOOT_DAL dao = new FOOT_DAL();
		public List<Super> GetDB(string title, string count, string people)
		{
			return dao.GetDB(title,count,"");

		}
        public int FootAdd(Super su)
        {
            return dao.FootAdd(su);
        }


        public List<teaminfo> GetCBO()
        {
            return dao.GetCBO();
        }

		public int Delete(string count)
		{
			return dao.Delete(count);
		}
		/// <summary>
		///修改
		/// </summary>
		/// <param name="su"></param>
		/// <returns></returns>
		public int update(Super su)
		{
			return dao.update(su);
		}


        }
}

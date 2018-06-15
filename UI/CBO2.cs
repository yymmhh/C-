using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;
namespace Book_UI
{
	public partial class CBO2 : Form
	{
		public CBO2()
		{
			InitializeComponent();
		}

		FOOT_BLL dao = new FOOT_BLL();
		private void CBO2_Load(object sender, EventArgs e)
		{
			//添加一个默认的请选择下标为0
			List<teaminfo> list= dao.GetCBO();
			list.Insert(0, new teaminfo() { id=8,teamname="请选择"});
			cbo.ValueMember = "id";
			cbo.DisplayMember = "teamname";
			this.cbo.DataSource = list;
		}
	}
}

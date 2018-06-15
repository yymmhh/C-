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
	public partial class Show : Form
	{
		public Show()
		{
			InitializeComponent();
		}
		FOOT_BLL dao = new FOOT_BLL();
		private void Show_Load(object sender, EventArgs e)
		{
			findAll("");
		}

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            findAll(name);
            
        }


        public void findAll(string name)
        {
            this.dgv.DataSource=new BindingList<Super>(dao.GetDB(name,"",""));
        }

		private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//获取场次的id
			string count = dgv.SelectedRows[0].Cells[2].Value.ToString();
			
			int i= dao.Delete(count);
			if (i > 0)
			{
				MessageBox.Show("删除成功!");
				findAll("");
			}
			else
			{
				MessageBox.Show("删除失败!");
			}
		}

		private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//跳转到修改页面,并且把类型赋值
			string count = dgv.SelectedRows[0].Cells[2].Value.ToString();
			DD frm = new DD();
			frm.type = "修改";
			frm.count = count;
			

			frm.Show();
		}
    }
}

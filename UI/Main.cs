using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_UI
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void 赛程查询ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			Show frm = new Show();
			frm.MdiParent = this;
			frm.Show();
		}

        private void 赛程添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DD frm = new DD();
			frm.type = "添加";
			
            frm.MdiParent = this;
            frm.Show();
        }

		private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void cBOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CBO2 frm = new CBO2();
			frm.Show();
		}
    }
}

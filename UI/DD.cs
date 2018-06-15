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
	public partial class DD : Form
	{
		public DD()
		{
			InitializeComponent();
		}
		public FOOT_BLL dao = new FOOT_BLL();


		//提交按钮
		private void btnGO_Click(object sender, EventArgs e)
		{

			if (type.Equals("添加"))
			{
				//如果在提交的情况下,按下,先循环判断
				foreach (Control item in this.Controls)
				{
					if (item is TextBox || item is ComboBox)
					{
						if (string.IsNullOrWhiteSpace(item.Text))
						{
							//获取Tag的隐藏值
							string zhi = item.Tag.ToString();
							//弹出
							MessageBox.Show("请输入" + zhi + "信息!");
							//鼠标指针到达
							item.Focus();
							//文本框背景颜色
							item.BackColor = System.Drawing.Color.Red;
							return;
						}
						else
						{
							//背景颜色再改回来
							item.BackColor = System.Drawing.Color.White;
						}

					}

				}

				//两个cbo实际值得判断
				if (cbozhu.SelectedValue.Equals(cboke.SelectedValue))
				{
					MessageBox.Show("主队和客队不能是同一个队伍!");
					return;
				}
				//获取值
				string count = txtcount.Text;
				string zhu = cbozhu.SelectedValue.ToString();
				string ke = cboke.SelectedValue.ToString();
				string time = dtp.Value.ToString();
				string at = txtat.Text;
				string score = txtscore.Text;
				string poeple = txtpeople.Text;
				Super su = new Super();
				//对象添加
				su.count = int.Parse(count);
				su.hostteamid = int.Parse(zhu);
				su.awayteamid = int.Parse(ke);
				su.competitiontime = time;
				su.competitionposition = at;
				su.score=score;
				su.entryperson = poeple;
				su.entrytime = "2000-8-8";
				int i = dao.FootAdd(su);
				if (i > 0)
				{
					MessageBox.Show("OK");
				}
				else
				{
					MessageBox.Show("ERROR");
				}
			}
			else if (type.Equals("修改"))
			{
				//如果是修改的提交
				string count1 = txtcount.Text;

				string zhu = cbozhu.SelectedValue.ToString();
				string ke = cboke.SelectedValue.ToString();
				string time = dtp.Value.ToString();
				string at = txtat.Text;
				string score = txtscore.Text;
				string poeple = txtpeople.Text;
				Super su = new Super();
				su.hostteamid = int.Parse(cbozhu.SelectedValue.ToString());
				su.awayteamid = int.Parse(cboke.SelectedValue.ToString());
				su.count = int.Parse(count1);
				su.hostteamid = int.Parse(zhu);
				su.awayteamid = int.Parse(ke);
				su.competitiontime = time;
				su.competitionposition = at;
				su.score = score;
				su.entryperson = poeple;
				su.entrytime = "2000-8-8";

				//获取文本框里面的值,给个对象,然后扔给下面
				int i = dao.update(su);
				if (i > 0)
				{
					MessageBox.Show("修改成功！");
					this.Close();
				}
				else
				{
					MessageBox.Show("修改失败！");
				}



			}


		}

		//加载Combox
		//窗体加载接收是什么，是修改还是添加，还有场次
		public string type;
		public string count;
		private void DD_Load(object sender, EventArgs e)
		{
			//加载主队和客队
			List<teaminfo> list2 = dao.GetCBO();
			cbozhu.ValueMember = "id";
			cbozhu.DisplayMember = "teamname";
			cboke.ValueMember = "id";
			cboke.DisplayMember = "teamname";
			this.cboke.DataSource = new BindingList<teaminfo>(list2);
			this.cbozhu.DataSource = new BindingList<teaminfo>(list2);
			this.Text = type;
			if (type.Equals("修改"))
			{
				//如何是修改的话
				//禁用场次txt
				txtcount.Enabled = false;

				btnGO.Text = "确认修改";
				//首先得到所有的场次信息
				//根据场次查询信息,返回的是一个场次的信息
				List<Super> list1 = dao.GetDB("", count, "");
				//因为这个list就只有一个对象,就获取第一个
				Super info = list1[0];
				//给文本框赋值
				txtcount.Text = info.count.ToString();
				txtpeople.Text = info.entryperson;
				txtscore.Text = info.score;
				txtat.Text = info.competitionposition;
				dtp.Value = Convert.ToDateTime(info.competitiontime.ToString());
				//获取Combox的信息
				List<teaminfo> list = dao.GetCBO();
				//获取主队的名字和客队的名字
				string zhu = info.zhu;
				string ke = info.ke;
				//定义主队客队的ID
				int zhuindex = 0;
				int keindex = 0;
				foreach (teaminfo item in list)
				{
					//循环找到这些队名的ID
					if (item.teamname.Equals(zhu))
					{
						zhuindex = item.id;
					}
					if (item.teamname.Equals(ke))
					{
						keindex = item.id;
					}
				}

				//cbozhu.SelectedIndex = (zhuindex-1);
				//cboke.SelectedIndex = (keindex-1);
				//给CBO的实际的值给值
				cbozhu.SelectedValue = zhuindex;
				cboke.SelectedValue = keindex;



			}
			else if (type.Equals("添加"))
			{

			}


		}

		private void cbozhu_SelectedIndexChanged(object sender, EventArgs e)
		{
			//主队节点的改变事件
			//先获取所有的队伍
			List<teaminfo> list = dao.GetCBO();
			
			//获取主队选中的下标
			string zhi = cbozhu.SelectedIndex.ToString();

			//然后在客队中删除这个下标
			list.RemoveAt(int.Parse(zhi));
			//客队CBO重新绑定
			this.cboke.DataSource = new BindingList<teaminfo>(list);

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			//循环清空
			foreach (Control item in this.Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";
				}

			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

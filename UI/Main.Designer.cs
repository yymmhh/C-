namespace Book_UI
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.球队管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.赛程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.赛程添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.赛程查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cBOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.球队管理ToolStripMenuItem,
            this.赛程管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem,
            this.cBOToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(411, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 球队管理ToolStripMenuItem
			// 
			this.球队管理ToolStripMenuItem.Name = "球队管理ToolStripMenuItem";
			this.球队管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.球队管理ToolStripMenuItem.Text = "球队管理";
			// 
			// 赛程管理ToolStripMenuItem
			// 
			this.赛程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.赛程添加ToolStripMenuItem,
            this.赛程查询ToolStripMenuItem});
			this.赛程管理ToolStripMenuItem.Name = "赛程管理ToolStripMenuItem";
			this.赛程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.赛程管理ToolStripMenuItem.Text = "赛程管理";
			// 
			// 赛程添加ToolStripMenuItem
			// 
			this.赛程添加ToolStripMenuItem.Name = "赛程添加ToolStripMenuItem";
			this.赛程添加ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.赛程添加ToolStripMenuItem.Text = "赛程添加";
			this.赛程添加ToolStripMenuItem.Click += new System.EventHandler(this.赛程添加ToolStripMenuItem_Click);
			// 
			// 赛程查询ToolStripMenuItem
			// 
			this.赛程查询ToolStripMenuItem.Name = "赛程查询ToolStripMenuItem";
			this.赛程查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.赛程查询ToolStripMenuItem.Text = "赛程查询";
			this.赛程查询ToolStripMenuItem.Click += new System.EventHandler(this.赛程查询ToolStripMenuItem_Click);
			// 
			// 退出系统ToolStripMenuItem
			// 
			this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
			this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.退出系统ToolStripMenuItem.Text = "退出系统";
			this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
			// 
			// cBOToolStripMenuItem
			// 
			this.cBOToolStripMenuItem.Name = "cBOToolStripMenuItem";
			this.cBOToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
			this.cBOToolStripMenuItem.Text = "CBO";
			this.cBOToolStripMenuItem.Click += new System.EventHandler(this.cBOToolStripMenuItem_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 399);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "2014";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 球队管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 赛程管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 赛程添加ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 赛程查询ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cBOToolStripMenuItem;
	}
}
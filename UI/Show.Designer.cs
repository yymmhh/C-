namespace Book_UI
{
	partial class Show
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
			this.components = new System.ComponentModel.Container();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dgv.ContextMenuStrip = this.contextMenuStrip1;
			this.dgv.Location = new System.Drawing.Point(0, 80);
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.RowTemplate.Height = 23;
			this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv.Size = new System.Drawing.Size(1030, 502);
			this.dgv.TabIndex = 0;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "count";
			this.Column7.HeaderText = "场次";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "zhu";
			this.Column1.HeaderText = "主队";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "ke";
			this.Column2.HeaderText = "客队";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "competitiontime";
			this.Column3.HeaderText = "比赛时间";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "competitionposition";
			this.Column4.HeaderText = "比赛地点";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "score";
			this.Column5.HeaderText = "最终比分";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "entryperson";
			this.Column6.HeaderText = "录入人";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
			// 
			// 删除ToolStripMenuItem
			// 
			this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
			this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.删除ToolStripMenuItem.Text = "删除";
			this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
			// 
			// 修改ToolStripMenuItem
			// 
			this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
			this.修改ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.修改ToolStripMenuItem.Text = "修改";
			this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "主队名称";
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(130, 25);
			this.txtname.Margin = new System.Windows.Forms.Padding(2);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(225, 21);
			this.txtname.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(421, 24);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "搜索";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Show
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 583);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgv);
			this.Name = "Show";
			this.Text = "中超联赛";
			this.Load += new System.EventHandler(this.Show_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
namespace Book_UI
{
    partial class DD
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
			this.dtp = new System.Windows.Forms.DateTimePicker();
			this.cboke = new System.Windows.Forms.ComboBox();
			this.cbozhu = new System.Windows.Forms.ComboBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnGO = new System.Windows.Forms.Button();
			this.txtpeople = new System.Windows.Forms.TextBox();
			this.txtscore = new System.Windows.Forms.TextBox();
			this.txtat = new System.Windows.Forms.TextBox();
			this.txtcount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dtp
			// 
			this.dtp.Location = new System.Drawing.Point(153, 270);
			this.dtp.Margin = new System.Windows.Forms.Padding(2);
			this.dtp.Name = "dtp";
			this.dtp.Size = new System.Drawing.Size(104, 21);
			this.dtp.TabIndex = 21;
			// 
			// cboke
			// 
			this.cboke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboke.FormattingEnabled = true;
			this.cboke.Location = new System.Drawing.Point(359, 179);
			this.cboke.Margin = new System.Windows.Forms.Padding(2);
			this.cboke.Name = "cboke";
			this.cboke.Size = new System.Drawing.Size(100, 20);
			this.cboke.TabIndex = 20;
			this.cboke.Tag = "客队";
			// 
			// cbozhu
			// 
			this.cbozhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbozhu.FormattingEnabled = true;
			this.cbozhu.Location = new System.Drawing.Point(153, 182);
			this.cbozhu.Margin = new System.Windows.Forms.Padding(2);
			this.cbozhu.Name = "cbozhu";
			this.cbozhu.Size = new System.Drawing.Size(104, 20);
			this.cbozhu.TabIndex = 19;
			this.cbozhu.Tag = "主队";
			this.cbozhu.SelectedIndexChanged += new System.EventHandler(this.cbozhu_SelectedIndexChanged);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(349, 473);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 26);
			this.btnExit.TabIndex = 18;
			this.btnExit.Text = "关闭";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(233, 473);
			this.btnClear.Margin = new System.Windows.Forms.Padding(2);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(64, 26);
			this.btnClear.TabIndex = 17;
			this.btnClear.Text = "全部清空";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnGO
			// 
			this.btnGO.Location = new System.Drawing.Point(114, 473);
			this.btnGO.Margin = new System.Windows.Forms.Padding(2);
			this.btnGO.Name = "btnGO";
			this.btnGO.Size = new System.Drawing.Size(66, 26);
			this.btnGO.TabIndex = 16;
			this.btnGO.Text = "提交";
			this.btnGO.UseVisualStyleBackColor = true;
			this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
			// 
			// txtpeople
			// 
			this.txtpeople.Location = new System.Drawing.Point(359, 353);
			this.txtpeople.Margin = new System.Windows.Forms.Padding(2);
			this.txtpeople.Name = "txtpeople";
			this.txtpeople.Size = new System.Drawing.Size(92, 21);
			this.txtpeople.TabIndex = 14;
			this.txtpeople.Tag = "录入人";
			// 
			// txtscore
			// 
			this.txtscore.Location = new System.Drawing.Point(153, 350);
			this.txtscore.Margin = new System.Windows.Forms.Padding(2);
			this.txtscore.Name = "txtscore";
			this.txtscore.Size = new System.Drawing.Size(104, 21);
			this.txtscore.TabIndex = 15;
			this.txtscore.Tag = "最终得分";
			// 
			// txtat
			// 
			this.txtat.Location = new System.Drawing.Point(359, 273);
			this.txtat.Margin = new System.Windows.Forms.Padding(2);
			this.txtat.Name = "txtat";
			this.txtat.Size = new System.Drawing.Size(92, 21);
			this.txtat.TabIndex = 13;
			this.txtat.Tag = "比赛地点";
			// 
			// txtcount
			// 
			this.txtcount.BackColor = System.Drawing.SystemColors.Window;
			this.txtcount.ForeColor = System.Drawing.Color.SlateBlue;
			this.txtcount.Location = new System.Drawing.Point(153, 63);
			this.txtcount.Margin = new System.Windows.Forms.Padding(2);
			this.txtcount.Name = "txtcount";
			this.txtcount.Size = new System.Drawing.Size(104, 21);
			this.txtcount.TabIndex = 12;
			this.txtcount.Tag = "场次";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(278, 182);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "客队";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(278, 352);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 12);
			this.label7.TabIndex = 9;
			this.label7.Text = "录入人";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(86, 350);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 8;
			this.label6.Text = "最终比分";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(278, 278);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 7;
			this.label5.Text = "比赛地点";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(86, 275);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "比赛时间";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 182);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "主队";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(86, 66);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "场次";
			// 
			// DD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 562);
			this.Controls.Add(this.dtp);
			this.Controls.Add(this.cboke);
			this.Controls.Add(this.cbozhu);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnGO);
			this.Controls.Add(this.txtpeople);
			this.Controls.Add(this.txtscore);
			this.Controls.Add(this.txtat);
			this.Controls.Add(this.txtcount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "DD";
			this.Text = "添加场次";
			this.Load += new System.EventHandler(this.DD_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cboke;
        private System.Windows.Forms.ComboBox cbozhu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txtpeople;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.TextBox txtat;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace Book_UI
{
	partial class CBO2
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
			this.cbo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cbo
			// 
			this.cbo.FormattingEnabled = true;
			this.cbo.Location = new System.Drawing.Point(141, 68);
			this.cbo.Name = "cbo";
			this.cbo.Size = new System.Drawing.Size(121, 20);
			this.cbo.TabIndex = 0;
			// 
			// CBO2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 441);
			this.Controls.Add(this.cbo);
			this.Name = "CBO2";
			this.Text = "CBO2";
			this.Load += new System.EventHandler(this.CBO2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbo;
	}
}
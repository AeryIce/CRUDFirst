namespace CRUDFirst
{
	partial class FormHome
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonReport = new System.Windows.Forms.Button();
			this.buttonHome = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonMinimize = new System.Windows.Forms.Button();
			this.buttonMaximize = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panelReporting = new System.Windows.Forms.Panel();
			this.buttonReportingCafe = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelReporting.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Red;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.Controls.Add(this.buttonReport);
			this.panel1.Controls.Add(this.buttonHome);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(127, 396);
			this.panel1.TabIndex = 0;
			// 
			// buttonReport
			// 
			this.buttonReport.BackColor = System.Drawing.Color.Transparent;
			this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonReport.Image = global::CRUDFirst.Properties.Resources.graph_32px;
			this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonReport.Location = new System.Drawing.Point(12, 86);
			this.buttonReport.Name = "buttonReport";
			this.buttonReport.Size = new System.Drawing.Size(98, 36);
			this.buttonReport.TabIndex = 7;
			this.buttonReport.Text = "Report";
			this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonReport.UseVisualStyleBackColor = false;
			this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
			this.buttonReport.MouseEnter += new System.EventHandler(this.buttonReport_Click);
			// 
			// buttonHome
			// 
			this.buttonHome.BackColor = System.Drawing.Color.Transparent;
			this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHome.Image = global::CRUDFirst.Properties.Resources.home_32px;
			this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonHome.Location = new System.Drawing.Point(12, 44);
			this.buttonHome.Name = "buttonHome";
			this.buttonHome.Size = new System.Drawing.Size(98, 36);
			this.buttonHome.TabIndex = 6;
			this.buttonHome.Text = "Home";
			this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonHome.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Red;
			this.panel2.Controls.Add(this.buttonMinimize);
			this.panel2.Controls.Add(this.buttonMaximize);
			this.panel2.Controls.Add(this.buttonExit);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(127, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(831, 28);
			this.panel2.TabIndex = 1;
			// 
			// buttonMinimize
			// 
			this.buttonMinimize.BackColor = System.Drawing.Color.Red;
			this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMinimize.Image = global::CRUDFirst.Properties.Resources.minimize_window_32px;
			this.buttonMinimize.Location = new System.Drawing.Point(741, 3);
			this.buttonMinimize.Name = "buttonMinimize";
			this.buttonMinimize.Size = new System.Drawing.Size(25, 23);
			this.buttonMinimize.TabIndex = 8;
			this.buttonMinimize.UseVisualStyleBackColor = false;
			// 
			// buttonMaximize
			// 
			this.buttonMaximize.BackColor = System.Drawing.Color.Red;
			this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMaximize.Image = global::CRUDFirst.Properties.Resources.maximize_window_32px;
			this.buttonMaximize.Location = new System.Drawing.Point(772, 3);
			this.buttonMaximize.Name = "buttonMaximize";
			this.buttonMaximize.Size = new System.Drawing.Size(25, 23);
			this.buttonMaximize.TabIndex = 7;
			this.buttonMaximize.UseVisualStyleBackColor = false;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.Red;
			this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.Image = global::CRUDFirst.Properties.Resources.close_window_32px;
			this.buttonExit.Location = new System.Drawing.Point(803, 3);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(25, 22);
			this.buttonExit.TabIndex = 6;
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::CRUDFirst.Properties.Resources.Periplus_Logo;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(821, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(86, 75);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(798, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Periplus Indonesia";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(798, 210);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 65);
			this.label2.TabIndex = 4;
			this.label2.Text = "PT. Periplus Bookindo\r\nJl. Rawa Gelam IV No.9\r\nKawasan Industri Pulogadung\r\nJakar" +
    "ta Timur\r\n\r\n";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bradley Hand ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(836, 374);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "By : AeryIce";
			// 
			// panelReporting
			// 
			this.panelReporting.BackColor = System.Drawing.Color.Transparent;
			this.panelReporting.Controls.Add(this.buttonReportingCafe);
			this.panelReporting.Location = new System.Drawing.Point(127, 86);
			this.panelReporting.Name = "panelReporting";
			this.panelReporting.Size = new System.Drawing.Size(168, 150);
			this.panelReporting.TabIndex = 6;
			// 
			// buttonReportingCafe
			// 
			this.buttonReportingCafe.BackColor = System.Drawing.Color.Tomato;
			this.buttonReportingCafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReportingCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonReportingCafe.Image = global::CRUDFirst.Properties.Resources.food_32px;
			this.buttonReportingCafe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonReportingCafe.Location = new System.Drawing.Point(6, 3);
			this.buttonReportingCafe.Name = "buttonReportingCafe";
			this.buttonReportingCafe.Size = new System.Drawing.Size(87, 36);
			this.buttonReportingCafe.TabIndex = 8;
			this.buttonReportingCafe.Text = "Cafe";
			this.buttonReportingCafe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonReportingCafe.UseVisualStyleBackColor = false;
			// 
			// FormHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::CRUDFirst.Properties.Resources.PeriplusStore;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(958, 396);
			this.Controls.Add(this.panelReporting);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormHome";
			this.Load += new System.EventHandler(this.FormHome_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelReporting.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonHome;
		private System.Windows.Forms.Button buttonReport;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonMinimize;
		private System.Windows.Forms.Button buttonMaximize;
		private System.Windows.Forms.Panel panelReporting;
		private System.Windows.Forms.Button buttonReportingCafe;
	}
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDFirst
{
	public partial class FormHome : Form

	{
		public FormHome()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Close();

		}

		private void buttonReport_Click(object sender, EventArgs e)
		{
			panelReporting.Visible = true;
			buttonReportingCafe.Visible = true;
		}

		private void FormHome_Load(object sender, EventArgs e)
		{
			panelReporting.Visible = false;
		}

		
	}
}

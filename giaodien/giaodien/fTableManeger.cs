using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace giaodien
{
	public partial class fTableManeger : Form
	{
		public fTableManeger()
		{
			InitializeComponent();
		}

		private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();	
		}

		private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			fAccountProfile f = new fAccountProfile();
			f.ShowDialog();
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAdmin f = new fAdmin();
			f.ShowDialog();
		}

		private void txbPriceHotTea_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

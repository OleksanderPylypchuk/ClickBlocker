using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLibrary
{
	public partial class ClickBlocker : UserControl
	{
		public ClickBlocker()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(BTN_PRESSED != null) 
				BTN_PRESSED.Invoke(this, EventArgs.Empty);
			if (TICK_TIME >0)
			{
				timer1.Interval = TICK_TIME * 1000;
				timer1.Start();
				btn.Enabled = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			btn.Enabled = true;
		}
	}
}

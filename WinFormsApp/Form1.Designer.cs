namespace WinFormsApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			clickBlocker2 = new WinFormsControlLibrary.ClickBlocker();
			clickBlocker1 = new WinFormsControlLibrary.ClickBlocker();
			clickBlocker3 = new WinFormsControlLibrary.ClickBlocker();
			clickBlocker4 = new WinFormsControlLibrary.ClickBlocker();
			SuspendLayout();
			// 
			// clickBlocker2
			// 
			clickBlocker2.AutoSize = true;
			clickBlocker2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			clickBlocker2.Location = new Point(6, 12);
			clickBlocker2.Name = "clickBlocker2";
			clickBlocker2.Size = new Size(130, 49);
			clickBlocker2.TabIndex = 0;
			clickBlocker2.TICK_TIME = 4;
			// 
			// clickBlocker1
			// 
			clickBlocker1.AutoSize = true;
			clickBlocker1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			clickBlocker1.Location = new Point(196, 12);
			clickBlocker1.Name = "clickBlocker1";
			clickBlocker1.Size = new Size(130, 49);
			clickBlocker1.TabIndex = 1;
			clickBlocker1.TICK_TIME = 5;
			clickBlocker1.BTN_PRESSED += clickBlocker1_BTN_PRESSED;
			// 
			// clickBlocker3
			// 
			clickBlocker3.AutoSize = true;
			clickBlocker3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			clickBlocker3.Location = new Point(6, 109);
			clickBlocker3.Name = "clickBlocker3";
			clickBlocker3.Size = new Size(130, 49);
			clickBlocker3.TabIndex = 2;
			clickBlocker3.TICK_TIME = 10;
			// 
			// clickBlocker4
			// 
			clickBlocker4.AutoSize = true;
			clickBlocker4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			clickBlocker4.Location = new Point(196, 109);
			clickBlocker4.Name = "clickBlocker4";
			clickBlocker4.Size = new Size(130, 49);
			clickBlocker4.TabIndex = 3;
			clickBlocker4.TICK_TIME = 8;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(331, 163);
			Controls.Add(clickBlocker4);
			Controls.Add(clickBlocker3);
			Controls.Add(clickBlocker1);
			Controls.Add(clickBlocker2);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private WinFormsControlLibrary.ClickBlocker clickBlocker1;
		private WinFormsControlLibrary.ClickBlocker clickBlocker2;
		private WinFormsControlLibrary.ClickBlocker clickBlocker3;
		private WinFormsControlLibrary.ClickBlocker clickBlocker4;
	}
}

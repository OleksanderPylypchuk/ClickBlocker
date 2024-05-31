using System.ComponentModel;

namespace WinFormsControlLibrary
{
	[ToolboxBitmap("D:\\Навчання\\АППЗ\\Lab_1\\WinFormsControlLibrary\\ClickBlocker.ico")]
	partial class ClickBlocker
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		[DisplayName("Ticks(seconds)")]
		public int TICK_TIME { get; set; } = 1;
		public event EventHandler BTN_PRESSED;
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			btn = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// btn
			// 
			btn.Location = new Point(3, 3);
			btn.Name = "btn";
			btn.Size = new Size(124, 43);
			btn.TabIndex = 0;
			btn.Text = "Magic";
			btn.UseVisualStyleBackColor = true;
			btn.Click += button1_Click;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// ClickBlocker
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			Controls.Add(btn);
			Name = "ClickBlocker";
			Size = new Size(130, 49);
			ResumeLayout(false);
		}

		#endregion

		private Button btn;
		private System.Windows.Forms.Timer timer1;
	}
}

namespace LabMcuForm
{
	partial class CMcuFormAVR8BitsFuseAndLockForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.cMcuControlAVR8BitsFuseAndLock1 = new LabMcuForm.CMcuFormAVR8Bits.CMcuFormAVR8BitsFuseAndLockControl();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(47, 437);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cMcuControlAVR8BitsFuseAndLock1
			// 
			this.cMcuControlAVR8BitsFuseAndLock1.Dock = System.Windows.Forms.DockStyle.Top;
			this.cMcuControlAVR8BitsFuseAndLock1.Location = new System.Drawing.Point(0, 0);
			this.cMcuControlAVR8BitsFuseAndLock1.MaximumSize = new System.Drawing.Size(655, 305);
			this.cMcuControlAVR8BitsFuseAndLock1.MinimumSize = new System.Drawing.Size(655, 305);
			this.cMcuControlAVR8BitsFuseAndLock1.Name = "cMcuControlAVR8BitsFuseAndLock1";
			this.cMcuControlAVR8BitsFuseAndLock1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.cMcuControlAVR8BitsFuseAndLock1.Size = new System.Drawing.Size(655, 305);
			this.cMcuControlAVR8BitsFuseAndLock1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(401, 368);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// CMcuFormAVR8BitsFuseAndLockForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 496);
			this.Name = "CMcuFormAVR8BitsFuseAndLockForm";
			this.Text = "Fuse&Lock";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private CMcuFormAVR8Bits.CMcuFormAVR8BitsFuseAndLockControl cMcuControlAVR8BitsFuseAndLock1;
		private System.Windows.Forms.Button button2;
	}
}
namespace LabMcuForm
{
	partial class CMcuFormAVR8BitsFuseAndLock
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
			this.cMcuControlAVR8BitsFuseAndLock1 = new LabMcuForm.CMcuFormAVR8Bits.CMcuControlAVR8BitsFuseAndLock();
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
			// CMcuFormAVR8BitsFuseAndLock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 496);
			this.Controls.Add(this.cMcuControlAVR8BitsFuseAndLock1);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CMcuFormAVR8BitsFuseAndLock";
			this.Text = "Fuse&Lock";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private CMcuFormAVR8Bits.CMcuControlAVR8BitsFuseAndLock cMcuControlAVR8BitsFuseAndLock1;
	}
}
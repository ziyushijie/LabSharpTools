namespace Harry.LabTools.LabComm
{
	partial class CCommSerialFullForm
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
			this.cCommSerialFullControl1 = new Harry.LabTools.LabComm.CCommSerialFullControl();
			this.SuspendLayout();
			// 
			// cCommSerialFullControl1
			// 
			this.cCommSerialFullControl1.Location = new System.Drawing.Point(85, 48);
			this.cCommSerialFullControl1.mCCOMM = null;
			this.cCommSerialFullControl1.mCCommRichTextBox = null;
			this.cCommSerialFullControl1.mIsShowCommParam = true;
			this.cCommSerialFullControl1.Name = "cCommSerialFullControl1";
			this.cCommSerialFullControl1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.cCommSerialFullControl1.Size = new System.Drawing.Size(291, 160);
			this.cCommSerialFullControl1.TabIndex = 0;
			// 
			// CCommSerialFullForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cCommSerialFullControl1);
			this.Name = "CCommSerialFullForm";
			this.Text = "CCommSerialFullForm";
			this.ResumeLayout(false);

		}

		#endregion

		private CCommSerialFullControl cCommSerialFullControl1;
	}
}
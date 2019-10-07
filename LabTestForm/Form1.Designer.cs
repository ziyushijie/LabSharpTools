using System;

namespace LabTestForm
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			GC.SuppressFinalize(this.usedComm);
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.cCommBaseControl1 = new Harry.LabTools.LabComm.CCommBaseControl();
			this.cHexBox1 = new Harry.LabTools.LabHex.CHexBox();
			this.SuspendLayout();
			// 
			// cCommBaseControl1
			// 
			this.cCommBaseControl1.Location = new System.Drawing.Point(12, 12);
			this.cCommBaseControl1.mCCOMM = null;
			this.cCommBaseControl1.mCCommRichTextBox = null;
			this.cCommBaseControl1.mIsShowCommParam = true;
			this.cCommBaseControl1.Name = "cCommBaseControl1";
			this.cCommBaseControl1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.cCommBaseControl1.Size = new System.Drawing.Size(262, 56);
			this.cCommBaseControl1.TabIndex = 2;
			// 
			// cHexBox1
			// 
			this.cHexBox1.BackColor = System.Drawing.Color.White;
			this.cHexBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cHexBox1.Location = new System.Drawing.Point(12, 75);
			this.cHexBox1.m_BackgroundColor = System.Drawing.Color.White;
			this.cHexBox1.m_DataAddrFontColor = System.Drawing.Color.Black;
			this.cHexBox1.m_DataAddrType = Harry.LabTools.LabHex.CHexBox.EncodingType.ANSI;
			this.cHexBox1.m_Font = new System.Drawing.Font("黑体", 12F);
			this.cHexBox1.m_IsNewByte = false;
			this.cHexBox1.m_isShowDifference = false;
			this.cHexBox1.m_OutLineColor = System.Drawing.Color.DarkGray;
			this.cHexBox1.m_OutLineWidth = 2;
			this.cHexBox1.m_ShowXAddr = true;
			this.cHexBox1.m_ShowYAddr = true;
			this.cHexBox1.m_XAddrBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox1.m_XAddrFontColor = System.Drawing.Color.Black;
			this.cHexBox1.m_XAddrHeight = 24;
			this.cHexBox1.m_XAddrShowBits = Harry.LabTools.LabHex.CHexBox.XAddrShowBits.Bit16;
			this.cHexBox1.m_YAddrBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox1.m_YAddrBeginWidth = 32;
			this.cHexBox1.m_YAddrFontColor = System.Drawing.Color.Black;
			this.cHexBox1.m_YAddrShowBits = Harry.LabTools.LabHex.CHexBox.YAddrShowBits.Bit4;
			this.cHexBox1.m_YAddrWidth = 86;
			this.cHexBox1.Name = "cHexBox1";
			this.cHexBox1.Size = new System.Drawing.Size(895, 598);
			this.cHexBox1.TabIndex = 3;
			this.cHexBox1.Text = "cHexBox1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1038, 696);
			this.Controls.Add(this.cHexBox1);
			this.Controls.Add(this.cCommBaseControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion
        private Harry.LabTools.LabComm.CCommBaseControl cCommBaseControl1;
		private Harry.LabTools.LabHex.CHexBox cHexBox1;
	}
}


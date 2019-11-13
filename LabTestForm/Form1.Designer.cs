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
			this.cHexBox1 = new Harry.LabTools.LabHexEdit.CHexBox();
			this.caGauge1 = new Harry.LabTools.LabFuncControl.CAGauge();
			this.cCheckedListBoxEx1 = new Harry.LabTools.LabControlPlus.CCheckedListBoxEx();
			this.cNumericUpDownEx1 = new Harry.LabTools.LabControlPlus.CNumericUpDownEx();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.cPanelEx1 = new Harry.LabTools.LabControlPlus.CPanelEx();
			((System.ComponentModel.ISupportInitialize)(this.cNumericUpDownEx1)).BeginInit();
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
			this.cHexBox1.Location = new System.Drawing.Point(12, 74);
			this.cHexBox1.mExternalLineColor = System.Drawing.Color.DarkGray;
			this.cHexBox1.mExternalLineWidth = 2;
			this.cHexBox1.mFirstRowOffset = 4;
			this.cHexBox1.mFont = new System.Drawing.Font("楷体", 12F);
			this.cHexBox1.mFontBackGroundColor = System.Drawing.Color.White;
			this.cHexBox1.mNewDataChange = false;
			this.cHexBox1.mNowData = new byte[] {
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255))};
			this.cHexBox1.mRowDisplayNum = 16;
			this.cHexBox1.mRowStaffWidth = 8;
			this.cHexBox1.mShowChangeBackGroundColor = System.Drawing.Color.Yellow;
			this.cHexBox1.mShowChangeFlag = false;
			this.cHexBox1.mXScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox1.mXScaleBackGroundRectangleShow = true;
			this.cHexBox1.mXScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox1.mXScaleHeight = 24;
			this.cHexBox1.mXScaleHeightOffset = 2;
			this.cHexBox1.mXScaleShow = true;
			this.cHexBox1.mXScaleShowBit8 = Harry.LabTools.LabHexEdit.CHexBox.XScaleShowBit8.BIT8X16;
			this.cHexBox1.mXScaleStringShow = true;
			this.cHexBox1.mXScaleStringStartWidth = 579;
			this.cHexBox1.mYScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox1.mYScaleBackGroundRectangleShow = true;
			this.cHexBox1.mYScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox1.mYScaleOffsetWidth = 32;
			this.cHexBox1.mYScaleShow = true;
			this.cHexBox1.mYScaleShowBit4 = Harry.LabTools.LabHexEdit.CHexBox.YScaleShowBit4.BIT4X4;
			this.cHexBox1.mYScaleWidth = 86;
			this.cHexBox1.Name = "cHexBox1";
			this.cHexBox1.Size = new System.Drawing.Size(902, 634);
			this.cHexBox1.TabIndex = 3;
			this.cHexBox1.Text = "cHexBox1";
			// 
			// caGauge1
			// 
			this.caGauge1.BaseArcColor = System.Drawing.Color.Gray;
			this.caGauge1.BaseArcRadius = 80;
			this.caGauge1.BaseArcStart = 135;
			this.caGauge1.BaseArcSweep = 270;
			this.caGauge1.BaseArcWidth = 2;
			this.caGauge1.Cap_Idx = ((byte)(1));
			this.caGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
			this.caGauge1.CapPosition = new System.Drawing.Point(10, 10);
			this.caGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
			this.caGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
			this.caGauge1.CapText = "";
			this.caGauge1.Center = new System.Drawing.Point(100, 100);
			this.caGauge1.Location = new System.Drawing.Point(981, 268);
			this.caGauge1.MaxValue = 400F;
			this.caGauge1.MinValue = -100F;
			this.caGauge1.Name = "caGauge1";
			this.caGauge1.NeedleColor1 = Harry.LabTools.LabFuncControl.CAGauge.NeedleColorEnum.Gray;
			this.caGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
			this.caGauge1.NeedleRadius = 80;
			this.caGauge1.NeedleType = 0;
			this.caGauge1.NeedleWidth = 2;
			this.caGauge1.Padding = new System.Windows.Forms.Padding(4);
			this.caGauge1.Range_Idx = ((byte)(4));
			this.caGauge1.RangeColor = System.Drawing.Color.Red;
			this.caGauge1.RangeEnabled = true;
			this.caGauge1.RangeEndValue = 400F;
			this.caGauge1.RangeInnerRadius = 70;
			this.caGauge1.RangeOuterRadius = 80;
			this.caGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red};
			this.caGauge1.RangesEnabled = new bool[] {
        true,
        true,
        true,
        true,
        true};
			this.caGauge1.RangesEndValue = new float[] {
        0F,
        100F,
        200F,
        300F,
        400F};
			this.caGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
			this.caGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
			this.caGauge1.RangesStartValue = new float[] {
        -100F,
        0F,
        100F,
        200F,
        300F};
			this.caGauge1.RangeStartValue = 300F;
			this.caGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.caGauge1.ScaleLinesInterInnerRadius = 73;
			this.caGauge1.ScaleLinesInterOuterRadius = 80;
			this.caGauge1.ScaleLinesInterWidth = 1;
			this.caGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.caGauge1.ScaleLinesMajorInnerRadius = 70;
			this.caGauge1.ScaleLinesMajorOuterRadius = 80;
			this.caGauge1.ScaleLinesMajorStepValue = 50F;
			this.caGauge1.ScaleLinesMajorWidth = 2;
			this.caGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
			this.caGauge1.ScaleLinesMinorInnerRadius = 75;
			this.caGauge1.ScaleLinesMinorNumOf = 9;
			this.caGauge1.ScaleLinesMinorOuterRadius = 80;
			this.caGauge1.ScaleLinesMinorWidth = 1;
			this.caGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
			this.caGauge1.ScaleNumbersFormat = null;
			this.caGauge1.ScaleNumbersRadius = 95;
			this.caGauge1.ScaleNumbersRotation = 0;
			this.caGauge1.ScaleNumbersStartScaleLine = 0;
			this.caGauge1.ScaleNumbersStepScaleLines = 1;
			this.caGauge1.Size = new System.Drawing.Size(209, 167);
			this.caGauge1.TabIndex = 4;
			this.caGauge1.Text = "caGauge1";
			this.caGauge1.Value = 0F;
			// 
			// cCheckedListBoxEx1
			// 
			this.cCheckedListBoxEx1.FormattingEnabled = true;
			this.cCheckedListBoxEx1.Location = new System.Drawing.Point(992, 116);
			this.cCheckedListBoxEx1.Name = "cCheckedListBoxEx1";
			this.cCheckedListBoxEx1.Size = new System.Drawing.Size(150, 84);
			this.cCheckedListBoxEx1.TabIndex = 5;
			// 
			// cNumericUpDownEx1
			// 
			this.cNumericUpDownEx1.Location = new System.Drawing.Point(1033, 497);
			this.cNumericUpDownEx1.Name = "cNumericUpDownEx1";
			this.cNumericUpDownEx1.Size = new System.Drawing.Size(120, 21);
			this.cNumericUpDownEx1.TabIndex = 6;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(1161, 116);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
			this.checkedListBox1.TabIndex = 7;
			// 
			// cPanelEx1
			// 
			this.cPanelEx1.Location = new System.Drawing.Point(954, 544);
			this.cPanelEx1.Name = "cPanelEx1";
			this.cPanelEx1.Size = new System.Drawing.Size(200, 100);
			this.cPanelEx1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1432, 720);
			this.Controls.Add(this.cPanelEx1);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.cNumericUpDownEx1);
			this.Controls.Add(this.cCheckedListBoxEx1);
			this.Controls.Add(this.caGauge1);
			this.Controls.Add(this.cHexBox1);
			this.Controls.Add(this.cCommBaseControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.cNumericUpDownEx1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
        private Harry.LabTools.LabComm.CCommBaseControl cCommBaseControl1;
		private Harry.LabTools.LabHexEdit.CHexBox cHexBox1;
		private Harry.LabTools.LabFuncControl.CAGauge caGauge1;
		private Harry.LabTools.LabControlPlus.CCheckedListBoxEx cCheckedListBoxEx1;
		private Harry.LabTools.LabControlPlus.CNumericUpDownEx cNumericUpDownEx1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private Harry.LabTools.LabControlPlus.CPanelEx cPanelEx1;
	}
}


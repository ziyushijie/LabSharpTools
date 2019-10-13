﻿using Harry.LabTools.LabGenFunc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabHex
{
	/// <summary>
	/// 数据信息
	/// </summary>
	public partial class CHexBox
	{

		#region 绘制数据刻度
		/// <summary>
		/// 绘制数据栏
		/// </summary>
		/// <param name="e"></param>
		private void OnPaintDataScale(PaintEventArgs e)
		{
			if ((this.defaultNowData == null) || (this.defaultNowData.Length == 0))
			{
				return;
			}
			else
			{
				//---获取起始地址点
				Point nowPointA = this.CalcDataScalePoint();
				//---计算字体的宽度
				int fontWidthA = this.FontWidth();
				int fontWidthB = this.FontWidth("0");
				//---计算字体的高度
				int fontHeight = this.FontHeigth();
				//---计算当前控件能够显示的最大行数
				int iMaxRowCount = this.defaultMaxRow;//this.CalcYScaleMaxRow();
				//---计算数据需要显示的行数
				int iTotalRowCount = this.defaultTotalRow;// this.CalcYScaleTotalRow();
				//---数据栏的背景色
				Brush backGroundBrushA = new SolidBrush(this.defaultFontBackGroundColor);
				Brush backGroundBrushB = new SolidBrush(this.defaultFontBackGroundColor);
				//---设置数据栏字体颜色
				Brush fontBrush = new SolidBrush(this.defaultDataFontColor);
				//---设置绘制数据区域的矩形图形
				Rectangle nowRectangleA = new Rectangle();
				Rectangle nowRectangleB = new Rectangle();
				//---设置绘制区域
				Point nowPointB = new Point();
				Point nowPointC = new Point();
				string strMsg = null;
				//---计算数据的偏移
				int dataOffset = this.defaultRowNowNum * this.defaultRowShowNum;
				//---计算数据的高度
				int iHeight = nowPointA.Y+ (fontHeight + this.defaultColStaffWidth)/(this.defaultFirstRowOffset);
				//---界面显示多少列
				for (int ix = this.defaultRowNowNum; ix < this.defaultRowNowNum + iMaxRowCount; ix++)
				{
					//---数据长度超出
					if (iTotalRowCount <= ix)
					{
						break;
					}
					else
					{
						nowPointB.X = nowPointA.X+ this.defaultRowStaffWidth;
						nowPointB.Y = iHeight;
						//---显示字符串
						nowPointC.X = this.defaultXScaleStringStartWidth;
						nowPointC.Y = iHeight;
						//---每行显示多少数据
						for (int iy = dataOffset; iy < dataOffset + this.defaultRowShowNum; iy++)
						{
							if (iy >= this.defaultNowData.Length)
							{
								break;
							}
							//---刷新背景色
							nowRectangleA.X = nowPointB.X;
							nowRectangleA.Y = nowPointB.Y - this.defaultColStaffWidth;
							nowRectangleA.Width = fontWidthA;
							nowRectangleA.Height = fontHeight+this.defaultColStaffWidth;
							//---判断是否通过背景色的进行数据不同的标注
							if ((this.defaultNowData[iy] != this.defaultLastData[iy]) || (this.defaultShowChangeFlag == true))
							{
								backGroundBrushA = new SolidBrush(Color.Yellow);
								e.Graphics.FillRectangle(backGroundBrushA, nowRectangleA);
								backGroundBrushA = new SolidBrush(Color.White);
								this.defaultNewDataChange = true;
							}
							else
							{
								e.Graphics.FillRectangle(backGroundBrushA, nowRectangleA);
							}

							//---显示数据字符串信息
							strMsg = this.defaultNowData[iy].ToString("X2");
							e.Graphics.DrawString(strMsg, this.defaultFont, fontBrush, nowPointB);
							nowPointB.X += fontWidthA + this.defaultRowStaffWidth;
							
							//---绘制字符串信息
							if (this.defaultXScaleStringShow)
							{

								nowRectangleB.X = nowPointC.X;
								nowRectangleB.Y = nowPointC.Y - this.defaultColStaffWidth;
								nowRectangleB.Width = fontWidthB;
								nowRectangleB.Height = fontHeight+ this.defaultColStaffWidth;
								if (this.defaultNowData[iy] == 0xFF)
								{
									strMsg = "Y";
									e.Graphics.FillRectangle(backGroundBrushB, nowRectangleB);
								}
								else
								{
									strMsg= ".";
									backGroundBrushB = new SolidBrush(Color.Yellow);
									e.Graphics.FillRectangle(backGroundBrushB, nowRectangleB);
									backGroundBrushB = new SolidBrush(Color.White);
								}
								e.Graphics.DrawString(strMsg, this.defaultFont, fontBrush, nowPointC);
								nowPointC.X += fontWidthB;
							}
						}
						//---数据开始的位置
						this.defaultDataStartWidth = (int)nowPointB.X;
						//---数据偏移量
						dataOffset += this.defaultRowShowNum;
						iHeight += fontHeight + this.defaultColStaffWidth;
					}
				}
			}
		}
		#endregion

		#region 数据处理

		/// <summary>
		/// 获取指定位置的数据
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public byte GetData(int pos)
		{
			if (pos > this.defaultNowData.Length)
			{
				return 0;
			}
			else
			{
				return this.defaultNowData[pos];
			}
		}

		/// <summary>
		/// 得到字符串数据
		/// </summary>
		/// <returns></returns>
		public string[] GetData()
		{
			if ((this.defaultNowData == null) || (this.defaultNowData.Length == 0))
			{
				return null;
			}
			else
			{
				List<string> _return = new List<string>();

				for (long i = 0; i < this.defaultNowData.Length; i++)
				{
					_return.Add(this.defaultNowData[i].ToString("X2"));
				}
				return _return.ToArray();
			}
		}

		/// <summary>
		/// 添加数据
		/// </summary>
		/// <param name="length"></param>
		public void AddData(long length)
		{
			//----数据赋初值为0xFF
			CGenFuncMem.GenFuncMemset(ref this.defaultNowData, length, 0xFF);
			CGenFuncMem.GenFuncMemset(ref this.defaultLastData, length, 0xFF);
			this.defaultShowChangeFlag = false;
			this.defaultNewDataChange = false;

			//---判断地址
			if ((length < 0x100))
			{
				this.defaultYScaleShowBit4 = YScaleShowBit4.BIT4X2;
			}
			else if (length < 0x10000)
			{
				this.defaultYScaleShowBit4 = YScaleShowBit4.BIT4X4;
			}
			else if (length <= 0x1000000)
			{
				this.defaultYScaleShowBit4 = YScaleShowBit4.BIT4X6;
			}
			else
			{
				this.defaultYScaleShowBit4 = YScaleShowBit4.BIT4X8;
			}

			//---数据显示的最大行数
			this.defaultTotalRow = this.CalcYScaleTotalRow();
			//---创建并显示光标
			this.OnFindCaret();
			//---滑块指向开始
			this.defaultVScrollBar.Value = 0;
			//---置位当前显示的行号位0
			this.defaultRowNowNum = 0;
			//---显示垂直滚动条
			this.VScrollBarShow();
			//---重新绘制窗体
			this.Invalidate();
		}

		/// <summary>
		/// 添加数据
		/// </summary>
		/// <param name="dat"></param>
		public void AddData(byte[] dat)
		{
			if (dat == null)
			{
				return;
			}
			else
			{
				//---重新置位缓存区的大小
				Array.Resize<byte>(ref this.defaultNowData, dat.Length);
				Array.Resize<byte>(ref this.defaultLastData, dat.Length);
				//---数组拷贝
				Array.Copy(dat, this.defaultNowData, dat.Length);
				Array.Copy(dat, this.defaultLastData, dat.Length);
				//---数据显示的最大行数
				this.defaultTotalRow = this.CalcYScaleTotalRow();
				//---创建并显示光标
				this.OnFindCaret();
				//---滑块指向开始
				this.defaultVScrollBar.Value = 0;
				//---置位当前显示的行号位0
				this.defaultRowNowNum = 0;
				//---显示垂直滚动条
				this.VScrollBarShow();
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// 添加数据
		/// </summary>
		/// <param name="dat"></param>
		/// <param name="isShowDifference"></param>
		public void AddData(byte[] dat, bool isShowDifference)
		{
			if (dat == null)
			{
				return;
			}
			else
			{
				if (this.defaultNowData.Length != dat.Length)
				{
					//---重新置位缓存区的大小
					Array.Resize<byte>(ref this.defaultNowData, dat.Length);
					Array.Resize<byte>(ref this.defaultLastData, dat.Length);
				}

				//---数组拷贝
				Array.Copy(dat, this.defaultNowData, dat.Length);

				//---判断是否显示不同
				if (isShowDifference != true)
				{
					Array.Copy(dat, this.defaultLastData, dat.Length);
					this.defaultShowChangeFlag = true;
				}
				//---数据显示的最大行数
				this.defaultTotalRow = this.CalcYScaleTotalRow();
				//---创建并显示光标
				this.OnFindCaret();
				//---滑块指向开始
				this.defaultVScrollBar.Value = 0;
				//---置位当前显示的行号位0
				this.defaultRowNowNum = 0;
				//---显示垂直滚动条
				this.VScrollBarShow();
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// 添加数据
		/// </summary>
		/// <param name="dat"></param>
		/// <param name="index"></param>
		/// <param name="length"></param>
		public void AddData(byte[] dat, int index, int length)
		{
			//--数据的合法性
			if ((dat == null) || (length > dat.Length))
			{
				return;
			}
			//---数据长度的合法性
			if ((index + length) > this.defaultNowData.Length)
			{
				return;
			}
			//---数据拷贝
			Array.Copy(dat, 0, this.defaultNowData, index, length);
			Array.Copy(this.defaultNowData, this.defaultLastData, this.defaultNowData.Length);
			//---数据显示的最大行数
			this.defaultTotalRow = this.CalcYScaleTotalRow();
			//---查找光标
			this.OnFindCaret();
			//---滑块指向开始
			this.defaultVScrollBar.Value = 0;
			//---置位当前显示的行号位0
			this.defaultRowNowNum = 0;
			//---显示垂直滚动条
			this.VScrollBarShow();
			//重新绘制窗体
			this.Invalidate();
		}

		#endregion

		#region 数据刻度


		/// <summary>
		/// 数据栏的起始位置
		/// </summary>
		/// <returns></returns>
		private Point CalcDataScalePoint()
		{
			int iWidth = 0;
			int iHeight = 0;

			//---判定是否显示X轴刻度
			if (this.defaultXScaleShow)
			{
				iHeight = this.defaultXScaleHeight+this.defaultXScaleHeightOffset - this.defaultExternalLineWidth / 2;
			}
			else
			{
				iHeight = this.defaultExternalLineWidth / 2;
			}
			//---判定是否显示Y轴刻度
			if (this.defaultYScaleShow)
			{
				iWidth = this.defaultYScaleWidth + this.defaultExternalLineWidth / 2;
			}
			else
			{
				iWidth = this.defaultExternalLineWidth / 2;
			}
			//---返回结果
			return new Point(iWidth, iHeight);
		}

		#endregion

	}
}

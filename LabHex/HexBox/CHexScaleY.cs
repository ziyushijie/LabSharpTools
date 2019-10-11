using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabHex
{
	public partial class CHexBox
	{
		
		#region 绘制Y轴刻度
		/// <summary>
		/// 绘制地址框
		/// </summary>
		/// <param name="e"></param>
		private void OnPaintYScale(PaintEventArgs e)
		{
			if ((this.defaultNowData == null) || (this.defaultNowData.Length == 0))
			{
				return;
			}
			else
			{
				//---获取起始点
				Point nowPoint = this.CalcYAddrBeginPosition();

				//---计算当前控件能够显示的最大行数
				int iMaxRowCount = this.CalcShowMaxRowNum();

				//---计算数据需要显示的行数
				int iTotalRowCount = this.CalcMaxRowNum();

				//---计算字体的高度
				int fonHeight = this.FontHeigth();

				//---计算实际起始写的位置
				int fontOffset = 0;

				//---计算字体的大小
				SizeF sizefAdd;
				if (this.defaultYScaleShowBit4 == YScaleShowBit4.BIT4X2)
				{
					sizefAdd = this.FontSize("0x00", this.defaultFont);
				}
				else if (this.defaultYScaleShowBit4 == YScaleShowBit4.BIT4X4)
				{
					sizefAdd = this.FontSize("0x0000", this.defaultFont);
				}
				else if (this.defaultYScaleShowBit4 == YScaleShowBit4.BIT4X6)
				{
					sizefAdd = this.FontSize("0x000000", this.defaultFont);
				}
				else
				{
					sizefAdd = this.FontSize("0x00000000", this.defaultFont);
				}

				//---数据宽度判断
				if (this.defaultYScaleWidth < ((int)sizefAdd.Width + this.defaultYScaleOffsetWidth))
				{
					this.defaultYScaleWidth = ((int)sizefAdd.Width + this.defaultYScaleOffsetWidth);
				}

				//---字体地址偏移
				fontOffset = this.defaultYScaleWidth - (int)sizefAdd.Width;

				//---地址栏的背景色
				Brush backGroundBrush = new SolidBrush(this.defaultYScaleBackGroundColor);

				//---矩形区域
				Rectangle nowRectangle;
				if (this.defaultXScaleShow)
				{
					nowRectangle = new Rectangle(nowPoint.X, nowPoint.Y, this.defaultYScaleWidth, (this.Height - this.defaultXScaleHeight - this.defaultExternalLineWidth + 1));
				}
				else
				{
					nowRectangle = new Rectangle(nowPoint.X, nowPoint.Y, this.defaultYScaleWidth, (this.Height - this.defaultExternalLineWidth));
				}

				//---填充背景色
				e.Graphics.FillRectangle(backGroundBrush, nowRectangle);

				//---设置地址栏字体色
				Brush fontbrush = new SolidBrush(this.defaultYScaleFontColor);
				nowRectangle = new Rectangle();
				Point nowPointA = new Point();
				string strMsg = null;

				//---填充地址
				for (int ix = this.defaultRowNowNum; ix < this.defaultRowNowNum + iMaxRowCount; ix++)
				{
					//---数据长度超出
					if (iTotalRowCount <= ix)
					{
						break;
					}
					else
					{
						nowPointA.X = nowPoint.X + fontOffset;
						nowPointA.Y = nowPoint.Y + (ix - defaultRowNowNum) * (fonHeight + this.defaultColStaffWidth) + (fonHeight + this.defaultColStaffWidth) / (this.defaultFirstRowOffset);

						if (this.defaultYScaleShowBit4 == YScaleShowBit4.BIT4X2)
						{
							strMsg = "0x" + (ix * this.defaultRowShowNum).ToString("X2");
						}
						else if (this.defaultYScaleShowBit4 == YScaleShowBit4.BIT4X4)
						{
							strMsg = "0x" + (ix * this.defaultRowShowNum).ToString("X4");
						}
						else if (this.defaultYScaleShowBit4 == YScaleShowBit4.BIT4X6)
						{
							strMsg = "0x" + (ix * this.defaultRowShowNum).ToString("X6");
						}
						else
						{
							strMsg = "0x" + (ix * this.defaultRowShowNum).ToString("X8");
						}

						//---绘制地址字符串
						e.Graphics.DrawString(strMsg, this.defaultFont, fontbrush, nowPointA);
					}
				}

				//---绘制地址栏右侧的竖线
				Pen nowPen = new Pen(this.defaultExternalLineColor);

				//---获取第一个点的位置
				nowPoint.X = this.defaultYScaleWidth + this.defaultColStaffWidth - this.defaultExternalLineWidth;
				nowPoint.Y = this.defaultXScaleHeight + this.defaultXScalePosOffset - this.defaultExternalLineWidth / 2;

				//---获取第二个点的位置
				nowPointA.X = nowPoint.X;
				nowPointA.Y = this.Height;

				this.defaultDataEndWidth = (int)nowPointA.X;

				//---绘制直线
				e.Graphics.DrawLine(nowPen, nowPoint, nowPointA);
			}
		}

		#endregion

		#region 绘制Y轴刻度被选中

		/// <summary>
		/// 绘制Y轴刻度选择背景
		/// </summary>
		/// <param name="e"></param>
		private void OnDrawYScaleBackGroundRectangle(PaintEventArgs e)
		{
			if (this.mYScaleShow && (this.defaultRowSelectedNum != -1) && (this.defaultMousePos.iArea == 1))
			{
				//---判定起始点
				Point nowPointA = this.CalcYAddrBeginPosition();
				//---计算宽度
				int fontWidth = this.FontWidth();
				//计算字体的高度
				int fontHeight = this.FontHeigth();
				//---矩形区域
				Rectangle nowRectangle = new Rectangle();
				//---起点(X,Y)坐标
				nowRectangle.X = nowPointA.X;
				nowRectangle.Y = nowPointA.Y + this.defaultRowSelectedNum * (fontHeight + this.defaultColStaffWidth)+(this.defaultExternalLineWidth);
				//---计算宽度
				nowRectangle.Width = this.defaultYScaleWidth ;//+ (this.defaultExternalLineWidth);
				//---计算高度
				nowRectangle.Height = fontHeight + this.defaultColStaffWidth;
				//---区域矩形背景填充
				Brush backGroundBrush = new SolidBrush(Color.FromArgb(60, Color.Black));
				e.Graphics.FillRectangle(backGroundBrush, nowRectangle);
				//---外边框线条
				e.Graphics.DrawRectangle(new Pen(Color.DarkGray, 1), nowRectangle);
			}
			else
			{
				return;
			}
		}

		#endregion

	}
}

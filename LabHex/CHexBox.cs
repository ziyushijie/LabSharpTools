using Harry.LabTools.LabGenFunc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabHexEdit
{
	public partial class CHexBox
	{
		#region 变量定义

		#endregion

		#region 属性定义

		#endregion

		#region 构造函数

		/// <summary>
		/// 构造函数
		/// </summary>
		public CHexBox()
		{
			#region	设置窗体的Style

			//---支持用户重绘窗体
			this.SetStyle(ControlStyles.UserPaint, true);
			//---在内存中先绘制界面，禁止擦除背景
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			//---双缓冲，防止绘制时抖动
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			//---双缓存
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			//---调整大小时重绘
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.UpdateStyles();

			#endregion

			//强制设置输入法为英文输入模式
			this.ImeMode = ImeMode.Disable;

			CGenFuncMem.GenFuncMemset(ref this.defaultNowData, 512, 0xFF);
			CGenFuncMem.GenFuncMemset(ref this.defaultLastData, 512, 0xFF);

		}

		#endregion

		#region 析构函数

		/// <summary>
		/// 析构函数
		/// </summary>
		~CHexBox()
		{
			//if (this.m_IsCreateCaret)
			{
				CHexBox.DestroyCaret();
			}
			//---资源回收
			GC.SuppressFinalize(this);
		}

		#endregion

		#region 公有函数

		#endregion

		#region 保护函数

		#endregion

		#region 私有函数

		/// <summary>
		/// 绘制外部矩形线条
		/// </summary>
		/// <param name="e"></param>
		private void OnPaintRectangleLine(PaintEventArgs e)
		{
			//获取二位平面的X和Y坐标
			Point[] nowPoint = { new Point(0, 0),
								 new Point(this.Width, 0),
								 new Point(this.Width, this.Height),
								 new Point(0, this.Height),
								 new Point(0, 0)
								};
			//画笔
			Pen nowPen = new Pen(this.mRectangleLineColor, this.defaultRectangleLineWidth);
			//绘制线条
			e.Graphics.DrawLines(nowPen, nowPoint);
		}

		/// <summary>
		/// X方向显示栏
		/// </summary>
		/// <param name="e"></param>
		private void OnPaintXShowBar(PaintEventArgs e)
		{
			if ((this.defaultNowData == null) || (this.defaultNowData.Length == 0))
			{
				return;
			}
			//---获取标题栏的起始点			
			Point nowPoint = new Point(this.defaultRectangleLineWidth / 2, this.defaultRectangleLineWidth / 2);
			//---计算标题栏的宽度
			int nowWidth = 0;
			//---判断垂直滚动条是否可见
			if (this.defaultVScrollBar.Visible)
			{
				nowWidth = this.Width - this.defaultRectangleLineWidth - this.defaultScrollWidth;
			}
			else
			{
				nowWidth = this.Width - this.defaultRectangleLineWidth;
			}
			//---计算标题栏的高度
			int nowHeight = (this.mXShowAddrHeight);
			//---获得字体的宽度
			int fontWidth = this.FontWidth();
			//---设置字体的起始位置
			int fontOffset = this.defaultRectangleLineWidth / 2 + this.defaultRowStaffWidth;
			//---判断是否显示地址栏
			if (this.defaultYShowAddr)
			{
				//---计算字体的大小
				SizeF sizefAdd;
				if (this.defaultYShowAddrBIT4 == YShowAddrBIT4.BIT4X2)
				{
					sizefAdd = this.FontSize("0x00", this.defaultFont);
				}
				else if (this.defaultYShowAddrBIT4 == YShowAddrBIT4.BIT4X4)
				{
					sizefAdd = this.FontSize("0x0000", this.defaultFont);
				}
				else if (this.defaultYShowAddrBIT4 == YShowAddrBIT4.BIT4X6)
				{
					sizefAdd = this.FontSize("0x000000", this.defaultFont);
				}
				else
				{
					sizefAdd = this.FontSize("0x00000000", this.defaultFont);
				}
				//---标题栏第一个字符的起始偏移
				fontOffset += (int)sizefAdd.Width + 0;//this.m_YAddrBeginWidth;
				//---数据地址栏的宽度
				this.defaultYShowAddrWidth = (int)sizefAdd.Width + 0;// this.m_YAddrBeginWidth;
			}
			//---获取坐标
			Point nowPointA = new Point();
			Point nowPointB = new Point();
			//---标题栏要填充的背景色
			Brush nowBrush = new SolidBrush(this.defaultXShowAddrBackGroundColor);
			//---计算标题栏的操作区域
			Rectangle nowRectangle = new Rectangle(nowPoint.X, nowPoint.Y, nowWidth, nowHeight);
			//---绘制指定大小的矩形区域并填充指定的背景色
			e.Graphics.FillRectangle(nowBrush, nowRectangle);
			//---设置标题栏字体颜色
			nowBrush = new SolidBrush(this.defaultXShowAddrFontColor);

			//---绘制标题栏
			for (int i = 0; i < this.defaultRowDisplayNum; i++)
			{
				//---绘制数据
				string msg = i.ToString("X2");

				nowPointA.X = fontOffset;
				nowPointA.Y = nowHeight / 6;

				//---绘制字符串
				e.Graphics.DrawString(msg, this.defaultFont, nowBrush, nowPointA);

				//---计算下一个数据的地址
				fontOffset += fontWidth + this.defaultRowStaffWidth;
			}

			//---标题栏下划线的颜色
			Pen nowPen = new Pen(this.defaultRectangleLineColor);
			//---获取第一个点的二维坐标
			nowPointA.X = this.defaultColStaffWidth + this.defaultYShowAddrWidth - this.defaultRectangleLineWidth / 2; //this.HexBoxOutLineWidth / 2; //---顶格显示
			nowPointA.Y = nowHeight - this.defaultRectangleLineWidth / 2;

			//---获取的第二个点的二维坐标
			if (this.defaultVScrollBar.Visible)
			{
				nowPointB.X = this.Width - this.defaultScrollWidth - this.defaultRectangleLineWidth / 2;
			}
			else
			{
				nowPointB.X = this.Width - this.defaultRectangleLineWidth / 2;
			}
			nowPointB.Y = nowPointA.Y;
			//this._beginHeight = nowPointB.Y;

			//---绘制标题栏的下划线
			e.Graphics.DrawLine(nowPen, nowPointA, nowPointB);
		}

		/// <summary>
		/// 垂直滚动栏的显示
		/// </summary>
		private void OnPaintVScrollBar()
		{
			//---获取字体大小信息
			SizeF fontSizef = this.FontSize();
			//--获取字体的宽度和高度
			int fontWidth = (int)fontSizef.Width;
			int fontHeight = (int)fontSizef.Height;
			//---计算当前控件能够显示的最大行数
			int iMaxRowCount = this.CalcShowMaxRowNum();
			//---计算数据需要显示的行数
			int iTotalRowCount = this.CalcDataMaxRowNum();
			//---判断是否超出最大行
			if (iTotalRowCount > iMaxRowCount)
			{
				this.defaultVScrollBar.Visible = true;
				this.defaultVScrollBar.Enabled = true;
				//---设置控件位置
				this.defaultVScrollBar.Location = new Point((this.Width - this.defaultRectangleLineWidth - this.defaultScrollWidth), this.defaultRectangleLineWidth);
				//---滚动条的大小
				this.defaultVScrollBar.Size = new Size(this.defaultScrollWidth, (this.Height - this.defaultRectangleLineWidth * 2));
				//---设置控件的最大值
				this.defaultVScrollBar.LargeChange = 1;
				this.defaultVScrollBar.Maximum = iTotalRowCount - iMaxRowCount;
			}
			else
			{
				this.defaultVScrollBar.Visible = false;
				this.defaultVScrollBar.Enabled = false;
			}
		}

		/// <summary>
		/// 计算当前控件能够显示的最大行数
		/// </summary>
		/// <returns></returns>
		private int CalcShowMaxRowNum()
		{
			//---获取字体的宽度及长度
			SizeF sizef = this.FontSize();
			//---字体的宽度和长度转换成整型
			int fontWidth = (int)(sizef.Width);
			int fontHeight = (int)(sizef.Height);
			//---计算控件最大可显示的行数
			int iHeight = 0;
			//---是否显示标题栏
			if (this.mXShowAddr)
			{
				iHeight = this.Height - this.defaultRectangleLineWidth * 2 - this.defaultRectangleLineWidth;
			}
			else
			{
				iHeight = this.Height - this.defaultRectangleLineWidth * 2;
			}
			return (int)(iHeight / (fontHeight + this.defaultColStaffWidth));
		}

		/// <summary>
		/// 数据地址栏显示的总行数
		/// </summary>
		/// <returns></returns>
		private int CalcDataMaxRowNum()
		{
			if ((this.defaultNowData == null) || (this.defaultNowData.Length == 0))
			{
				return -1;
			}
			//---计算实际的行数
			int dataRow = 0;
			dataRow = this.defaultNowData.Length / this.defaultRowDisplayNum;
			//---不能整除则加一
			if ((this.defaultNowData.Length % this.defaultRowDisplayNum) != 0)
			{
				dataRow += 1;
			}
			return dataRow;
		}

		#endregion

		#region 窗体绘制函数
		protected override void OnPaint(PaintEventArgs e)
		{
			//---基类绘制函数
			base.OnPaint(e);
			//---设置窗体的背景色
			this.BackColor = this.defaultBackGroundColor;
			//设置输入焦点
			this.Focus();
			//---绘制外部线条
			this.OnPaintRectangleLine(e);
			//---绘制滚动条栏
			if ((this.defaultNowData!=null)&&(this.defaultNowData.Length!=0))
			{
				//this.OnPaintVScrollBar();
			}
			//---绘制X方向标题
			if (this.defaultXShowAddr==true)
			{
				if (this.defaultXShowAddrASCII == true)
				{
				}
				else
				{
					this.OnPaintXShowBar(e);
				}
			}

		}
		#endregion

	}
}

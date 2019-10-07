using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Harry.LabTools.LabHexEdit
{

	/// <summary>
	/// 获取控件光标的信息
	/// </summary>
	public partial class CHexBox
	{
		#region  结构定义
		/// <summary>
		/// 插入符信息
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct CaretPoint
		{
			public int X;
			public int Y;

			public CaretPoint(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}
		}

		#endregion


		#region 获取屏幕标记信息API定义

		/// <summary>
		/// 判断插入符的当前位置
		/// </summary>
		/// <param name="lpPoint"></param>
		/// <returns></returns>

		[DllImport("user32.dll")]
		public static extern bool GetCaretPos(out CaretPoint lpPoint);

		/// <summary>
		/// 根据指定的信息创建一个插入符（光标），并将它选定为指定窗口的默认插入符
		/// </summary>
		/// <param name="hWnd"></param>
		/// <param name="hBitmap"></param>
		/// <param name="nWidth"></param>
		/// <param name="nHeight"></param>
		/// <returns></returns>
		[DllImport("user32.dll")]
		public static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

		/// <summary>
		/// 显示插入符
		/// </summary>
		/// <param name="hWnd"></param>
		/// <returns></returns>
		[DllImport("user32.dll")]
		public static extern bool ShowCaret(IntPtr hWnd);

		/// <summary>
		/// 隐藏插入符
		/// </summary>
		/// <param name="hWnd"></param>
		/// <returns></returns>
		[DllImport("User32.dll")]
		public static extern bool HideCaret(IntPtr hWnd);

		/// <summary>
		/// 设定插入符的位置
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		[DllImport("User32.dll")]
		public static extern bool SetCaretPos(int x, int y);

		/// <summary>
		/// 清除（破坏）一个插入符
		/// </summary>
		/// <returns></returns>
		[DllImport("user32.dll")]
		public static extern bool DestroyCaret();

		/// <summary>
		/// 判断插入符光标的闪烁频率
		/// </summary>
		/// <returns></returns>
		[DllImport("user32.dll")]
		public static extern uint GetCaretBlinkTime();

		/// <summary>
		/// 指定插入符（光标）的闪烁频率
		/// </summary>
		/// <param name="uMSeconds"></param>
		/// <returns></returns>
		[DllImport("user32.dll")]
		public static extern bool SetCaretBlinkTime(uint uMSeconds);

		#endregion

		#region 字体大小

		/// <summary>
		/// 字体大小
		/// </summary>
		/// <returns></returns>
		public virtual SizeF FontSize()
		{
			Graphics g = this.CreateGraphics();
			SizeF sizeF = g.MeasureString("00", this.mFont);
			g.Dispose();
			return sizeF;
		}

		/// <summary>
		/// 字体大小
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public virtual SizeF FontSize(string str)
		{
			Graphics g = this.CreateGraphics();
			SizeF sizeF = g.MeasureString(str, this.mFont);
			g.Dispose();
			return sizeF;
		}

		/// <summary>
		/// 字体大小
		/// </summary>
		/// <param name="str"></param>
		/// <param name="ft"></param>
		/// <returns></returns>
		public virtual SizeF FontSize(string str, Font ft)
		{
			Graphics g = this.CreateGraphics();
			SizeF sizeF = g.MeasureString(str, ft);
			g.Dispose();
			return sizeF;
		}

		/// <summary>
		/// 字体宽度
		/// </summary>
		/// <returns></returns>
		public virtual int FontWidth()
		{
			SizeF size = this.FontSize("00", this.mFont);
			return (int)(size.Width - 1.5);
		}

		/// <summary>
		/// 字体宽度
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public virtual int FontWidth(string str)
		{
			SizeF size = this.FontSize(str, this.mFont);
			return (int)(size.Width - 1.5);
		}

		/// <summary>
		/// 字体宽度
		/// </summary>
		/// <param name="str"></param>
		/// <param name="ft"></param>
		/// <returns></returns>
		public virtual int FontWidth(string str, Font ft)
		{
			SizeF size = this.FontSize(str, ft);
			return (int)(size.Width);
		}

		/// <summary>
		/// 字体高度
		/// </summary>
		/// <returns></returns>
		public virtual int FontHeigth()
		{
			SizeF size = this.FontSize("00", this.mFont);
			return (int)(size.Height);
		}

		/// <summary>
		/// 字体高度
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public virtual int FontHeigth(string str)
		{
			SizeF size = this.FontSize(str, this.mFont);
			return (int)(size.Height);
		}

		/// <summary>
		/// 字体高度
		/// </summary>
		/// <param name="str"></param>
		/// <param name="ft"></param>
		/// <returns></returns>
		public virtual int FontHeigth(string str, Font ft)
		{
			SizeF size = this.FontSize(str, ft);
			return (int)(size.Height);
		}

		#endregion

	}
}

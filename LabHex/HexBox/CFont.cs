using System.Drawing;
using System.Windows.Forms;

namespace Harry.LabTools.LabHex
{
	/// <summary>
	/// 计算字体的高度和宽度
	/// </summary>
	public partial class CHexBox 
	{
		/// <summary>
		/// 计算算字体的大小
		/// </summary>
		/// <returns></returns>
		private SizeF FontSize()
		{
			Graphics g = this.CreateGraphics();
			SizeF sizeF = g.MeasureString("00", this.m_Font);
			g.Dispose();
			return sizeF;
		}

		/// <summary>
		/// 计算字体的大小
		/// </summary>
		/// <param name="strText"></param>
		/// <returns></returns>
		private SizeF FontSize(string strText)
		{
			Graphics g = this.CreateGraphics();
			SizeF sizeF = g.MeasureString(strText, this.m_Font);
			g.Dispose();
			return sizeF;
		}

		/// <summary>
		/// 计算字体的大小
		/// </summary>
		/// <param name="strText"></param>
		/// <param name="font"></param>
		/// <returns></returns>
		private SizeF FontSize(string strText, Font font)
		{
			Graphics g = this.CreateGraphics();
			SizeF sizeF = g.MeasureString(strText, font);
			g.Dispose();
			return sizeF;
		}

		/// <summary>
		/// 计算字体的宽度
		/// </summary>
		/// <returns></returns>
		private int FontWidth()
		{
			SizeF size = FontSize("00", this.m_Font);
			return (int)(size.Width-1.5);
		}

		/// <summary>
		/// 计算字体的宽度
		/// </summary>
		/// <param name="strText"></param>
		/// <returns></returns>
		private int FontWidth(string strText)
		{
			SizeF size = FontSize(strText, this.m_Font);
			return (int)(size.Width-1.5);
		}

		/// <summary>
		/// 计算字体的宽度
		/// </summary>
		/// <param name="strText"></param>
		/// <param name="font"></param>
		/// <returns></returns>
		private int FontWidth(string strText, Font font)
		{
			SizeF size = FontSize(strText, font);
			return (int)(size.Width);
		}

		/// <summary>
		/// 计算字体的高度
		/// </summary>
		/// <returns></returns>
		private int FontHeigth()
		{
			SizeF size = FontSize("00", this.m_Font);

			return (int)(size.Height);
		}

		/// <summary>
		/// 计算字体的高度
		/// </summary>
		/// <param name="strText"></param>
		/// <returns></returns>
		private int FontHeigth(string strText)
		{
			SizeF size = FontSize(strText, this.m_Font);

			return (int)(size.Height);
		}

		/// <summary>
		/// 计算字体的高度
		/// </summary>
		/// <param name="strText"></param>
		/// <param name="font"></param>
		/// <returns></returns>
		private int FontHeigth(string strText, Font font)
		{
			SizeF size = FontSize(strText, font);
			return (int)(size.Height);
		}


	}
}
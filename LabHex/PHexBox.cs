using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabHexEdit
{
	public partial class CHexBox: Control
	{
		#region 不同颜色标注数据

		/// <summary>
		/// 数据更新的时候是否用不同的颜色标注
		/// </summary>
		private bool defaultShowChangeColor = false;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("是否用颜色标注数据的变化"), Category("自定义属性")]
		public virtual bool mShowChangeColor
		{
			get
			{
				return this.defaultShowChangeColor;
			}
			set
			{
				this.defaultShowChangeColor = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		#endregion

		#region X方向

		/// <summary>
		/// 显示X方向的数据地址
		/// </summary>
		private bool defaultXShowAddr = true;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("是否显示X方向地址"), Category("自定义属性")]
		public virtual bool mXShowAddr
		{
			get
			{
				return this.defaultXShowAddr;
			}
			set
			{
				this.defaultXShowAddr = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// X方向地址高度
		/// </summary>
		private int defaultXShowAddrHeight = 24;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("X方向高度"), Category("自定义属性")]
		public virtual int mXShowAddrHeight
		{
			get
			{
				return this.defaultXShowAddrHeight;
			}
			set
			{
				this.defaultXShowAddrHeight = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// X方向地址字体颜色
		/// </summary>
		private Color defaultXShowAddrFontColor = Color.Black;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("X方向字体颜色"), Category("自定义属性")]
		public virtual Color mXShowAddrFontColor
		{
			get
			{
				return this.defaultXShowAddrFontColor;
			}
			set
			{
				this.defaultXShowAddrFontColor = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// X方向地址背景色
		/// </summary>
		private Color defaultXShowAddrBackGroundColor = Color.FromArgb(240, 240, 240);

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("X方向背景色"), Category("自定义属性")]
		public virtual Color mXShowAddrBackGroundColor
		{
			get
			{
				return this.defaultXShowAddrBackGroundColor;
			}
			set
			{
				this.defaultXShowAddrBackGroundColor = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// X方向显示ASCII地址
		/// </summary>
		private bool defaultXShowAddrASCII = true;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("X方向是否显示ASCII地址信息"), Category("自定义属性")]
		public virtual bool mXShowAddrASCII
		{
			get
			{
				return this.defaultXShowAddrASCII;
			}
			set
			{
				this.defaultXShowAddrASCII = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		#endregion

		#region Y轴方向

		/// <summary>
		/// 显示X方向的数据地址
		/// </summary>
		private bool defaultYShowAddr = true;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("是否显示Y方向地址"), Category("自定义属性")]
		public virtual bool mYShowAddr
		{
			get
			{
				return this.defaultYShowAddr;
			}
			set
			{
				this.defaultYShowAddr = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// Y方向地址宽度
		/// </summary>
		private int defaultYShowAddrWidth = 24;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("Y方向宽度"), Category("自定义属性")]
		public virtual int mYShowAddrWidth
		{
			get
			{
				return this.defaultYShowAddrWidth;
			}
			set
			{
				this.defaultYShowAddrWidth = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// Y方向地址字体颜色
		/// </summary>
		private Color defaultYShowAddrFontColor = Color.Black;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("Y方向字体颜色"), Category("自定义属性")]
		public virtual Color mYShowAddrFontColor
		{
			get
			{
				return this.defaultYShowAddrFontColor;
			}
			set
			{
				this.defaultYShowAddrFontColor = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// X方向地址背景色
		/// </summary>
		private Color defaultYShowAddrBackGroundColor = Color.FromArgb(240, 240, 240);

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("X方向背景色"), Category("自定义属性")]
		public virtual Color mYShowAddrBackGroundColor
		{
			get
			{
				return this.defaultYShowAddrBackGroundColor;
			}
			set
			{
				this.defaultYShowAddrBackGroundColor = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// 显示数据的半个字节的几倍
		/// </summary>
		public enum YShowAddrBIT4:byte
		{
			BIT4X2 = 2,
			BIT4X4 = 4,
			BIT4X6 = 6,
			BIT4X8 = 8,
		}

		/// <summary>
		/// Y方向显示地址是半个字节的几倍
		/// </summary>
		private YShowAddrBIT4 defaultYShowAddrBIT4 = YShowAddrBIT4.BIT4X4;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("Y方向显示数据的BIT个数"), Category("自定义属性")]
		public virtual YShowAddrBIT4 mYShowAddrBIT4
		{
			get
			{
				return this.defaultYShowAddrBIT4;
			}
			set
			{
				this.defaultYShowAddrBIT4 = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		#endregion

		#region 字体

		/// <summary>
		/// 全局字体大小
		/// </summary>
		private Font defaultFont = new Font("黑体", 12);

		/// <summary>
		/// 全局使用的字体
		/// </summary>
		[Description("全局字体大小"), Category("自定义属性")]
		public virtual Font mFont
		{
			get
			{
				return this.defaultFont;
			}
			set
			{
				this.defaultFont = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// 字体背景色
		/// </summary>
		private Color defaultBackGroundColor = Color.White;

		/// <summary>
		/// 全局字体背景色
		/// </summary>
		[Description("全局字体大小"), Category("自定义属性")]
		public virtual Color mBackGroundColor
		{
			get
			{
				return this.defaultBackGroundColor;
			}
			set
			{
				this.defaultBackGroundColor = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		#endregion

		#region 外部线条

		/// <summary>
		/// 外部线条颜色
		/// </summary>
		private Color defaultRectangleLineColor = Color.DarkGray;

		/// <summary>
		/// 外部边框的线条颜色
		/// </summary>
		[Description("外部矩形框的线条颜色"), Category("自定义属性")]
		public virtual Color mRectangleLineColor
		{
			get
			{
				return this.defaultRectangleLineColor;
			}
			set
			{
				this.defaultRectangleLineColor = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		/// <summary>
		/// 外部线条的宽度
		/// </summary>
		private int defaultRectangleLineWidth = 2;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("外部矩形框的线条宽度"), Category("自定义属性")]
		public virtual int mRectangleLineWidth
		{
			get
			{
				return this.defaultRectangleLineWidth;
			}
			set
			{
				this.defaultRectangleLineWidth = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		#endregion

		#region 垂直滚动条

		/// <summary>
		/// 垂直滚动条
		/// </summary>
		private VScrollBar defaultVScrollBar;

		/// <summary>
		/// 垂直滚动条的下拉控件的宽度
		/// </summary>
		private int defaultScrollWidth = 16;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("右侧垂直滚动条的宽度"), Category("自定义属性")]
		public virtual int mScrollWidth
		{
			get
			{
				return this.defaultScrollWidth;
			}
			set
			{
				this.defaultScrollWidth = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		#endregion

		#region 数据缓存区

		/// <summary>
		/// 当前数据
		/// </summary>
		private byte[] defaultNowData = null;
		
		/// <summary>
		/// 上次数据
		/// </summary>
		private byte[] defaultLastData = null;

		/// <summary>
		/// 数据变化
		/// </summary>
		private bool  defaultDataChange = false;

		/// <summary>
		/// 属性读写
		/// </summary>
		[Description("数据发生变化"), Category("自定义属性")]
		public virtual bool mDataChange
		{
			get
			{
				return this.defaultDataChange;
			}
			set
			{
				this.defaultDataChange = value;
				//---重新绘制窗体
				this.Invalidate();
			}
		}

		#endregion

		#region 数据行信息

		/// <summary>
		/// 每行显示的数据个数
		/// </summary>
		private int defaultRowDisplayNum = 16;

		/// <summary>
		/// 每行中字符间的间隔
		/// </summary>
		private int defaultRowStaffWidth = 10;

		/// <summary>
		/// 每列中字符间的间隔
		/// </summary>
		private int defaultColStaffWidth = 4;

		/// <summary>
		/// 当前显示的起始行号
		/// </summary>
		private int defaultRowDisplayIndex = 0;

		/// <summary>
		/// 当前选中的行号
		/// </summary>
		private int defaultRowSelectedIndex = -1;

		/// <summary>
		/// 数据行矩形框的位置
		/// </summary>
		private int defaultCurrentPosOffset = 7;

		#endregion

	}
}

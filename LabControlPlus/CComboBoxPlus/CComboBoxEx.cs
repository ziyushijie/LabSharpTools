using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabControlPlus
{
	public partial class CComboBoxEx : ComboBox
	{

		#region	属性函数

		#endregion

		#region 构造函数

		/// <summary>
		/// 
		/// </summary>
		public CComboBoxEx()
		{
			//设置控件风格
			this.SetStyle(ControlStyles.AllPaintingInWmPaint |  //全部在窗口绘制消息中绘图
							ControlStyles.OptimizedDoubleBuffer,    //使用双缓冲
							true
						);
		}

		#endregion

		#region	 保护函数
		#endregion
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
		}

	}
}

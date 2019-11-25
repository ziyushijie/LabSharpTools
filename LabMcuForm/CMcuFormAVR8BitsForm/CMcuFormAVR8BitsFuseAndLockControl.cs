using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harry.LabTools.LabComm;
using Harry.LabTools.LabMcuFunc;
using Harry.LabTools.LabGenFunc;

namespace LabMcuForm.CMcuFormAVR8Bits
{
	public partial class CMcuFormAVR8BitsFuseAndLockControl : UserControl
	{
		#region 变量定义
		
		/// <summary>
		/// MCU的参数
		/// </summary>
		private CMcuFuncBase defaultCMcuFunc = null;

		/// <summary>
		/// 是否刷新FuseText设备
		/// </summary>
		private bool defaultIsRefreshFuseText = false;

		#endregion

		#region 属性定义

		/// <summary>
		/// MCU功能的基类
		/// </summary>
		public virtual CMcuFuncBase mCMcuFunc
		{
			get
			{
				return this.defaultCMcuFunc;
			}
		}

		#endregion

		#region 构造函数

		/// <summary>
		/// 无参数构造函数
		/// </summary>
		public CMcuFormAVR8BitsFuseAndLockControl()
		{
			InitializeComponent();
			//---在内存中先绘制界面，禁止擦除背景
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			//---双缓冲，防止绘制时抖动
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			//---双缓存
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			//---限制窗体的大小
			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;
			//---启动初始化
			this.StartupInit();
		}

		/// <summary>
		/// 有参数构造函数
		/// </summary>
		/// <param name="cCommBase"></param>
		/// <param name="cMcuFuncInfoBaseParam"></param>
		public CMcuFormAVR8BitsFuseAndLockControl(CMcuFuncBase cMcuFunc)
		{
			InitializeComponent();
			//---在内存中先绘制界面，禁止擦除背景
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			//---双缓冲，防止绘制时抖动
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			//---双缓存
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			//---限制窗体的大小
			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;
			//---初始化芯片信息
			if (this.defaultCMcuFunc==null)
			{
				this.defaultCMcuFunc = new CMcuFuncBase();
			}
			this.defaultCMcuFunc = cMcuFunc;
			//---初始化
			this.Init(cMcuFunc);
		}

		#endregion

		#region 公共函数
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cMcuFuncInfoBaseParam"></param>
		public void Init(CMcuFuncBase cMcuFunc)
		{
			//---初始化芯片信息
			//---初始化芯片信息
			if (this.defaultCMcuFunc == null)
			{
				this.defaultCMcuFunc = new CMcuFuncBase();
			}
			this.defaultCMcuFunc = cMcuFunc;
			//---初始化相关控件
			((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FormControlInit(this.cCheckedListBoxEx_LowFuseBits, this.cCheckedListBoxEx_HighFuseBits, this.cCheckedListBoxEx_ExternFuseBits, this.cCheckedListBoxEx_LockFuseBits,
																							this.cCheckedListBoxEx_FuseText,
																							this.label_OSCText1, this.label_OSCText2, this.label_OSCText3, this.label_OSCText4,
																							this.textBox_OSCValue1, this.textBox_OSCValue2, this.textBox_OSCValue3, this.textBox_OSCValue4,
																							this.textBox_LowFuseValue, this.textBox_HighFuseValue, this.textBox_ExternFuseValue, this.textBox_LockFuseValue
																							);
			this.RegistrationEventHandler();
			
		}

		#endregion

		#region 保护函数

		#endregion

		#region 私有函数

		/// <summary>
		/// 启动初始化
		/// </summary>
		private void StartupInit()
		{
			//---控件变量初始化
			this.label_OSCText1.Visible = false;
			this.label_OSCText2.Visible = false;
			this.label_OSCText3.Visible = false;
			this.label_OSCText4.Visible = false;

			this.textBox_OSCValue1.Visible = false;
			this.textBox_OSCValue2.Visible = false;
			this.textBox_OSCValue3.Visible = false;
			this.textBox_OSCValue4.Visible = false;

			this.textBox_LockFuseValue.Text		= "00";
			this.textBox_HighFuseValue.Text		= "00";
			this.textBox_ExternFuseValue.Text	= "00";
			this.textBox_LockFuseValue.Text		= "00";

			//---注册事件

		}

		/// <summary>
		/// 注册事件函数
		/// </summary>
		private void RegistrationEventHandler()
		{
			this.cCheckedListBoxEx_LowFuseBits.SelectedIndexChanged += new EventHandler(this.CheckedListBox_SelectedIndexChanged);
			this.cCheckedListBoxEx_HighFuseBits.SelectedIndexChanged += new EventHandler(this.CheckedListBox_SelectedIndexChanged);
			//---校验拓展熔丝位
			if (((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).ChipExternFuseBits != null)
			{
				this.cCheckedListBoxEx_ExternFuseBits.SelectedIndexChanged += new EventHandler(this.CheckedListBox_SelectedIndexChanged);
			}
			this.cCheckedListBoxEx_LockFuseBits.SelectedIndexChanged += new EventHandler(this.CheckedListBox_SelectedIndexChanged);
			this.cCheckedListBoxEx_FuseText.SelectedIndexChanged += new EventHandler(this.CheckedListBox_SelectedIndexChanged);

			this.textBox_LowFuseValue.TextChanged += new EventHandler(this.TextBox_TextChanged);
			this.textBox_HighFuseValue.TextChanged += new EventHandler(this.TextBox_TextChanged);
			this.textBox_ExternFuseValue.TextChanged += new EventHandler(this.TextBox_TextChanged);
			this.textBox_LockFuseValue.TextChanged += new EventHandler(this.TextBox_TextChanged);


		}


		#endregion

		#region 事件定义

		/// <summary>
		/// 变化事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			CheckedListBox clb = (CheckedListBox)sender;
			clb.Enabled = false;
			if (clb.SelectedItem.ToString() == "NC")
			{
				clb.SetItemCheckState(clb.SelectedIndex, CheckState.Checked);
				clb.SetItemCheckState(clb.SelectedIndex, CheckState.Indeterminate);
			}
			else
			{
				switch (clb.Name)
				{
					case "cCheckedListBoxEx_LowFuseBits":
						this.defaultIsRefreshFuseText = true;
						((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_LowFuseBits, this.cCheckedListBoxEx_FuseText, this.textBox_LowFuseValue, 0);
						break;
					case "cCheckedListBoxEx_HighFuseBits":
						this.defaultIsRefreshFuseText = true;
						((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_HighFuseBits, this.cCheckedListBoxEx_FuseText, this.textBox_HighFuseValue, 1);
						break;
					case "cCheckedListBoxEx_ExternFuseBits":
						this.defaultIsRefreshFuseText = true;
						((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_ExternFuseBits, this.cCheckedListBoxEx_FuseText, this.textBox_ExternFuseValue, 2);
						break;
					case "cCheckedListBoxEx_LockFuseBits":
						this.defaultIsRefreshFuseText = true;
						((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_LockFuseBits, this.cCheckedListBoxEx_FuseText, this.textBox_LockFuseValue, 3);
						break;
					case "cCheckedListBoxEx_FuseText":
						this.defaultIsRefreshFuseText = false;
						((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_FuseText, this.textBox_LowFuseValue, this.textBox_HighFuseValue, this.textBox_ExternFuseValue, this.textBox_LockFuseValue);
						break;
					default:
						break;
				}
			}
			//---这里是为防止双击效果
			CGenFuncDelay.GenFuncDelayms(150);
			clb.Enabled = true;
			//设置输入焦点
			clb.Focus();
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			tb.Enabled = false;
			switch (tb.Name)
			{
				case "textBox_LowFuseValue":
					((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_LowFuseBits, (this.defaultIsRefreshFuseText == false)?this.cCheckedListBoxEx_FuseText:null,Convert.ToByte(this.textBox_LowFuseValue.Text,16), 0);
					this.defaultIsRefreshFuseText = false;
					break;
				case "textBox_HighFuseValue":
					((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_HighFuseBits, (this.defaultIsRefreshFuseText == false) ? this.cCheckedListBoxEx_FuseText : null, Convert.ToByte(this.textBox_HighFuseValue.Text, 16), 1);
					this.defaultIsRefreshFuseText = false;
					break;
				case "textBox_ExternFuseValue":
					((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_ExternFuseBits, (this.defaultIsRefreshFuseText == false) ? this.cCheckedListBoxEx_FuseText : null, Convert.ToByte(this.textBox_ExternFuseValue.Text, 16),2);
					this.defaultIsRefreshFuseText = false;
					break;
				case "textBox_LockFuseValue":
					((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_LockFuseBits, (this.defaultIsRefreshFuseText == false) ? this.cCheckedListBoxEx_FuseText : null, Convert.ToByte(this.textBox_LockFuseValue.Text, 16), 3);
					this.defaultIsRefreshFuseText = false;
					break;
				default:
					break;
			}
			tb.Enabled = true;
			tb.Focus();
		}

		#endregion

	
	}
}

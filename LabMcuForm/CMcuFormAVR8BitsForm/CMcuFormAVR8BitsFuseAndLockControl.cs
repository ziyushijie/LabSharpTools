﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harry.LabTools.LabCommType;
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
		private CMcuFuncAVR8BitsBase defaultCMcuFunc = null;

		/// <summary>
		/// 是否刷新FuseText设备
		/// </summary>
		private bool defaultIsRefreshFuseText = false;

		/// <summary>
		/// 消息窗体
		/// </summary>
		private RichTextBox defaultRichTextBoxMsg = null;

		#endregion

		#region 属性定义

		/// <summary>
		/// MCU功能的属性为只读
		/// </summary>
		public virtual CMcuFuncAVR8BitsBase mCMcuFunc
		{
			get
			{
				return this.defaultCMcuFunc;
			}
			set
			{
				this.defaultCMcuFunc = value;
			}
		}

		/// <summary>
		/// 加密熔丝位的属性为读写
		/// </summary>
		public virtual TextBox mLockFuse
		{
			get
			{
				return this.textBox_LockFuseValue;
			}
			set
			{
				this.textBox_LockFuseValue = value;
			}
		}

		/// <summary>
		/// 系统类型
		/// </summary>
		private Boolean IsXpOr2003
		{
			get
			{
				OperatingSystem os = Environment.OSVersion;
				Version vs = os.Version;
				if (os.Platform == PlatformID.Win32NT)
				{
					if ((vs.Major == 5) && (vs.Minor != 0))
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}

			}
		}

		/// <summary>
		/// 设置控件窗口创建参数的扩展风格
		/// </summary>
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				// Turn on WS_EX_COMPOSITED    
				cp.ExStyle |= 0x02000000;
				if (this.IsXpOr2003 == true)
				{
					// Turn on WS_EX_LAYERED  
					cp.ExStyle |= 0x00080000;
				}
				return cp;
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
		public CMcuFormAVR8BitsFuseAndLockControl(CMcuFuncAVR8BitsBase cMcuFunc,RichTextBox msg=null)
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
				this.defaultCMcuFunc = new CMcuFuncAVR8BitsBase();
			}
			this.defaultCMcuFunc = cMcuFunc;
			//---初始化
			this.Init(cMcuFunc,msg);
		}

		#endregion

		#region 公共函数
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cMcuFuncInfoBaseParam"></param>
		public void Init(CMcuFuncAVR8BitsBase cMcuFunc,RichTextBox msg=null)
		{
			if (cMcuFunc==null)
			{
				return;
			}
			//---初始化芯片信息
			if (this.defaultCMcuFunc == null)
			{
				this.defaultCMcuFunc = new CMcuFuncAVR8BitsBase();
			}
			this.defaultCMcuFunc = cMcuFunc;
			//---初始化相关控件
			this.defaultCMcuFunc.mMcuInfoParam.FormControlInit(	this.cCheckedListBoxEx_LowFuseBits, this.cCheckedListBoxEx_HighFuseBits, this.cCheckedListBoxEx_ExternFuseBits, this.cCheckedListBoxEx_LockFuseBits,
																this.cCheckedListBoxEx_FuseText,
																this.label_OSCText1, this.label_OSCText2, this.label_OSCText3, this.label_OSCText4,
																this.textBox_OSCValue1, this.textBox_OSCValue2, this.textBox_OSCValue3, this.textBox_OSCValue4,
																this.textBox_LowFuseValue, this.textBox_HighFuseValue, this.textBox_ExternFuseValue, this.textBox_LockFuseValue
																);
			this.RegistrationEventHandler();
			//---消息显示
			if (msg!=null)
			{
				this.defaultRichTextBoxMsg = msg;
			}
			
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
			this.label_OSCText1.Visible		= false;
			this.label_OSCText2.Visible		= false;
			this.label_OSCText3.Visible		= false;
			this.label_OSCText4.Visible		= false;

			this.textBox_OSCValue1.Visible	= false;
			this.textBox_OSCValue2.Visible	= false;
			this.textBox_OSCValue3.Visible	= false;
			this.textBox_OSCValue4.Visible	= false;

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
			if (this.defaultCMcuFunc.mMcuInfoParam.mChipExternFuseBits != null)
			{
				this.cCheckedListBoxEx_ExternFuseBits.SelectedIndexChanged += new EventHandler(this.CheckedListBox_SelectedIndexChanged);
			}
			this.cCheckedListBoxEx_LockFuseBits.SelectedIndexChanged += new EventHandler(this.CheckedListBox_SelectedIndexChanged);
			this.cCheckedListBoxEx_FuseText.SelectedIndexChanged += new EventHandler(this.CheckedListBox_SelectedIndexChanged);

			this.textBox_LowFuseValue.TextChanged += new EventHandler(this.TextBox_TextChanged);
			this.textBox_HighFuseValue.TextChanged += new EventHandler(this.TextBox_TextChanged);
			this.textBox_ExternFuseValue.TextChanged += new EventHandler(this.TextBox_TextChanged);
			this.textBox_LockFuseValue.TextChanged += new EventHandler(this.TextBox_TextChanged);

			this.button_ReadChipCalibration.Click += new EventHandler(this.Button_Click);
			this.button_ReadChipFuse.Click += new EventHandler(this.Button_Click);
			this.button_DefaultChipFuse.Click += new EventHandler(this.Button_Click);
			this.button_WriteChipFuse.Click += new EventHandler(this.Button_Click);

			this.button_ReadChipLock.Click += new EventHandler(this.Button_Click);
			this.button_WriteChipLock.Click += new EventHandler(this.Button_Click);

		}

		#endregion

		#region 事件定义

		/// <summary>
		/// CheckedListBox_SelectedIndexChanged变化事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender==null)
			{
				return;
			}
			CheckedListBox clb = (CheckedListBox)sender;
			//---这里是为防止双击效果
			CGenFuncDelay.GenFuncDelayms(150);
			//clb.Enabled = false;
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
						this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_LowFuseBits, this.cCheckedListBoxEx_FuseText, this.textBox_LowFuseValue, 0);
						break;
					case "cCheckedListBoxEx_HighFuseBits":
						this.defaultIsRefreshFuseText = true;
						this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_HighFuseBits, this.cCheckedListBoxEx_FuseText, this.textBox_HighFuseValue, 1);
						break;
					case "cCheckedListBoxEx_ExternFuseBits":
						this.defaultIsRefreshFuseText = true;
						this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_ExternFuseBits, this.cCheckedListBoxEx_FuseText, this.textBox_ExternFuseValue, 2);
						break;
					case "cCheckedListBoxEx_LockFuseBits":
						this.defaultIsRefreshFuseText = true;
						this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_LockFuseBits, this.cCheckedListBoxEx_FuseText, this.textBox_LockFuseValue, 3);
						break;
					case "cCheckedListBoxEx_FuseText":
						this.defaultIsRefreshFuseText = false;
						this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_FuseText, this.textBox_LowFuseValue, this.textBox_HighFuseValue, this.textBox_ExternFuseValue, this.textBox_LockFuseValue);
						break;
					default:
						break;
				}
			}
			//clb.Enabled = true;
			//设置输入焦点
			clb.Focus();
		}

		/// <summary>
		/// TextBox_TextChanged变化事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			if (sender==null)
			{
				return;
			}
			TextBox tb = (TextBox)sender;
			//tb.Enabled = false;
			switch (tb.Name)
			{
				case "textBox_LowFuseValue":
					this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_LowFuseBits, (this.defaultIsRefreshFuseText == false)?this.cCheckedListBoxEx_FuseText:null,Convert.ToByte(this.textBox_LowFuseValue.Text,16), 0);
					this.defaultIsRefreshFuseText = false;
					break;
				case "textBox_HighFuseValue":
					this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_HighFuseBits, (this.defaultIsRefreshFuseText == false) ? this.cCheckedListBoxEx_FuseText : null, Convert.ToByte(this.textBox_HighFuseValue.Text, 16), 1);
					this.defaultIsRefreshFuseText = false;
					break;
				case "textBox_ExternFuseValue":
					this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_ExternFuseBits, (this.defaultIsRefreshFuseText == false) ? this.cCheckedListBoxEx_FuseText : null, Convert.ToByte(this.textBox_ExternFuseValue.Text, 16),2);
					this.defaultIsRefreshFuseText = false;
					break;
				case "textBox_LockFuseValue":
					this.defaultCMcuFunc.mMcuInfoParam.FuseCheckedListBoxRefresh(this.cCheckedListBoxEx_LockFuseBits, (this.defaultIsRefreshFuseText == false) ? this.cCheckedListBoxEx_FuseText : null, Convert.ToByte(this.textBox_LockFuseValue.Text, 16), 3);
					this.defaultIsRefreshFuseText = false;
					break;
				default:
					break;
			}
			//tb.Enabled = true;
			tb.Focus();
		}

		/// <summary>
		/// 按键点击事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button_Click(object sender, EventArgs e)
		{
			if (sender == null)
			{
				return;
			}
			//---校验通讯端口
			if ((this.defaultCMcuFunc.mCCOMM==null) ||(this.defaultCMcuFunc.mCCOMM.mIsOpen == false))
			{
				MessageBox.Show("通讯端口初始化异常!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Button bt = (Button)sender;
			//bt.Enabled = false;
			switch (bt.Name)
			{
				//---读取校准字
				case "button_ReadChipCalibration":
					this.defaultCMcuFunc.CMcuFunc_ReadChipCalibration(	this.textBox_OSCValue1, this.textBox_OSCValue2, this.textBox_OSCValue3, this.textBox_OSCValue4, 
																		this.defaultRichTextBoxMsg);
					break;
				//---读取熔丝位
				case "button_ReadChipFuse":
					this.defaultCMcuFunc.CMcuFunc_ReadChipFuse(this.textBox_LowFuseValue, this.textBox_HighFuseValue, this.textBox_ExternFuseValue, this.defaultRichTextBoxMsg);
					break;
				//---默认熔丝位
				case "button_DefaultChipFuse":
					this.defaultCMcuFunc.CMcuFunc_DefaultChipFuse(this.textBox_LowFuseValue, this.textBox_HighFuseValue, this.textBox_ExternFuseValue,this.defaultRichTextBoxMsg);
					break;
				//---写入熔丝位
				case "button_WriteChipFuse":
					this.defaultCMcuFunc.CMcuFunc_WriteChipFuse(this.textBox_LowFuseValue, this.textBox_HighFuseValue, this.textBox_ExternFuseValue, this.defaultRichTextBoxMsg);
					break;
				//---读取加密位
				case "button_ReadChipLock":
					this.defaultCMcuFunc.CMcuFunc_ReadChipLock(this.textBox_LockFuseValue, this.defaultRichTextBoxMsg);
					break;
				//---写入加密位
				case "button_WriteChipLock":
					this.defaultCMcuFunc.CMcuFunc_WriteChipLock(this.textBox_LockFuseValue, this.defaultRichTextBoxMsg);
					break;
				default:
					break;
			}
			//bt.Enabled = true;
			bt.Focus();
		}

		#endregion


	}
}

﻿using Harry.LabTools.LabCommType;
using Harry.LabTools.LabControlPlus;
using Harry.LabTools.LabMcuFunc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMcuForm
{

	#region	定义委托事件

	/// <summary>
	/// 定义同步事件
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void EventSynchronized();

	#endregion
	public partial class CMcuFormAVR8BitsForm : Form
	{
		#region 委托事件

		/// <summary>
		/// 通讯端口同步事件
		/// </summary>
		public virtual event EventSynchronized EventHandlerCCommSynchronized = null;

		#endregion

		#region 变量定义

		/// <summary>
		/// 使用的通讯端口
		/// </summary>
		private CCommBase defaultCComm = new CCommSerial();

		/// <summary>
		/// MCU的参数
		/// </summary>
		private CMcuFuncAVR8BitsBase defaultCMcuFunc = new CMcuFuncAVR8BitsISP();

		#endregion

		#region 属性定义

		/// <summary>
		/// 通讯端口的属性为只读
		/// </summary>
		public virtual CCommBase mCComm
		{
			get
			{
				return this.defaultCComm;
			}
			set
			{
				this.defaultCComm = value;
			}
		}

		/// <summary>
		/// MCU功能的属性为只读
		/// </summary>
		public virtual CMcuFuncAVR8BitsBase mCMcuFunc
		{
			get
			{
				return this.defaultCMcuFunc;
			}
		}

		/// <summary>
		/// 通讯端口类的属性为读写属性
		/// </summary>
		public virtual CCommBaseControl mCCommControl
		{
			get
			{
				return this.cCommBaseControl_ChipCOMM;
			}
			set
			{
				this.cCommBaseControl_ChipCOMM = value;
			}
		}

		/// <summary>
		/// 熔丝位加密位
		/// </summary>
		public virtual TextBox mLockFuse
		{
			get
			{
				return this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.mLockFuse;
			}
			set
			{
				this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.mLockFuse = value;
			}
		}

		/// <summary>
		/// 器件类型
		/// </summary>
		public virtual MCU_INFO_TYPE mTypeMcuInfo
		{
			get
			{
				if (this.mCMcuFunc != null)
				{
					return this.mCMcuFunc.mMcuInfoParam.mTypeMcuInfo;
				}
				else
				{
					return MCU_INFO_TYPE.MCU_NONE;
				}
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
		//protected override CreateParams CreateParams
		//{
		//	get
		//	{
		//		CreateParams cp = base.CreateParams;
		//		// Turn on WS_EX_COMPOSITED    
		//		cp.ExStyle |= 0x02000000;
		//		if (this.IsXpOr2003 == true)
		//		{
		//			// Turn on WS_EX_LAYERED  
		//			cp.ExStyle |= 0x00080000;
		//			this.Opacity = 1;
		//		}
		//		return cp;
		//	}
		//}

		#endregion

		#region 构造函数

		/// <summary>
		/// 无参构造函数
		/// </summary>
		public CMcuFormAVR8BitsForm()
		{
			InitializeComponent();
			//---限定最小尺寸
			this.MinimumSize = this.Size;
			//---修改自适应宽度的进度条
			this.toolStripProgressBar_ChipBar.Width += 28;
			this.toolStripProgressBar_ChipBar.Tag = this.toolStripProgressBar_ChipBar.Width.ToString();
			this.toolStrip_ChipTool.Tag = this.toolStrip_ChipTool.Width.ToString();
			//---窗体事件处理
			this.FormEventHandler();
		}

		/// <summary>
		/// 有参构造函数
		/// </summary>
		public CMcuFormAVR8BitsForm(CCommBase usedCComm, CMcuFuncAVR8BitsBase usedCMcuFunc)
		{
			InitializeComponent();
			//---限定最小尺寸
			this.MinimumSize = this.Size;
			//---修改自适应宽度的进度条
			this.toolStripProgressBar_ChipBar.Width += 28;
			this.toolStripProgressBar_ChipBar.Tag = this.toolStripProgressBar_ChipBar.Width.ToString();
			this.toolStrip_ChipTool.Tag = this.toolStrip_ChipTool.Width.ToString();
			//---检查通讯端口
			if (this.defaultCComm==usedCComm)
			{
				this.defaultCComm = new CCommBase();
			}
			//---通讯接口
			this.defaultCComm = usedCComm;
			//---检查设备函数
			if (this.defaultCMcuFunc==null)
			{
				this.defaultCMcuFunc = new CMcuFuncAVR8BitsBase();
			}
			//---校验类型
			if ((usedCMcuFunc!=null)&&(usedCMcuFunc.mMcuInfoParam.mTypeMcuInfo!=MCU_INFO_TYPE.MCU_AVR8BITS))
			{
				this.defaultCMcuFunc = usedCMcuFunc;
			}
			//---窗体事件处理
			this.FormEventHandler();
		}

		#endregion

		#region	析构函数

		/// <summary>
		/// 析构函数
		/// </summary>
		~CMcuFormAVR8BitsForm()
		{
			if (this.defaultCComm != null)
			{
				this.defaultCComm.Dispose();
			}
			//---垃圾回收
			GC.SuppressFinalize(this);
		}

		#endregion

		#region 公共函数

		#endregion

		#region 保护函数

		#endregion

		#region 私有函数

		/// <summary>
		/// 启动初始化
		/// </summary>
		private void StartupInit()
		{
			//---初始化MCU列表
			this.defaultCMcuFunc.mMcuInfoParam.McuListInfo(this.comboBox_ChipType);
			//---初始化MCU类型
			this.McuTypeChanged(this.comboBox_ChipType.Text.ToLower());
			//---初始化通信端口
			this.cCommBaseControl_ChipCOMM.Init(this.defaultCComm,this.cRichTextBoxEx_ChipMsg);
			//---初始化版本信息
			this.toolStripLabel_Version.Text =	this.defaultCMcuFunc.mSoftwareVersion[0].ToString("X2") + "-" + this.defaultCMcuFunc.mSoftwareVersion[1].ToString("X2") + "-" +
												this.defaultCMcuFunc.mSoftwareVersion[2].ToString("X2") + "-" + this.defaultCMcuFunc.mSoftwareVersion[3].ToString("X2");
			//--- 初始化当前系统时间
			this.toolStripLabel_ChipRTCTimer.Text = DateTime.Now.ToString();
			//---事件注册
			this.RegistrationEventHandler();

		}

		/// <summary>
		/// 窗体事件处理
		/// </summary>
		private void FormEventHandler()
		{
			//---窗体显示事件
			this.Shown += new System.EventHandler(this.Form_Shown);
			//---窗体尺寸事件
			this.Resize += new System.EventHandler(this.Form_Resize);
			//---窗体关闭事件
			this.FormClosing += new FormClosingEventHandler(this.Form_Closing);
		}

		/// <summary>
		/// 注册事件函数
		/// </summary>
		private void RegistrationEventHandler()
		{
			//---注册通讯端口的的同步
			this.cCommBaseControl_ChipCOMM.EventHandlerCCommSynchronized += this.CCOMMSynchronized;
			//---时间滴答
			this.timer_ChipRTCTime.Tick += new EventHandler(this.Timer_Tick);
			//---MCU类型发生变化
			this.comboBox_ChipType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			//---接口类型发生变化
			//this.comboBox_ChipInterface.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			this.button_SetChipInterface.Click += new EventHandler(this.Button_Click);
			//---Buton事件
			this.button_ReadChipID.Click += new EventHandler(this.Button_Click);
			this.button_ReadChipRefPWR.Click += new EventHandler(this.Button_Click);
			this.button_SetChipPWR.Click += new EventHandler(this.Button_Click);
			this.button_ReadChipPWR.Click += new EventHandler(this.Button_Click);
			this.button_SetChipClock.Click += new EventHandler(this.Button_Click);

			this.button_Erase.Click += new EventHandler(this.Button_Click);
			this.button_AutoChip.Click += new EventHandler(this.Button_Click);

			this.button_LoadFlashFile.Click += new EventHandler(this.Button_Click);
			this.button_LoadEepromFile.Click += new EventHandler(this.Button_Click);
			this.button_SaveFlashFile.Click += new EventHandler(this.Button_Click);
			this.button_SaveEepromFile.Click += new EventHandler(this.Button_Click);
			this.button_ChipAuto.Click += new EventHandler(this.Button_Click);
			this.button_EraseChip.Click += new EventHandler(this.Button_Click);
			this.button_CheckChipEmpty.Click += new EventHandler(this.Button_Click);
			this.button_ReadIDChip.Click += new EventHandler(this.Button_Click);
			this.button_ReadChipFlash.Click += new EventHandler(this.Button_Click);
			this.button_WriteChipFlash.Click += new EventHandler(this.Button_Click);
			this.button_CheckChipFlash.Click += new EventHandler(this.Button_Click);
			this.button_ReadChipEeprom.Click += new EventHandler(this.Button_Click);
			this.button_WriteChipEeprom.Click += new EventHandler(this.Button_Click);
			this.button_CheckChipEeprom.Click += new EventHandler(this.Button_Click);
			this.button_WriteChipFuse.Click += new EventHandler(this.Button_Click);
			this.button_WriteChipLock.Click += new EventHandler(this.Button_Click);
			this.button_ReadChipROM.Click += new EventHandler(this.Button_Click);

		}

		/// <summary>
		/// MCU的类型变换
		/// </summary>
		/// <param name="chipName"></param>
		private void McuTypeChanged(string chipName)
		{
			//---初始化芯片信息
			this.defaultCMcuFunc.mMcuInfoParam.McuTypeInfo(chipName, this.comboBox_ChipInterface,this.textBox_ChipID);
			//---依据芯片的类型进行控件的初始化
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.Init(this.defaultCMcuFunc, this.cRichTextBoxEx_ChipMsg);
			//-->>>依据芯片进行Memery的信息初始化---开始
			//---初始化Flash信息
			this.cHexBox_Flash.AddData(this.defaultCMcuFunc.mMcuInfoParam.mChipFlashByteSize);
			//---初始化Eeprom信息
			this.cHexBox_Eeprom.AddData(this.defaultCMcuFunc.mMcuInfoParam.mChipEepromByteSize);
			//---初始化ROM信息
			this.cHexBox_ROM.AddData(this.defaultCMcuFunc.mMcuInfoParam.mChipFlashPerPageByteNum);
			//--<<<依据芯片进行Memery的信息初始化---结束
			this.label_EepromSize.Text = "0/" + this.defaultCMcuFunc.mMcuInfoParam.mChipEepromByteSize.ToString();
			this.label_FlashSize.Text = "0/" + this.defaultCMcuFunc.mMcuInfoParam.mChipFlashByteSize.ToString();
		}

		/// <summary>
		/// 同步通讯端口,避免不同地方使用同一个端口，导致的通讯异常
		/// </summary>
		private void CCOMMSynchronized()
		{
			//---控件中使用的通讯端口
			this.defaultCComm = this.cCommBaseControl_ChipCOMM.mCCOMM;
			//---控件中使用的通讯端口
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.mCMcuFunc.mCCOMM = this.cCommBaseControl_ChipCOMM.mCCOMM;
			//---执行同步委托事件
			this.EventHandlerCCommSynchronized?.Invoke();
		}

		#endregion

		#region 事件函数

		/// <summary>
		/// 首次显示窗体时发生,在这个函数里面加载控件事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form_Shown(Object sender, EventArgs e)
		{
			Form fm = (Form)sender;
			switch (fm.Name)
			{
				case "CMcuFormAVR8BitsForm":
					this.StartupInit();
					break;
				default:
					break;
			}
			fm.Focus();
		}

		/// <summary>
		/// 窗体大小发生变化的时候
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form_Resize(object sender, EventArgs e)
		{
			Form fm = (Form)sender;
			switch (fm.Name)
			{
				case "CMcuFormAVR8BitsForm":
					int offset = (this.toolStrip_ChipTool.Size.Width - int.Parse(this.toolStrip_ChipTool.Tag.ToString()));
					//---判断大小
					if (offset > 0)
					{
						this.toolStripProgressBar_ChipBar.Width = int.Parse(this.toolStripProgressBar_ChipBar.Tag.ToString()) + offset;
					}
					else
					{
						if (this.toolStripProgressBar_ChipBar.Width != int.Parse(this.toolStripProgressBar_ChipBar.Tag.ToString()))
						{
							this.toolStripProgressBar_ChipBar.Width = int.Parse(this.toolStripProgressBar_ChipBar.Tag.ToString());
						}
					}
					break;
				default:
					break;
			}
			fm.Focus();
		}

		/// <summary>
		/// 窗体关闭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form_Closing(object sender, FormClosingEventArgs e)
		{
			Form fm = (Form)sender;
			//fm.Enabled = false;
			switch (fm.Name)
			{
				case "CMcuFormAVR8BitsForm":
					if (e.CloseReason == CloseReason.MdiFormClosing)
					{
						return;
					}
					else if (e.CloseReason == CloseReason.UserClosing)
					{
						if (DialogResult.OK == CMessageBoxPlus.Show(this, "你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
						{
							//---为保证Application.Exit();时不再弹出提示，所以将FormClosing事件取消
							this.FormClosing -= new FormClosingEventHandler(this.Form_Closing);
							//---检查通讯端口
							if (this.defaultCComm!= null)
							{
								//---关闭端口
								while (true)
								{
									if (this.defaultCComm.mCOMMSTATE == CCOMM_STATE.STATE_IDLE)
									{	
										break;
									}
									Application.DoEvents();
								}
								this.defaultCComm.CloseDevice();
							}
							//---确认关闭事件
							e.Cancel = false;
							//---退出当前窗体
							this.Dispose();
						}
						else
						{
							//---取消关闭事件
							e.Cancel = true;
						}
					}
					break;
				default:
					break;
			}
			//fm.Enabled = true;
			fm.Focus();
		}

		/// <summary>
		/// 定时器滴答
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Timer_Tick(object sender, EventArgs e)
		{
			if (sender==null)
			{
				return;
			}
			Timer timer = (Timer)sender;
			switch (timer.Tag.ToString())
			{
				case "timer_ChipRTCTime":
					this.toolStripLabel_ChipRTCTimer.Text = DateTime.Now.ToString();
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// ComboBox事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender==null)
			{
				return;
			}
			ComboBox cbb = (ComboBox)sender;
			//cbb.Enabled = false;
			switch (cbb.Name)
			{
				//---芯片类型发生变化
				case "comboBox_ChipType":
					if (!string.IsNullOrEmpty(this.comboBox_ChipType.Text))
					{
						if (this.comboBox_ChipType.Text!=this.defaultCMcuFunc.mMcuInfoParam.mTypeName)
						{
							this.McuTypeChanged(this.comboBox_ChipType.Text);
						}
					}
					break;
				//---芯片接口发生变化
				case "comboBox_ChipInterface":
					//if ((this.defaultCMcuFunc!=null)&&(this.comboBox_ChipInterface.SelectedIndex>=0))
					//{
					//	if (this.defaultCMcuFunc.mMcuInfoParam.mChipInterfaceName[this.comboBox_ChipInterface.SelectedIndex] == "JTAG")
					//	{
					//		this.defaultCMcuFunc = new CMcuFuncAVR8BitsJTAG(this.defaultCMcuFunc);
					//	}
					//	else if (this.defaultCMcuFunc.mMcuInfoParam.mChipInterfaceName[this.comboBox_ChipInterface.SelectedIndex] == "HVPP")
					//	{
					//		this.defaultCMcuFunc = new CMcuFuncAVR8BitsHVPP(this.defaultCMcuFunc);
					//	}
					//	else if (this.defaultCMcuFunc.mMcuInfoParam.mChipInterfaceName[this.comboBox_ChipInterface.SelectedIndex] == "HVSP")
					//	{
					//		this.defaultCMcuFunc = new CMcuFuncAVR8BitsHVSP(this.defaultCMcuFunc);
					//	}
					//	else
					//	{
					//		this.defaultCMcuFunc=new CMcuFuncAVR8BitsISP(this.defaultCMcuFunc);
					//	}
					//}
					break;
				default:
					break;
			}
			//cbb.Enabled = true;
			cbb.Focus();
		}

		/// <summary>
		/// Button事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button_Click(object sender, EventArgs e)
		{
			if (sender == null)
			{
				return;
			}
			if (this.defaultCComm.mIsOpen==false)
			{
				CMessageBoxPlus.Show(this, "通讯端口初始化异常!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Button bt = (Button)sender;
			//bt.Enabled = false;
			switch (bt.Name)
			{
				//---设备接口发生变化
				case "button_SetChipInterface":
					if (!string.IsNullOrEmpty(this.comboBox_ChipInterface.Text))
					{
						switch (this.comboBox_ChipInterface.Text.ToUpper())
						{
							case "ISP":
								if (this.defaultCMcuFunc.GetType() != typeof(CMcuFuncAVR8BitsISP))
								{
									this.defaultCMcuFunc = new CMcuFuncAVR8BitsISP(this.defaultCMcuFunc);
								}
								break;
							case "JTAG":
								if (this.defaultCMcuFunc.GetType() != typeof(CMcuFuncAVR8BitsJTAG))
								{
									this.defaultCMcuFunc = new CMcuFuncAVR8BitsJTAG(this.defaultCMcuFunc);
								}
								break;
							case "HVPP":
								if (this.defaultCMcuFunc.GetType() != typeof(CMcuFuncAVR8BitsHVPP))
								{
									this.defaultCMcuFunc = new CMcuFuncAVR8BitsHVPP(this.defaultCMcuFunc);
								}
								break;
							case "HVSP":
								if (this.defaultCMcuFunc.GetType() != typeof(CMcuFuncAVR8BitsHVSP))
								{
									this.defaultCMcuFunc = new CMcuFuncAVR8BitsHVSP(this.defaultCMcuFunc);
								}
								break;
							default:
								break;
						}
						this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.mCMcuFunc = this.defaultCMcuFunc;
					}
					else
					{
						CMessageBoxPlus.Show(this, "？？？不识别的编程接口", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
				//---读取外部供电电压
				case "button_ReadChipRefPWR":
				//---读取当前供电电压
				case "button_ReadChipPWR":
					break;
				//---设置供电电压
				case "button_SetChipPWR":
					break;
				//---设置编程时钟
				case "button_SetChipClock":
					break;
				//---加载Flash数据
				case "button_LoadFlashFile":
					this.defaultCMcuFunc.CMcuFunc_LoadFlashHexFile(this.cHexBox_Flash,this.label_FlashSize, cRichTextBoxEx_ChipMsg);
					break;
				//---加载Eeprom
				case "button_LoadEepromFile":
					this.defaultCMcuFunc.CMcuFunc_LoadEepromHexFile(this.cHexBox_Eeprom, this.label_EepromSize, cRichTextBoxEx_ChipMsg);
					break;
				//---保存Flash
				case "button_SaveFlashFile":
					this.defaultCMcuFunc.CMcuFunc_SaveFlashHexFile(this.cHexBox_Flash, cRichTextBoxEx_ChipMsg);
					break;
				//---保存EEPROM文件
				case "button_SaveEepromFile":
					this.defaultCMcuFunc.CMcuFunc_SaveEepromHexFile(this.cHexBox_Eeprom, this.cRichTextBoxEx_ChipMsg);
					break;
				//---自动
				case "button_AutoChip":
				case "button_ChipAuto":
					break;
				//---擦除
				case "button_Erase":
				case "button_EraseChip":
					this.defaultCMcuFunc.CMcuFunc_EraseChip(this.mLockFuse, this.cRichTextBoxEx_ChipMsg);
					break;
				case "button_CheckEmpty":
					break;
				//---读取识别字
				case "button_ReadIDChip":
				case "button_ReadChipID":
					this.defaultCMcuFunc.CMcuFunc_ReadChipID(this.cRichTextBoxEx_ChipMsg,this);
					break;
				//---读取Flash
				case "button_ReadChipFlash":
					this.defaultCMcuFunc.CMcuFunc_ReadChipFlash(this.cHexBox_Flash, this.cRichTextBoxEx_ChipMsg,this.toolStripLabel_ChipState, this.toolStripLabel_ChipTime, this.toolStripProgressBar_ChipBar);
					break;
				//---编程Flash
				case "button_WriteChipFlash":
					this.defaultCMcuFunc.CMcuFunc_WriteChipFlash(this.cHexBox_Flash, this.cRichTextBoxEx_ChipMsg,true,this.toolStripLabel_ChipState,this.toolStripLabel_ChipTime,this.toolStripProgressBar_ChipBar);
					break;
				//---校验Flash
				case "button_CheckChipFlash":
					this.defaultCMcuFunc.CMcuFunc_CheckChipFlash(this.cHexBox_Flash, this.cRichTextBoxEx_ChipMsg,this.toolStripLabel_ChipState, this.toolStripLabel_ChipTime, this.toolStripProgressBar_ChipBar);
					break;
				//---读取Eeprom
				case "button_ReadChipEeprom":
					this.defaultCMcuFunc.CMcuFunc_ReadChipEeprom(this.cHexBox_Eeprom, this.cRichTextBoxEx_ChipMsg,this.toolStripLabel_ChipState, this.toolStripLabel_ChipTime, this.toolStripProgressBar_ChipBar);
					break;
				//---编程Eeprom
				case "button_WriteChipEeprom":
					this.defaultCMcuFunc.CMcuFunc_WriteChipEeprom(this.cHexBox_Eeprom, this.cRichTextBoxEx_ChipMsg,this.toolStripLabel_ChipState, this.toolStripLabel_ChipTime, this.toolStripProgressBar_ChipBar);
					break;
				//---校验Eeprom
				case "button_CheckChipEeprom":
					this.defaultCMcuFunc.CMcuFunc_CheckChipEeprom(this.cHexBox_Eeprom, this.cRichTextBoxEx_ChipMsg,this.toolStripLabel_ChipState, this.toolStripLabel_ChipTime, this.toolStripProgressBar_ChipBar);
					break;
				//---编程熔丝位
				case "button_WriteChipFuse":
					this.defaultCMcuFunc.CMcuFunc_WriteChipFuse(this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.mCMcuFunc.mMcuInfoParam.mChipFuse,this.cRichTextBoxEx_ChipMsg);
					break;
				//---编程加密位
				case "button_WriteChipLock":
					this.defaultCMcuFunc.CMcuFunc_WriteChipLock(this.mLockFuse, this.cRichTextBoxEx_ChipMsg);
					break;
				//---读取ROM信息
				case "button_ReadChipROM":
					this.defaultCMcuFunc.CMcuFunc_ReadChipRom(this.cHexBox_ROM, this.cRichTextBoxEx_ChipMsg);
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

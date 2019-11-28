using Harry.LabTools.LabCommType;
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
		private CMcuFuncBase defaultCMcuFunc = new CMcuFuncAVR8BitsISP();

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
		public virtual CMcuFuncBase mCMcuFunc
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

			this.toolStripProgressBar_ChipBar.Width += 28;

			this.toolStripProgressBar_ChipBar.Tag = this.toolStripProgressBar_ChipBar.Width.ToString();
			this.toolStrip_ChipTool.Tag = this.toolStrip_ChipTool.Width.ToString();


			this.Shown += new System.EventHandler(this.Form_Shown);
		}

		/// <summary>
		/// 有参构造函数
		/// </summary>
		public CMcuFormAVR8BitsForm(CCommBase usedCComm, CMcuFuncBase usedCMcuFunc)
		{
			InitializeComponent();
			//---限定最小尺寸
			this.MinimumSize = this.Size;

			this.toolStripProgressBar_ChipBar.Width += 28;

			if (this.defaultCComm==usedCComm)
			{
				this.defaultCComm = new CCommBase();
			}
			this.defaultCComm = usedCComm;
			if (this.defaultCMcuFunc==null)
			{
				this.defaultCMcuFunc = new CMcuFuncBase();
			}
			this.defaultCMcuFunc = usedCMcuFunc;
			this.Shown += new System.EventHandler(this.Form_Shown);
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
			//---事件注册
			this.RegistrationEventHandler();

		}

		/// <summary>
		/// 事件注册函数
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

			
		}

		/// <summary>
		/// MCU的类型变换
		/// </summary>
		/// <param name="chipName"></param>
		private void McuTypeChanged(string chipName)
		{
			//---初始化芯片信息
			this.defaultCMcuFunc.mMcuInfoParam.McuTypeInfo(chipName, this.comboBox_ChipInterface);
			//---依据芯片的类型进行控件的初始化
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.Init(this.defaultCMcuFunc, this.cRichTextBoxEx_ChipMsg);
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
			this.StartupInit();
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
			cbb.Enabled = false;
			switch (cbb.Name)
			{
				//---芯片类型发生变化
				case "comboBox_ChipType":
					if (!string.IsNullOrEmpty(this.comboBox_ChipType.Text))
					{
						if (this.comboBox_ChipType.Text!=this.defaultCMcuFunc.mMcuInfoParam.TypeName)
						{
							this.McuTypeChanged(this.comboBox_ChipType.Text);
						}
					}
					break;
				//---芯片接口发生变化
				case "comboBox_ChipInterface":
					break;
				default:
					break;
			}

			cbb.Enabled = true;
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
			Button bt = (Button)sender;
			bt.Enabled = false;
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
					break;
				default:
					break;
			}

			bt.Enabled = true;
			bt.Focus();
		}
		#endregion

	}
}

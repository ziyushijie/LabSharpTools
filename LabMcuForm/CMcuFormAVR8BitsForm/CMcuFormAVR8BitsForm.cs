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
	public partial class CMcuFormAVR8BitsForm : Form
	{
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
		private void Startup()
		{
			//---初始化MCU类型
			this.McuTypeChanged("atmega8");
			//---事件注册
			this.timer_ChipRTCTime.Tick += new EventHandler(this.Timer_Tick);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
		}


		/// <summary>
		/// MCU的类型变换
		/// </summary>
		/// <param name="chipName"></param>
		private void McuTypeChanged(string chipName)
		{
			//---初始化芯片信息
			this.defaultCMcuFunc.mMcuInfoParam.McuTypeInfo(chipName);
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.Init(this.defaultCMcuFunc, this.cRichTextBoxEx_ChipMsg);
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
			this.Startup();
		}
		
		/// <summary>
		/// 定时器滴答
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void Timer_Tick(object sender, EventArgs e)
		{
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		#endregion


	}
}

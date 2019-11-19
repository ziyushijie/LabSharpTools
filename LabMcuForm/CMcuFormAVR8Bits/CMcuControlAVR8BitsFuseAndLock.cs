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

namespace LabMcuForm.CMcuFormAVR8Bits
{
	public partial class CMcuControlAVR8BitsFuseAndLock : UserControl
	{
		#region 变量定义
		
		/// <summary>
		/// MCU的参数
		/// </summary>
		private CMcuFuncBase defaultCMcuFunc = null;

		#endregion

		#region 属性定义

		#endregion

		#region 构造函数

		/// <summary>
		/// 无参数构造函数
		/// </summary>
		public CMcuControlAVR8BitsFuseAndLock()
		{
			InitializeComponent();
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
		public CMcuControlAVR8BitsFuseAndLock(CMcuFuncBase cMcuFunc)
		{
			InitializeComponent();
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

			((CMcuFuncInfoAVR8BitsParam)this.defaultCMcuFunc.mMcuInfoParam).FormControlInit(this.cCheckedListBoxEx_LowFuseBits, this.cCheckedListBoxEx_HighFuseBits, this.cCheckedListBoxEx_ExternFuseBits, this.cCheckedListBoxEx_LockFuseBits,
																							this.cCheckedListBoxEx_FuseText,
																							this.label_OSCText1, this.label_OSCText2, this.label_OSCText3, this.label_OSCText4,
																							this.textBox_OSCValue1, this.textBox_OSCValue2, this.textBox_OSCValue3, this.textBox_OSCValue4,
																							this.textBox_LowFuseValue, this.textBox_HighFuseValue, this.textBox_ExternFuseValue, this.textBox_LockFuseValue);
			
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
			
			this.label_OSCText1.Visible = false;
			this.label_OSCText2.Visible = false;
			this.label_OSCText3.Visible = false;
			this.label_OSCText4.Visible = false;

			this.textBox_OSCValue1.Visible = false;
			this.textBox_OSCValue2.Visible = false;
			this.textBox_OSCValue3.Visible = false;
			this.textBox_OSCValue4.Visible = false;

			this.textBox_LockFuseValue.Text = "00";
			this.textBox_HighFuseValue.Text = "00";
			this.textBox_ExternFuseValue.Text = "00";
			this.textBox_LockFuseValue.Text = "00";

		}


		

		#endregion

		#region 事件定义



		#endregion

	}
}

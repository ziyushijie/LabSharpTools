using Harry.LabTools.LabGenForm;
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
	public partial class CMcuFormAVR8BitsFuseAndLock:CMcuFormBase
	{

		#region 变量定义

		#endregion

		#region 属性定义

		private CMcuFuncBase usedMcu = new CMcuFuncBase();

		#endregion

		#region 构造函数

		/// <summary>
		/// 
		/// </summary>
		public CMcuFormAVR8BitsFuseAndLock()
		{
			InitializeComponent();
		}



		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			this.usedMcu.mMcuInfoParam.McuTypeInfo("atmega8");
			this.cMcuControlAVR8BitsFuseAndLock1.Init(this.usedMcu);
		}
	}
}

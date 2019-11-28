using Harry.LabTools.LabCommType;
using Harry.LabTools.LabMcuFunc;
using System;
using System.Windows.Forms;

namespace LabTestForm
{
	public partial class Form1 : Form
	{
		#region 变量定义
		
		/// <summary>
		/// 
		/// </summary>
		private CCommBase usedComm = null;

		/// <summary>
		/// 
		/// </summary>
		private CMcuFuncBase usedMcu = new CMcuFuncBase();

		#endregion

		#region 构造函数

		/// <summary>
		/// 
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		#endregion

		#region 事件函数

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			this.usedComm =new CCommSerial();
			this.cCommBaseControl1.Init(this.usedComm);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			this.usedMcu.mMcuInfoParam.McuTypeInfo("atmega8");
			this.usedMcu.mMcuInfoParam.McuListInfo();
		}

		#endregion

	}
}

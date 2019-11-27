using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabCommType
{
	public partial class CCommSerialFullControl : CCommSerialPlusControl
	{

		#region 变量定义

		#endregion

		#region 属性定义

		/// <summary>
		/// 获取设备的ID地址
		/// </summary>
		public virtual int mAddrID
		{
			get
			{
				return Convert.ToInt32(this.textBox_AddrID.Text);
			}
		}

		/// <summary>
		/// 获取接收CRC的校验方式
		/// </summary>
		public virtual CCOMM_CRC mRxCRC
		{
			get
			{
				CCOMM_CRC _return = CCOMM_CRC.CRC_NONE;
				switch (this.comboBox_RxCRC.Text)
				{

					case "CRC_NONE":
						_return = CCOMM_CRC.CRC_NONE;
						break;
					case "CRC_SUM":
						_return = CCOMM_CRC.CRC_CHECKSUM;
						break;
					case "CRC_CRC8":
						_return = CCOMM_CRC.CRC_CRC8;
						break;
					case "CRC_CRC16":
						_return = CCOMM_CRC.CRC_CRC16;
						break;
					case "CRC_CRC32":
						_return = CCOMM_CRC.CRC_CRC32;
						break;
					default:
						_return = CCOMM_CRC.CRC_NONE;
						break;
				}
				return _return;
			}
		}

		/// <summary>
		/// 获取发送CRC的校验方式
		/// </summary>
		public virtual CCOMM_CRC mTxCRC
		{
			get
			{
				CCOMM_CRC _return = CCOMM_CRC.CRC_NONE;
				switch (this.comboBox_RxCRC.Text)
				{

					case "CRC_NONE":
						_return = CCOMM_CRC.CRC_NONE;
						break;
					case "CRC_SUM":
						_return = CCOMM_CRC.CRC_CHECKSUM;
						break;
					case "CRC_CRC8":
						_return = CCOMM_CRC.CRC_CRC8;
						break;
					case "CRC_CRC16":
						_return = CCOMM_CRC.CRC_CRC16;
						break;
					case "CRC_CRC32":
						_return = CCOMM_CRC.CRC_CRC32;
						break;
					default:
						_return = CCOMM_CRC.CRC_NONE;
						break;
				}
				return _return;
			}
		}

		#endregion

		#region 构造函数

		/// <summary>
		/// 构造函数
		/// </summary>
		public CCommSerialFullControl() : base()
		{
			InitializeComponent();

			//---配置默认收发校验方式
			this.comboBox_RxCRC.SelectedIndex = 0;
			this.comboBox_TxCRC.SelectedIndex = 0;
		}
		#endregion

		#region 析构函数

		#endregion

		#region 公有函数

		/// <summary>
		/// 配置设备ID信息
		/// </summary>
		/// <param name="addrID"></param>
		public virtual void AnalyseAddrID(string addrID)
		{
			this.textBox_AddrID.Text = addrID;
		}

		/// <summary>
		/// 分析数据接收CRC的模式
		/// </summary>
		/// <param name="rxCRC"></param>
		public virtual void AnalyseRxCRC(int rxCRC)
		{
			if (rxCRC < 0)
			{

				this.comboBox_RxCRC.SelectedIndex = 0;
			}
			else
			{
				this.comboBox_RxCRC.SelectedIndex = rxCRC;
			}
		}

		/// <summary>
		/// 分析数据发送CRC的模式
		/// </summary>
		/// <param name="rxCRC"></param>
		public virtual void AnalyseTxCRC(int txCRC)
		{
			if (txCRC < 0)
			{

				this.comboBox_TxCRC.SelectedIndex = 0;
			}
			else
			{
				this.comboBox_TxCRC.SelectedIndex = txCRC;
			}
		}

		#endregion

		#region 保护函数

		#endregion

		#region 私有函数

		#endregion

		#region 事件函数
		
		#endregion

	}
}

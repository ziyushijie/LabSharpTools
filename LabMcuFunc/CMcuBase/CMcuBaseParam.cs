using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabMcu
{
	public partial class CMcuBase:IMcuInfoParam
	{
		#region 变量定义

		/// <summary>
		/// 编程接口名称
		/// </summary>
		private string[] defaultProgInterfaceName = new string[] { "ISP", "JTAG", "HVPP", "HVSP" };

		/// <summary>
		/// 支持的编程接口
		/// </summary>
		private byte[] defaultProgInterface = new byte[] { (byte)PROG_INTERFACE.ISP,(byte)PROG_INTERFACE.HVPP };

		/// <summary>
		/// 设备ID信息
		/// </summary>
		private byte[] defaultChipID = new byte[] { 0x1E, 0x93, 0x07 };

		/// <summary>
		/// 设备的JTAG的ID信息
		/// </summary>
		private int defaultIDChip = 0x00;

		/// <summary>
		/// 设备的熔丝位
		/// </summary>
		private byte[] defaultChipFuse = new byte[] { 0xE1, 0xD9 };

		/// <summary>
		/// 芯片的加密位
		/// </summary>
		private byte defaultChipLock = 0xFF;

		/// <summary>
		/// 芯片的Flash的页数
		/// </summary>
		private int defaultChipFlashPageNum = 128;

		/// <summary>
		/// 芯片Flash的每页字节数
		/// </summary>
		private int defaultChipFlashPerPageWordNum = 32;

		/// <summary>
		/// 芯片的Eeprom的页数
		/// </summary>
		private int defaultChipEepromPageNum = 128;

		/// <summary>
		/// 芯片Flash的每页字节数
		/// </summary>
		private int defaultChipEepromPerPageByteNum = 4;

		#endregion

		#region 属性定义

		/// <summary>
		/// 接口名称为只读属性
		/// </summary>
		public virtual string[] mProgInterfaceName
		{
			get
			{
				return this.defaultProgInterfaceName;
			}
		}
		
		/// <summary>
		/// 编程接口为只读属性
		/// </summary>
		public virtual byte[] ChipProgInterface
		{
			get
			{
				return this.defaultProgInterface;
			}
		}
		
		/// <summary>
		/// Chip的ID信息为读写属性
		/// </summary>
		public virtual byte[] ChipID
		{
			get
			{
				return this.defaultChipID;
			}
			set
			{
				if (value!=null)
				{
					this.defaultChipID = value;
				}
			}
		}

		/// <summary>
		/// JTAG的ID信息为读写属性
		/// </summary>
		public virtual int IDChip
		{
			get
			{
				return this.defaultIDChip;
			}
			set
			{
				this.defaultIDChip = value;
			}
		}

		/// <summary>
		/// 熔丝位为读写属性
		/// </summary>
		public virtual byte[] ChipFuse
		{
			get 
			{
				return this.defaultChipFuse;
			}
			set
			{
				if (value!=null)
				{
					this.defaultChipFuse = value;
				}
			}
		}

		/// <summary>
		/// 加密位为读写属性
		/// </summary>
		public virtual byte ChipLock
		{
			get
			{
				return this.defaultChipLock;
			}
			set
			{
				this.defaultChipLock = value;
			}
		}

		/// <summary>
		/// Flash的页数为读写属性
		/// </summary>
		public virtual int ChipFlashPageNum
		{
			get 
			{
				return this.defaultChipFlashPageNum;
			}
			set
			{
				this.defaultChipFlashPageNum = value;
			}
		}

		/// <summary>
		/// 每页Flash的字数为读写属性
		/// </summary>
		public virtual int ChipFlashPerPageWordNum
		{
			get
			{
				return this.defaultChipFlashPerPageWordNum;
			}
			set
			{
				this.defaultChipFlashPerPageWordNum = value;
			}
		}

		/// <summary>
		/// 每页Flash的字节数为只读属性
		/// </summary>
		public virtual int ChipFlashPerPageByteNum
		{
			get
			{
				return this.defaultChipFlashPerPageWordNum*2;
			}
		}

		/// <summary>
		/// Flash的总字节数为只读属性
		/// </summary>
		public virtual long ChipFlashByteSize
		{
			get
			{
				return (((long)this.defaultChipFlashPageNum) * this.defaultChipFlashPerPageWordNum * 2);
			}
		}

		/// <summary>
		/// Flash的总字数为只读属性
		/// </summary>
		public virtual long ChipFlashWordSize
		{
			get
			{
				return (((long)this.defaultChipFlashPageNum) * this.defaultChipFlashPerPageWordNum );
			}
		}

		/// <summary>
		/// Eeprom的页数为读写属性
		/// </summary>
		public virtual int ChipEepromPageNum
		{
			get 
			{
				return this.defaultChipEepromPageNum;
			}
			set
			{
				this.defaultChipEepromPageNum=value;
			}
		}

		/// <summary>
		/// Eeprom的每页字节数为读写属性
		/// </summary>
		public virtual int ChipEepromPerPageByteNum
		{
			get
			{
				return this.defaultChipEepromPerPageByteNum;
			}
			set
			{
				this.defaultChipEepromPerPageByteNum = value;
			}
		}

		/// <summary>
		/// Eeprom的总字节数为读写属性
		/// </summary>
		public virtual long ChipEepromByteSize
		{
			get
			{
				return ((long)this.defaultChipEepromPageNum) * this.defaultChipEepromPerPageByteNum;
			}
		}

		#endregion

		#region 构造函数

		#endregion

		#region 公有函数

		/// <summary>
		/// 解析Mcu的信息
		/// </summary>
		/// <returns></returns>
		public virtual int AnalyseMMcuInfo()
		{
			return 0;
		}

		#endregion

		#region 私有函数

		#endregion

		#region 事件函数

		#endregion
	}
}


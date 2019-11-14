using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabMcuFunc
{
	/// <summary>
	/// 芯片的基本信息
	/// </summary>
	public class CMcuInfoAVR8BitsParam: CBaseMcuInfoBaseParam,IAVR8BitsMcuInfoParam 
	{
		#region 变量定义

		/// <summary>
		/// 编程接口名称
		/// </summary>
		/// { "ISP", "JTAG", "HVPP", "HVSP" };
		private string[] defaultProgInterfaceName = new string[] { "ISP", "HVPP" };

		/// <summary>
		/// 支持的编程接口
		/// </summary>
		private byte[] defaultProgInterface = new byte[] { (byte)AVR8BITS_PROG_INTERFACE.ISP, (byte)AVR8BITS_PROG_INTERFACE.HVPP };

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

		/// <summary>
		/// 设备的校准字
		/// </summary>
		private CAVR8BitsMcFuseInfo defaultChipOSC = null;

		/// <summary>
		/// 低位熔丝位
		/// </summary>
		private CAVR8BitsMcFuseInfo defaultChipLowFuse = null;

		/// <summary>
		/// 高位熔丝位
		/// </summary>
		private CAVR8BitsMcFuseInfo defaultChipHighFuse = null;

		/// <summary>
		/// 拓展位熔丝位
		/// </summary>
		private CAVR8BitsMcFuseInfo defaultChipExternFuse = null;

		/// <summary>
		/// 加密位熔丝位
		/// </summary>
		private CAVR8BitsMcFuseInfo defaultChipLockFuse = null;

		#endregion

		#region 属性定义

		/// <summary>
		/// 接口名称为只读属性
		/// </summary>
		public virtual string[] ChipProgInterfaceName
		{
			get
			{
				return this.defaultProgInterfaceName;
			}
			set
			{
				if (value != null)
				{
					this.defaultProgInterfaceName = new string[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultProgInterfaceName, value.Length);
				}
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
			set
			{
				if (value != null)
				{
					this.defaultProgInterface = new byte[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultProgInterface, value.Length);
				}
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
				if (value != null)
				{
					this.defaultChipID = new byte[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultChipID, value.Length);
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
				if (value != null)
				{
					this.defaultChipFuse = new byte[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultChipFuse, value.Length);
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
				return this.defaultChipFlashPerPageWordNum * 2;
			}
		}

		/// <summary>
		/// 芯片ROM页的字大小为只读属性
		/// </summary>
		public virtual int ChipRomWordSize
		{
			get
			{
				return this.defaultChipFlashPerPageWordNum;
			}
		}

		/// <summary>
		/// ROM页的字节大小为只读属性
		/// </summary>
		public virtual int ChipRomByteSize
		{
			get
			{
				return this.defaultChipFlashPerPageWordNum * 2;
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
				return (((long)this.defaultChipFlashPageNum) * this.defaultChipFlashPerPageWordNum);
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
				this.defaultChipEepromPageNum = value;
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

		/// <summary>
		/// 内部OSC的校准字为读写属性
		/// </summary>
		public CAVR8BitsMcFuseInfo ChipOSC
		{
			get
			{
				return this.defaultChipOSC;
			}
			set
			{
				if (this.defaultChipOSC == null)
				{
					this.defaultChipOSC = new CAVR8BitsMcFuseInfo(value);
				}
				else
				{
					this.defaultChipOSC.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位低位值为读写属性
		/// </summary>
		public CAVR8BitsMcFuseInfo ChipLowFuse
		{
			get
			{
				return this.defaultChipLowFuse;
			}
			set
			{
				if (this.defaultChipLowFuse == null)
				{
					this.defaultChipLowFuse = new CAVR8BitsMcFuseInfo(value);
				}
				else
				{
					this.defaultChipLowFuse.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位高位值为读写属性
		/// </summary>
		public CAVR8BitsMcFuseInfo ChipHighFuse
		{
			get
			{
				return this.defaultChipHighFuse;
			}
			set
			{
				if (this.defaultChipHighFuse == null)
				{
					this.defaultChipHighFuse = new CAVR8BitsMcFuseInfo(value);
				}
				else
				{
					this.defaultChipHighFuse.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位拓展位值为读写属性
		/// </summary>
		public CAVR8BitsMcFuseInfo ChipExternFuse
		{
			get
			{
				return this.defaultChipExternFuse;
			}
			set
			{
				if (this.defaultChipExternFuse == null)
				{
					this.defaultChipExternFuse = new CAVR8BitsMcFuseInfo(value);
				}
				else
				{
					this.defaultChipExternFuse.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位加密位值为读写属性
		/// </summary>
		public CAVR8BitsMcFuseInfo ChipLockFuse
		{
			get
			{
				return this.defaultChipLockFuse;
			}
			set
			{
				if (this.defaultChipLockFuse == null)
				{
					this.defaultChipLockFuse = new CAVR8BitsMcFuseInfo(value);
				}
				else
				{
					this.defaultChipLockFuse.Init(value);
				}
			}
		}

		#endregion

		#region 构造函数

		/// <summary>
		/// 无参数的构造函数
		/// </summary>
		public CMcuInfoAVR8BitsParam()
		{
			
		}

		#endregion

		#region 公有函数
		
		/// <summary>
		/// 解析AVR的8Bits的MCU的信息
		/// </summary>
		/// <param name="chipName">设备名称</param>
		/// <returns>true---合格，False---失败</returns>
		public virtual bool AnalyseAVR8BitsMcuInfo(string chipName)
		{
			return true;
		}


		#endregion

		#region 私有函数

		#endregion

		#region 事件函数

		#endregion
	}
}

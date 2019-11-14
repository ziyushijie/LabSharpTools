using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabMcuFunc
{
	/// <summary>
	/// AVR的8BitsMcu的编程接口类型
	/// </summary>
	public enum AVR8BITS_PROG_INTERFACE : byte
	{
		ISP  = 0,			 //---串行编程
		JTAG = 1,			 //---JTAG编程
		HVPP = 2,            //---高压并行编程
		HVSP = 3,            //---高压串行编程
	};

	#region 熔丝类定义

	/// <summary>
	/// 芯片熔丝位和加密位的信息
	/// </summary>
	public class CAVR8BitsMcFuseInfo
	{
		#region 变量定义

		/// <summary>
		/// 名称
		/// </summary>
		private string[] defaultText = null;

		/// <summary>
		/// 值
		/// </summary>
		private int[] defaultValue = null;

		/// <summary>
		/// Msks值
		/// </summary>
		private int[] defaultMask = null;

		/// <summary>
		/// 信息名称
		/// </summary>
		private string defaultName = "";

		#endregion

		#region 属性定义

		/// <summary>
		/// 名称为读写属性
		/// </summary>
		public virtual string[] mText
		{
			get
			{
				return this.defaultText;
			}
			set
			{
				if (value != null)
				{
					this.defaultText = new string[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultText, value.Length);
				}
			}
		}

		/// <summary>
		/// 值为读写属性
		/// </summary>
		public virtual int[] mValue
		{
			get
			{
				return this.defaultValue;
			}
			set
			{
				if (value != null)
				{
					this.defaultValue = new int[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultValue, value.Length);
				}
			}
		}

		/// <summary>
		/// Mask值为读写属性
		/// </summary>
		public virtual int[] mMask
		{
			get
			{
				return this.defaultMask;
			}
			set
			{
				if (value != null)
				{
					this.defaultMask = new int[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultMask, value.Length);
				}
			}
		}

		/// <summary>
		/// 信息属性为读写属性
		/// </summary>
		public virtual string mName
		{
			get
			{
				return this.defaultName;
			}
			set
			{
				this.defaultName = value;
			}
		}

		#endregion

		#region 构造函数

		/// <summary>
		/// 参数可为空的构造构造函数
		/// </summary>
		public CAVR8BitsMcFuseInfo(string name = "")
		{
			this.defaultText	= null;
			this.defaultValue	= null;
			this.defaultMask	= null;
			this.defaultName	= name;
		}

		/// <summary>
		/// 有参数的构造函数
		/// </summary>
		/// <param name="cMcuBits"></param>
		public CAVR8BitsMcFuseInfo( CAVR8BitsMcFuseInfo cMcuBits)
		{
			this.mText	= cMcuBits.mText;
			this.mValue = cMcuBits.mValue;
			this.mMask	= cMcuBits.mMask;
			this.mName	= cMcuBits.mName;
		}

		#endregion

		#region 公有函数

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool Init(string name = "")
		{
			this.defaultText = null;
			this.defaultValue = null;
			this.defaultMask = null;
			this.defaultName = name;
			return true;
		}

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="cMcuBits"></param>
		/// <returns></returns>
		public bool Init(CAVR8BitsMcFuseInfo cMcuBits)
		{
			this.mText = cMcuBits.mText;
			this.mValue = cMcuBits.mValue;
			this.mMask = cMcuBits.mMask;
			this.mName = cMcuBits.mName;
			return true;
		}


		#endregion

		#region 私有函数

		#endregion

		#region 事件函数

		#endregion
	}
	
	#endregion

	#region 接口定义

	/// <summary>
	/// Mcu的基本信息参数
	/// </summary>
	interface IAVR8BitsMcuInfoParam
	{
		#region 属性参数
	
		/// <summary>
		/// 编程接口名称
		/// </summary>
		string[] ChipProgInterfaceName
		{
			get;
			set;
		}

		/// <summary>
		/// 芯片的编程接口
		/// </summary>
		byte[] ChipProgInterface
		{
			get;
			set;
		}

		/// <summary>
		/// 设备的ID信息
		/// </summary>
		byte[] ChipID
		{
			get;
			set;
		}

		/// <summary>
		/// 设备的JTAG的信息
		/// </summary>
		int IDChip
		{
			get;
			set;
		}

		/// <summary>
		/// 设备的熔丝位
		/// </summary>
		byte[] ChipFuse
		{
			get;
			set;
		}

		/// <summary>
		/// 设备的加密位
		/// </summary>
		byte ChipLock
		{
			get;
			set;
		}

		/// <summary>
		/// Flash的页数
		/// </summary>
		int ChipFlashPageNum
		{
			get;
			set;
		}

		/// <summary>
		/// Flash的每页的字大小
		/// </summary>
		int ChipFlashPerPageWordNum
		{
			get;
			set;
		}

		/// <summary>
		/// Flash的每页的字大小
		/// </summary>
		int ChipFlashPerPageByteNum
		{
			get;
		}

		/// <summary>
		/// 芯片ROM页的字大小
		/// </summary>
		int ChipRomWordSize
		{
			get;
		}

		/// <summary>
		/// ROM页的字节大小
		/// </summary>
		int ChipRomByteSize
		{
			get;
		}

		/// <summary>
		/// Flash的字节大小
		/// </summary>
		long ChipFlashByteSize
		{
			get;
		}

		/// <summary>
		/// Flash的字大小
		/// </summary>
		long ChipFlashWordSize
		{
			get;
		}

		/// <summary>
		/// Eeprom的页数
		/// </summary>
		int ChipEepromPageNum
		{
			get;
			set;
		}

		/// <summary>
		/// Eeprom的每页的字节数
		/// </summary>
		int ChipEepromPerPageByteNum
		{
			get;
			set;
		}

		/// <summary>
		/// Eeprom的字节大小
		/// </summary>
		long ChipEepromByteSize
		{
			get;
		}

		/// <summary>
		/// 设备的校准字
		/// </summary>
		CAVR8BitsMcFuseInfo ChipOSC
		{
			get;
			set;
		}

		/// <summary>
		/// 低位熔丝位
		/// </summary>
		CAVR8BitsMcFuseInfo ChipLowFuse
		{
			get;
			set;
		}
		/// <summary>
		/// 高位熔丝位
		/// </summary>
		CAVR8BitsMcFuseInfo ChipHighFuse
		{
			get;
			set;
		}
		/// <summary>
		/// 拓展位熔丝位
		/// </summary>
		CAVR8BitsMcFuseInfo ChipExternFuse
		{
			get;
			set;
		}
		/// <summary>
		/// 加密位熔丝位
		/// </summary>
		CAVR8BitsMcFuseInfo ChipLockFuse
		{
			get;
			set;
		}

		#endregion

		#region 函数定义

		/// <summary>
		/// 解析AVR的8Bits的MCU的信息
		/// </summary>
		/// <param name="chipName"></param>
		/// <returns>true---合格，False---失败</returns>
		bool AnalyseAVR8BitsMcuInfo(string chipName);

		#endregion
	}

	#endregion
}

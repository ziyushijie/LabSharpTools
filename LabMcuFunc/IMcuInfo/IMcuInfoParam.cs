using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabMcu
{
	/// <summary>
	/// 编程接口类型
	/// </summary>
	public enum PROG_INTERFACE : byte
	{
		ISP  = 0,			 //---串行编程
		JTAG = 1,			 //---JTAG编程
		HVPP = 2,            //---高压并行编程
		HVSP = 3,            //---高压串行编程
	};
	
	/// <summary>
	/// Mcu的基本信息参数
	/// </summary>
	interface IMcuInfoParam
	{
		#region 属性参数
	
		/// <summary>
		/// 芯片的编程接口
		/// </summary>
		byte[] ChipProgInterface
		{
			get;
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

		#endregion

	}
}

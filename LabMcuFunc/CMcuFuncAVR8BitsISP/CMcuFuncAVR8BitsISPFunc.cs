using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabMcuFunc
{

	#region 使用的编程命令

	/// <summary>
	/// ISP编程使用的枚举变量
	/// </summary>
	public enum CMCUFUNC_CMD_ISP : byte 
	{
		CMD_ISP_OPEN_CLOSE				=0x10,
		CMD_ISP_ERASE					=0x11,
		CMD_ISP_FLASH_PAGE_READ			=0x12,
		CMD_ISP_FLASH_PAGE_WRITE		=0x13,
		CMD_ISP_EEPROM_PAGE_READ		=0x14,
		CMD_ISP_EEPROM_PAGE_WRITE		=0x15,
		CMD_ISP_FUSE_LOCK_READ			=0x16,
		CMD_ISP_FUSE_WRITE				=0x17,
		CMD_ISP_LOCK_WRITE				=0x18,
		CMD_ISP_ID_READ					=0x19,
		CMD_ISP_CALIBRATIONBYTE_READ	=0x1A,
		CMD_ISP_ROM_PAGE_READ			=0x1B,
		CMD_ISP_PROG_CLOCK_SET			=0x1C
	}

	#endregion

	public partial class CMcuFuncAVR8BitsISP  
	{
		#region 变量定义

		#endregion

		#region 属性定义

		#endregion

		#region 构造函数

		#endregion

		#region 公有函数

		#region 编程常规使用函数

		/// <summary>
		/// 打开连接
		/// </summary>
		/// <returns></returns>
		public override int CMcuFunc_OpenConnect()
		{
			int _return = -1;
			if ((this.mComm != null) && (this.mComm.IsOpen == true))
			{

			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			return _return;
		}

		/// <summary>
		/// 关闭连接
		/// </summary>
		/// <returns></returns>
		public override int CMcuFunc_CloseConnect()
		{
			return -1;
		}


		/// <summary>
		/// 芯片擦除
		/// </summary>
		/// <returns></returns>
		public override int CMcuFunc_EraseChip()
		{
			return -1;
		}

		/// <summary>
		/// 读取Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFlash(ref byte[] chipFlash)
		{
			return -1;
		}

		/// <summary>
		/// 编程Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipFlash(byte[] chipFlash)
		{
			return -1;
		}

		/// <summary>
		/// 读取Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipEeprom(ref byte[] chipEeprom)
		{
			return -1;
		}

		/// <summary>
		/// 编程Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipEeprom(byte[] chipEeprom)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFuse(ref byte[] chipFuse)
		{
			return -1;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipLock(ref byte chipLock)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipFuse(byte[] chipFuse)
		{
			return -1;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipLock(byte chipLock)
		{
			return -1;
		}

		/// <summary>
		/// 读取芯片的ID信息
		/// </summary>
		/// <param name="chipID"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipID(ref byte[] chipID)
		{
			return -1;
		}

		/// <summary>
		/// 读取校准字
		/// </summary>
		/// <param name="chipCalibration"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipCalibration(ref byte[] chipCalibration)
		{
			return -1;
		}

		/// <summary>
		/// 读取ROM信息
		/// </summary>
		/// <param name="chipRom"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipRom(ref byte[] chipRom)
		{
			return -1;
		}

		/// <summary>
		/// 编程时钟设置
		/// </summary>
		/// <param name="chipClock"></param>
		/// <returns></returns>
		public override int CMcuFunc_SetProg(byte chipClock)
		{
			return -1;
		}

		#endregion

		#endregion

		#region 私有函数

		#endregion

		#region 事件函数

		#endregion
	}
}

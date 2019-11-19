using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabMcuFunc
{
	public partial class CMcuFuncBase
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
		public virtual int CMcuFunc_OpenConnect()
		{
			return -1;
		}

		/// <summary>
		/// 关闭连接
		/// </summary>
		/// <returns></returns>
		public virtual int CMcuFunc_CloseConnect()
		{
			return -1;
		}


		/// <summary>
		/// 芯片擦除
		/// </summary>
		/// <returns></returns>
		public virtual int CMcuFunc_EraseChip()
		{
			return -1;
		}

		/// <summary>
		/// 读取Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipFlash(ref byte[] chipFlash)
		{
			return -1;
		}

		/// <summary>
		/// 编程Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipFlash( byte[] chipFlash)
		{
			return -1;
		}

		/// <summary>
		/// 读取Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipEeprom(ref byte[] chipEeprom)
		{
			return -1;
		}

		/// <summary>
		/// 编程Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipEeprom(byte[] chipEeprom)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipFuse(ref byte[] chipFuse)
		{
			return -1;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipLock(ref byte chipLock)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipFuse( byte[] chipFuse)
		{
			return -1;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipLock( byte chipLock)
		{
			return -1;
		}

		/// <summary>
		/// 读取芯片的ID信息
		/// </summary>
		/// <param name="chipID"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipID(ref byte[] chipID)
		{
			return -1;
		}

		/// <summary>
		/// 读取校准字
		/// </summary>
		/// <param name="chipCalibration"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipCalibration(ref byte[] chipCalibration)
		{
			return -1;
		}

		/// <summary>
		/// 读取ROM信息
		/// </summary>
		/// <param name="chipRom"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipRom(ref byte[] chipRom)
		{
			return -1;
		}

		/// <summary>
		/// 编程时钟设置
		/// </summary>
		/// <param name="chipClock"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_SetProg(byte chipClock)
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabMcuFunc
{
	public  class CMcuFuncInfoBaseParam
	{
		#region 变量定义

		#endregion

		#region 属性定义

		/// <summary>
		/// 芯片类型
		/// </summary>
		public virtual string TypeChip
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>
		/// 芯片名称
		/// </summary>
		public virtual string TypeName
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>
		/// Flash存储器的字节数
		/// </summary>
		public virtual long TypeFlashByteNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Flash存储器的页数
		/// </summary>
		public virtual int TypeFlashPageNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Flash存储器的每页的字数
		/// </summary>
		public virtual int TypeFlashPerPageWordNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Flash存储器的每页的字数
		/// </summary>
		public virtual int TypeFlashPerPageByteNum
		{
			get
			{
				return (this.TypeFlashPerPageWordNum*2);
			}
		}

		/// <summary>
		/// Eeprom存储器的字节数
		/// </summary>
		public virtual int TypeEepromByteNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Eeprom存储器的页数
		/// </summary>
		public virtual int TypeEepromPageNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Eeprom存储器的每页的字数
		/// </summary>
		public virtual int TypeEepromPerPageByteNum
		{
			get
			{
				return 0;
			}
		}

		#endregion

		#region 构造函数

		/// <summary>
		/// 构造函数
		/// </summary>
		public CMcuFuncInfoBaseParam()
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cMcuFuncInfoBaseParam"></param>
		public CMcuFuncInfoBaseParam(CMcuFuncInfoBaseParam cMcuFuncInfoBaseParam)
		{
			
		}

		#endregion

		#region 公有函数

	/// <summary>
	/// 初始化类型MCU的信息
	/// </summary>
	/// <param name="chipName"></param>
	/// <returns></returns>
	public virtual bool McuTypeInfo(string chipName, ComboBox cbbInterface=null)
		{
			return false;			
		}

		/// <summary>
		/// 初始化MCU类型列表
		/// </summary>
		/// <param name="chipName"></param>
		/// <returns></returns>
		public virtual string[] McuListInfo(ComboBox cbbList=null)
		{
			return null;
		}

	
		/// <summary>
		/// 获取默认熔丝位
		/// </summary>
		/// <returns></returns>
		public virtual int[] McuDefaultFuseInfo()
		{
			return null;
		}

		/// <summary>
		/// MCU的接口信息
		/// </summary>
		/// <param name="chipName"></param>
		/// <returns></returns>
		public virtual bool McuInterfaceInfo(ComboBox cbbInterface)
		{
			return false;
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

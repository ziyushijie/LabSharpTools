using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabMcuFunc
{
	public  class CMcuFuncInfoBaseParam:ICloneable
	{
		#region 变量定义

		#endregion

		#region 属性定义

		/// <summary>
		/// 芯片类型
		/// </summary>
		public virtual string mTypeChip
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>
		/// 芯片名称
		/// </summary>
		public virtual string mTypeName
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>
		/// Flash存储器的字节数
		/// </summary>
		public virtual long mTypeFlashByteNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Flash存储器的页数
		/// </summary>
		public virtual int mTypeFlashPageNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Flash存储器的每页的字数
		/// </summary>
		public virtual int mTypeFlashPerPageWordNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Flash存储器的每页的字数
		/// </summary>
		public virtual int mTypeFlashPerPageByteNum
		{
			get
			{
				return (this.mTypeFlashPerPageWordNum*2);
			}
		}

		/// <summary>
		/// Eeprom存储器的字节数
		/// </summary>
		public virtual int mTypeEepromByteNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Eeprom存储器的页数
		/// </summary>
		public virtual int mTypeEepromPageNum
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Eeprom存储器的每页的字数
		/// </summary>
		public virtual int mTypeEepromPerPageByteNum
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

		#region 克隆函数

		/// <summary>
		/// 克隆对象
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return this as object;
		}

		/// <summary>
		/// 克隆
		/// </summary>
		/// <returns></returns>
		object ICloneable.Clone()
		{
			return this.Clone();
		}

		#endregion
	}
}

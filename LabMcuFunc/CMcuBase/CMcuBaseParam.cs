using Harry.LabTools.LabComm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabMcuFunc
{

	/// <summary>
	/// 支持的MCU类型
	/// </summary>
	public enum MCU_INFO_TYPE : int
	{
		AVR8BITS = 0,            //---AVR的8BIT的MCU
	};

	/// <summary>
	/// 这里主要是解析设备的参数信息
	/// </summary>
	public partial class CMcuBase
	{
		#region 变量定义
		
		/// <summary>
		/// 使用MCU的类型
		/// </summary>
		private MCU_INFO_TYPE defaultMcuInfoType = MCU_INFO_TYPE.AVR8BITS;

		/// <summary>
		/// 使用的通讯端口信息
		/// </summary>
		private CCommBase defaultUsedComm = null;


		#endregion

		#region 属性定义

		/// <summary>
		/// mcu的类型为读写属性
		/// </summary>
		public virtual MCU_INFO_TYPE mMcuInfoType
		{
			get
			{
				return this.defaultMcuInfoType;
			}
			set
			{
				this.defaultMcuInfoType = value;
			}
		}

		/// <summary>
		/// 通讯使用的端口为读写属性
		/// </summary>
		public virtual CCommBase mUsedComm
		{
			get
			{
				return this.defaultUsedComm;
			}
			set
			{
				if (value == null)
				{
					this.defaultUsedComm = new CCommBase();
				}
				this.defaultUsedComm = value;
			}
		}

		#endregion

		#region 构造函数

		/// <summary>
		/// 带参数的构造函数
		/// </summary>
		/// <param name="usedComm">使用的通讯端口</param>
		public CMcuBase(CCommBase usedComm)
		{
			if (usedComm!=null)
			{
				if (this.defaultUsedComm==null)
				{
					this.defaultUsedComm = new CCommBase();
				}
				this.defaultUsedComm = usedComm;
			}
		}

		#endregion

		#region 公有函数

		#endregion

		#region 私有函数

		#endregion

		#region 事件函数

		#endregion
	}
}


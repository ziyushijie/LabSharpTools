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
	public partial class CMcuFuncBase
	{
		#region 变量定义
		
		/// <summary>
		/// 使用MCU的类型
		/// </summary>
		private MCU_INFO_TYPE defaultMcuInfoType = MCU_INFO_TYPE.AVR8BITS;

		/// <summary>
		/// 使用的通讯端口信息
		/// </summary>
		private CCommBase defaultComm = null;

		/// <summary>
		/// 使用的MCU信息,默认初始化AVR的8Bit的Mcu
		/// </summary>
		private CMcuFuncInfoBaseParam defaultMcuInfoParam =null;

		/// <summary>
		/// 消息显示信息
		/// </summary>
		private string defaultMsgText = string.Empty;

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
		public virtual CCommBase mComm
		{
			get
			{
				return this.defaultComm;
			}
			set
			{
				if (value == null)
				{
					this.defaultComm = new CCommBase();
				}
				this.defaultComm = value;
			}
		}

		/// <summary>
		/// 使用的MCU参数
		/// </summary>
		public virtual CMcuFuncInfoBaseParam mMcuInfoParam
		{
			get
			{
				return this.defaultMcuInfoParam;
			}
			set
			{
				if (value==null)
				{
					this.defaultMcuInfoParam = new CMcuFuncInfoBaseParam();
				}
				this.defaultMcuInfoParam = value;
			}
		}

		/// <summary>
		/// 消息提示
		/// </summary>
		public virtual string mMsgText
		{
			get
			{
				return this.defaultMsgText;			
			}
			set
			{
				this.defaultMsgText = value;
			}
		}

		#endregion

		#region 构造函数

		/// <summary>
		/// 带参数的构造函数
		/// </summary>
		/// <param name="usedComm">使用的通讯端口</param>
		public CMcuFuncBase(CCommBase usedComm)
		{
			if (usedComm!=null)
			{
				if (this.defaultComm==null)
				{
					this.defaultComm = new CCommBase();
				}
				this.defaultComm = usedComm;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="mcuInfoParam"></param>
		public CMcuFuncBase(CMcuFuncInfoBaseParam mcuInfoParam)
		{
			if (mcuInfoParam != null)
			{
				if (this.defaultMcuInfoParam == null)
				{
					this.defaultMcuInfoParam = new CMcuFuncInfoBaseParam();
				}
				this.defaultMcuInfoParam = mcuInfoParam;
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


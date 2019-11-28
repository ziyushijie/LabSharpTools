using Harry.LabTools.LabCommType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabMcuFunc
{
	public partial class CMcuFuncAVR8BitsJTAG
	{
		#region 变量定义

		#endregion

		#region 属性定义
		/// <summary>
		/// mcu的类型为读写属性
		/// </summary>
		public override MCU_INFO_TYPE mMcuInfoType
		{
			get
			{
				return base.mMcuInfoType;
			}
			set
			{
				base.mMcuInfoType = value;
			}
		}

		/// <summary>
		/// 通讯使用的端口为读写属性
		/// </summary>
		public override CCommBase mCCOMM
		{
			get
			{
				return base.mCCOMM;
			}
			set
			{
				base.mCCOMM = value;
			}
		}

		/// <summary>
		/// 使用的MCU参数
		/// </summary>
		public override CMcuFuncInfoBaseParam mMcuInfoParam
		{
			get
			{
				return base.mMcuInfoParam;
			}
			set
			{
				base.mMcuInfoParam = value;
			}
		}

		/// <summary>
		/// 消息提示
		/// </summary>
		public override string mMsgText
		{
			get
			{
				return base.mMsgText;
			}
			set
			{
				base.mMsgText = value;
			}
		}


		#endregion

		#region 构造函数

		/// <summary>
		/// 有参数构造函数
		/// </summary>
		public CMcuFuncAVR8BitsJTAG(CMcuFuncBase cMcuFunc)
		{
			this.mMcuInfoType = cMcuFunc.mMcuInfoType;
			this.mCCOMM = cMcuFunc.mCCOMM;
			this.mMcuInfoParam = cMcuFunc.mMcuInfoParam;
			this.mMsgText = cMcuFunc.mMsgText;
			this.mSoftwareVersion = cMcuFunc.mSoftwareVersion;
			this.mHardwareVersion = cMcuFunc.mHardwareVersion;
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

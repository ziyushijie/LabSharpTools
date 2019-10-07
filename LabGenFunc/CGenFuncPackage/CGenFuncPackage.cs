
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harry.LabTools.LabGenFunc
{
	public partial class CGenFuncPackage
	{
		#region 函数定义

		/// <summary>
		/// 对数据进行打包处理，不足一包的进行整包处理，并填充为指定数据
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="packageSize"></param>
		/// <param name="val"></param>
		public static byte[][] GenFuncPackage( byte[] buffer, int packageSize, byte val = 0xFF)
		{
			byte[][] _return = null;
			//---计算包总数
			int packageNum = buffer.Length / packageSize;
			if ((buffer.Length%packageSize)!=0)
			{
				packageNum += 1;
			}
			//---申请缓存空间
			_return = new byte[packageNum][];
			//---数据进行分包处理
			for (int i = 0; i < packageNum; i++)
			{
				_return[i] = new byte[packageSize];
				//---判断是不是最后一包
				if (i==(packageNum-1))
				{
					CGenFuncMem.GenFuncMemset(ref _return[i]);
				}
			}

			return _return;
		}

		#endregion
	}
}

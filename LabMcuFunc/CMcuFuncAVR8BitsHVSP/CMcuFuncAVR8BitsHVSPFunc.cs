using Harry.LabTools.LabControlPlus;
using Harry.LabTools.LabHexEdit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabMcuFunc
{
	public partial class CMcuFuncAVR8BitsHVSP 
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
		public override int CMcuFunc_OpenConnect( RichTextBox msg)
		{
			int _return = -1;
			if ((this.mCCOMM != null) && (this.mCCOMM.IsOpen == true))
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
		public override int CMcuFunc_CloseConnect(RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 芯片擦除
		/// </summary>
		/// <returns></returns>
		public override int CMcuFunc_EraseChip(RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 芯片擦除
		/// </summary>
		/// <returns></returns>
		public override int CMcuFunc_EraseChip(TextBox lockFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFlash(ref byte[] chipFlash, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 编程Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipFlash(byte[] chipFlash, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 校验Flash为空
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_CheckChipFlashEmpty(RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipEeprom(ref byte[] chipEeprom, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 编程Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipEeprom(byte[] chipEeprom, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 校验Eeprom为空
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_CheckChipEepromEmpty(RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFuse(ref byte[] chipFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="chipFuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFuse(TextBox lowFuse, TextBox highFuse, TextBox externFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 默认熔丝位
		/// </summary>
		/// <param name="chipFuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_DefaultChipFuse(TextBox lowFuse, TextBox highFuse, TextBox externFuse, RichTextBox msg)
		{
			int _return = 0;
			//---获取熔丝位
			int[] fuse = this.mMcuInfoParam.McuDefaultFuseInfo();
			if (fuse == null)
			{
				_return = 1;
			}
			else
			{
				if (lowFuse.InvokeRequired)
				{
					lowFuse.BeginInvoke((EventHandler)
										(delegate
										{
											lowFuse.Text = fuse[0].ToString("X2");
										}));
				}
				else
				{
					lowFuse.Text = fuse[0].ToString("X2");
				}

				if (highFuse.InvokeRequired)
				{
					highFuse.BeginInvoke((EventHandler)
											(delegate
											{
												highFuse.Text = fuse[1].ToString("X2");
											}));
				}
				else
				{
					highFuse.Text = fuse[1].ToString("X2");
				}
				int tempFuse = 0;
				if (fuse.Length > 2)
				{
					tempFuse = fuse[2];
				}
				else
				{
					tempFuse = 0;
				}
				if (externFuse.InvokeRequired)
				{
					externFuse.BeginInvoke((EventHandler)
										(delegate
										{
											externFuse.Text = tempFuse.ToString("X2");
										}));
				}
				else
				{
					externFuse.Text = tempFuse.ToString("X2");
				}

				if (msg != null)
				{
					CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, "默认熔丝位恢复成功!", Color.Black);
				}
			}
			return _return;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipLock(ref byte chipLock, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="lockFuse"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipLock(TextBox lockFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipFuse(byte[] chipFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 写入熔丝位
		/// </summary>
		/// <param name="chipFuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipFuse(TextBox lowFuse, TextBox highFuse, TextBox externFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipLock(byte chipLock, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 写入加密位
		/// </summary>
		/// <param name="lockFuse"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipLock(TextBox lockFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取芯片的ID信息
		/// </summary>
		/// <param name="chipID"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipID(ref byte[] chipID, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取芯片的ID信息
		/// </summary>
		/// <param name="chipID"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipID(TextBox chipID, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取校准字
		/// </summary>
		/// <param name="chipCalibration"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipCalibration(ref byte[] chipCalibration, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取校准字
		/// </summary>
		/// <param name="chipCalibration"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipCalibration(Label oscText1, Label oscText2, Label oscText3, Label oscText4,
														TextBox oscValue1, TextBox oscValue2, TextBox oscValue3, TextBox oscValue4, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取ROM信息
		/// </summary>
		/// <param name="chipRom"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipRom(ref byte[] chipRom, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 编程时钟设置
		/// </summary>
		/// <param name="chipClock"></param>
		/// <returns></returns>
		public override int CMcuFunc_SetProg(byte chipClock, RichTextBox msg)
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

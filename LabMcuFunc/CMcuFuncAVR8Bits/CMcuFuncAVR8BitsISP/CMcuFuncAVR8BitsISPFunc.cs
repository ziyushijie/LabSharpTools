﻿using Harry.LabTools.LabControlPlus;
using Harry.LabTools.LabHexEdit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
		public override int CMcuFunc_OpenConnect(RichTextBox msg)
		{
			int _return = -1;
			//---校验通讯端口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				//---发送命令
				byte[] cmd = new byte[] { (byte)CMCUFUNC_CMD_ISP.CMD_ISP_OPEN_CLOSE, 0x01 };
				//---读取命令
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						this.mMsgText = "ISP编程：接口打开成功!";
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：接口打开命令校验错误!";
					}
				}
				else
				{					
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return==0?Color.Black:Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 关闭连接
		/// </summary>
		/// <returns></returns>
		public override int CMcuFunc_CloseConnect( RichTextBox msg)
		{
			int _return = -1;
			//---校验通讯端口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				//---发送命令
				byte[] cmd = new byte[] { (byte)CMCUFUNC_CMD_ISP.CMD_ISP_OPEN_CLOSE, 0x00 };
				//---读取命令
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						this.mMsgText = "ISP编程：接口关闭成功!";
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：接口关闭命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 芯片擦除
		/// </summary>
		/// <returns></returns>
		public override int CMcuFunc_EraseChip(RichTextBox msg)
		{
			int _return = -1;
			//---校验端口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				//---发送命令
				byte[] cmd = new byte[] { (byte)CMCUFUNC_CMD_ISP.CMD_ISP_ERASE, 0x00 };
				//---读取命令
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						this.mMsgText = "ISP编程：擦除成功!";
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：擦除命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 芯片擦除
		/// </summary>
		/// <returns></returns>
		public override int CMcuFunc_EraseChip(TextBox lockFuse, RichTextBox msg)
		{
			//---擦除芯片
			int _return = this.CMcuFunc_EraseChip(msg);
			//---校验结果
			if ((_return==0)&&(lockFuse!=null))
			{
				if (lockFuse.InvokeRequired)
				{
					lockFuse.BeginInvoke((EventHandler)
											(delegate
											{
												lockFuse.Text = "FF";
											}));
				}
				else
				{
					lockFuse.Text = "FF";
				}
			}
			return _return;
		}

		/// <summary>
		/// 读取Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFlash(ref byte[] chipFlash, RichTextBox msg)
		{
			int _return = -1;
			//---校验通讯端口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{

			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 读取Flash，并刷新到Hex编辑控件
		/// </summary>
		/// <param name="chb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFlash(CHexBox chb, RichTextBox msg)
		{
			byte[] flash = null;
			//---读取Flash数据
			int _return = this.CMcuFunc_ReadChipFlash(ref flash,msg);
			//---校验结果
			if ((_return == 0) && (flash != null))
			{
				if (chb != null)
				{
					if (chb.InvokeRequired)
					{
						chb.BeginInvoke((EventHandler)
												(delegate
												{
													chb.AddData(flash);
												}));
					}
					else
					{
						chb.AddData(flash);
					}
				}
			}
			return _return;
		}

		/// <summary>
		/// 编程Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipFlash(byte[] chipFlash, RichTextBox msg)
		{
			int _return = -1;
			//---校验通讯端口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{

			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 校验Flash为空
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_CheckChipFlashEmpty(RichTextBox msg)
		{
			int _return = -1;
			//---校验通讯端口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				byte[] cmd = new byte[] {	(byte)CMCUFUNC_CMD_ISP.CMD_ISP_ERASE, 0x01,
											(byte)(this.mMcuInfoParam.mChipEepromPerPageByteNum>>8), (byte)(this.mMcuInfoParam.mChipEepromPerPageByteNum),
											(byte)(this.mMcuInfoParam.mChipFlashPageNum>>8), (byte)(this.mMcuInfoParam.mChipFlashPageNum),
										};
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						if (this.mCCOMM.mReceData.mArray[this.mCCOMM.mReceData.mIndexOffset] == 0x00)
						{
							this.mMsgText = "ISP编程：Flash为空!";
						}
						else
						{
							this.mMsgText = "ISP编程：Flash不为空!";
						}
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：Flash查空命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
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
		/// 读取EEPROM，并刷新到hex编辑控件中
		/// </summary>
		/// <param name="chb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipEeprom(CHexBox chb, RichTextBox msg)
		{
			byte[] eeprom = null;
			//---读取Eeprom数据
			int _return = this.CMcuFunc_ReadChipEeprom(ref eeprom, msg);
			//---校验结果
			if ((_return == 0) && (eeprom != null))
			{
				if (chb != null)
				{
					if (chb.InvokeRequired)
					{
						chb.BeginInvoke((EventHandler)
												(delegate
												{
													chb.AddData(eeprom);
												}));
					}
					else
					{
						chb.AddData(eeprom);
					}
				}
			}
			return _return;
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
			int _return = -1;
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				byte[] cmd = new byte[] {	(byte)CMCUFUNC_CMD_ISP.CMD_ISP_ERASE, 0x02,
											(byte)(this.mMcuInfoParam.mChipEepromPerPageByteNum),
											(byte)(this.mMcuInfoParam.mChipEepromPageNum>>8),(byte)(this.mMcuInfoParam.mChipEepromPageNum)
										};
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						if (this.mCCOMM.mReceData.mArray[this.mCCOMM.mReceData.mIndexOffset]==0x00)
						{
							this.mMsgText = "ISP编程：Eeprom为空!";
						}
						else
						{
							this.mMsgText = "ISP编程：Eeprom不为空!";
						}
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：Eeprom查空命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFuse(ref byte[] chipFuse, RichTextBox msg)
		{
			int _return = -1;
			//---校验通讯接口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				//---发送命令
				byte[] cmd = new byte[] { (byte)CMCUFUNC_CMD_ISP.CMD_ISP_FUSE_LOCK_READ, 0x00,(byte)(this.mMcuInfoParam.mChipFuse.Length>2?1:0)};
				//---读取命令
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						this.mMsgText = "ISP编程：熔丝位读取成功!";
						//---申请缓存区
						chipFuse = new byte[this.mMcuInfoParam.mChipFuse.Length];
						//---拷贝数据
						Array.Copy(this.mCCOMM.mReceData.mArray, this.mCCOMM.mReceData.mIndexOffset, chipFuse,0, chipFuse.Length);
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：熔丝位读取命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="chipFuse"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipFuse(TextBox lowFuse, TextBox highFuse, TextBox externFuse, RichTextBox msg)
		{
			byte[] fuse = null;
			//---读取熔丝位
			int _return = this.CMcuFunc_ReadChipFuse(ref fuse, msg);
			//---判断读取结果
			if ((_return==0)&&(fuse!=null)&&(fuse.Length>1))
			{
				//---低位熔丝位
				if (lowFuse != null)
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
				}

				//---高位熔丝位
				if (highFuse != null)
				{
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
				}

				//---拓展位熔丝位
				if (externFuse != null)
				{
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
				}
			}
			return _return;
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
			//---校验熔丝位
			if ((fuse == null)||(fuse.Length<2))
			{
				_return = 1;
			}
			else
			{
				//---低位熔丝位
				if (lowFuse!=null)
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
				}

				//---高位熔丝位
				if (highFuse!=null)
				{
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
				}

				//---拓展位熔丝位
				if (externFuse!=null)
				{
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
				}
				
				if (msg!=null)
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
			int _return = -1;
			//---校验通讯接口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				//---发送命令
				byte[] cmd = new byte[] { (byte)CMCUFUNC_CMD_ISP.CMD_ISP_FUSE_LOCK_READ, 0x01};
				//---读取命令
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						this.mMsgText = "ISP编程：加密位读取成功!";
						//---获取加密位信息
						chipLock = this.mCCOMM.mReceData.mArray[this.mCCOMM.mReceData.mIndexOffset];
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：加密位读取命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="lockFuse"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipLock(TextBox lockFuse, RichTextBox msg)
		{
			byte tempLock = 0x00;
			//---读取加密位
			int _return = this.CMcuFunc_ReadChipLock(ref tempLock, msg);
			//---校验读取结果
			if (_return!=0)
			{
				tempLock = 0xFF;
			}
			//---加密位信息
			if (lockFuse != null)
			{
				//---低位熔丝位
				if (lockFuse.InvokeRequired)
				{
					lockFuse.BeginInvoke((EventHandler)
										(delegate
										{
											lockFuse.Text = tempLock.ToString("X2");
										}));
				}
				else
				{
					lockFuse.Text = tempLock.ToString("X2");
				}
			}
			return _return;
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
			int _return = -1;
			//---校验通讯接口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				//---发送命令
				byte[] cmd = new byte[] { (byte)CMCUFUNC_CMD_ISP.CMD_ISP_LOCK_WRITE, chipLock };
				//---读取命令
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						this.mMsgText = "ISP编程：加密位写入成功!";
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：加密位写入命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 写入加密位
		/// </summary>
		/// <param name="lockFuse"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CMcuFunc_WriteChipLock(TextBox lockFuse, RichTextBox msg)
		{
			return this.CMcuFunc_WriteChipLock(Convert.ToByte(lockFuse.Text,16), msg);
		}

		/// <summary>
		/// 读取芯片的ID信息
		/// </summary>
		/// <param name="chipID"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipID(ref byte[] chipID, RichTextBox msg)
		{
			int _return = -1;
			//---校验通讯接口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				//---发送命令
				byte[] cmd = new byte[] { (byte)CMCUFUNC_CMD_ISP.CMD_ISP_ID_READ};
				//---读取命令
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						this.mMsgText = "ISP编程：ChipID读取成功!";
						//---申请缓存区
						chipID = new byte[this.mMcuInfoParam.mChipID.Length];
						//---拷贝数据
						Array.Copy(this.mCCOMM.mReceData.mArray, this.mCCOMM.mReceData.mIndexOffset, chipID, 0, chipID.Length);
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：ChipID读取命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 读取芯片的ID信息
		/// </summary>
		/// <param name="chipID"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipID(TextBox chipID, RichTextBox msg)
		{
			byte[] tempID = null;
			//---读取ChipID
			int _return = this.CMcuFunc_ReadChipID(ref tempID, msg);
			//---校验读取结果
			if ((_return==0)&&(tempID!=null)&&(tempID.Length==3))
			{
				if (chipID!=null)
				{
					if (chipID.InvokeRequired)
					{
						chipID.BeginInvoke((EventHandler)
											(delegate
											{
												chipID.Text = tempID[0].ToString("X2")+":"+ tempID[2].ToString("X2") + ":"+ tempID[2].ToString("X2");
											}));
					}
					else
					{
						chipID.Text = tempID[0].ToString("X2") + ":" + tempID[2].ToString("X2") + ":" + tempID[2].ToString("X2");
					}
				}
			}
			return _return;
		}

		/// <summary>
		/// 读取校准字
		/// </summary>
		/// <param name="chipCalibration"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipCalibration(ref byte[] chipCalibration, RichTextBox msg)
		{
			int _return = -1;
			//---校验通讯接口
			if ((this.mCCOMM != null) && (this.mCCOMM.mIsOpen == true))
			{
				//---发送命令
				byte[] cmd = new byte[] { (byte)CMCUFUNC_CMD_ISP.CMD_ISP_CALIBRATIONBYTE_READ,(byte)(this.mMcuInfoParam.mChipOSCCalibration.mText.Length) };
				//---读取命令
				byte[] res = null;
				//---发送并读取命令
				_return = this.mCCOMM.SendCmdAndReadResponse(cmd, ref res);
				//---校验结果
				if (_return == 0)
				{
					if (this.mCCOMM.mReceCheckPass)
					{
						this.mMsgText = "ISP编程：校准字读取成功!";
						//---申请缓存区
						chipCalibration = new byte[this.mMcuInfoParam.mChipOSCCalibration.mText.Length];
						//---拷贝数据
						Array.Copy(this.mCCOMM.mReceData.mArray, this.mCCOMM.mReceData.mIndexOffset, chipCalibration, 0, chipCalibration.Length);
					}
					else
					{
						_return = 1;
						this.mMsgText = "ISP编程：校准字读取命令校验错误!";
					}
				}
				else
				{
					this.mMsgText = this.mCCOMM.mLogMsg;
				}
			}
			else
			{
				this.mMsgText = "通讯端口初始化失败!";
			}
			if (msg != null)
			{
				CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, this.mMsgText, (_return == 0 ? Color.Black : Color.Red));
			}
			return _return;
		}

		/// <summary>
		/// 读取校准字
		/// </summary>
		/// <param name="chipCalibration"></param>
		/// <returns></returns>
		public override int CMcuFunc_ReadChipCalibration(TextBox oscValue1, TextBox oscValue2, TextBox oscValue3, TextBox oscValue4, RichTextBox msg)
		{
			byte[] chipCalibration = null;
			//---读取校准字
			int _return = this.CMcuFunc_ReadChipCalibration(ref chipCalibration, msg);
			//---校验读取结果
			if ((_return==0)&&(chipCalibration!=null))
			{
				for (int i = 0; i < chipCalibration.Length; i++)
				{
					switch (i)
					{
						case 0:
							if (oscValue1.Visible==true)
							{
								if (oscValue1.InvokeRequired)
								{
									oscValue1.BeginInvoke((EventHandler)
											(delegate
											{
												oscValue1.Text = chipCalibration[i].ToString("X2");
											}));
								}
								else
								{
									oscValue1.Text = chipCalibration[i].ToString("X2");
								}
							}
							break;
						case 1:
							if (oscValue2.Visible == true)
							{
								if (oscValue2.InvokeRequired)
								{
									oscValue2.BeginInvoke((EventHandler)
											(delegate
											{
												oscValue2.Text = chipCalibration[i].ToString("X2");
											}));
								}
								else
								{
									oscValue2.Text = chipCalibration[i].ToString("X2");
								}
							}
							break;
						case 2:
							if (oscValue3.Visible == true)
							{
								if (oscValue3.InvokeRequired)
								{
									oscValue3.BeginInvoke((EventHandler)
											(delegate
											{
												oscValue3.Text = chipCalibration[i].ToString("X2");
											}));
								}
								else
								{
									oscValue3.Text = chipCalibration[i].ToString("X2");
								}
							}
							break;
						case 3:
							if (oscValue4.Visible == true)
							{
								if (oscValue4.InvokeRequired)
								{
									oscValue4.BeginInvoke((EventHandler)
											(delegate
											{
												oscValue4.Text = chipCalibration[i].ToString("X2");
											}));
								}
								else
								{
									oscValue4.Text = chipCalibration[i].ToString("X2");
								}
							}
							break;
						default:
							break;
					}
				}
			}
			return _return;
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

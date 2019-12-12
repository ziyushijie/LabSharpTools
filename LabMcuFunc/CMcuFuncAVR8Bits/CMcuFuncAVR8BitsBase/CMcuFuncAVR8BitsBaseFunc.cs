using Harry.LabTools.LabControlPlus;
using Harry.LabTools.LabGenFunc;
using Harry.LabTools.LabHexEdit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabMcuFunc
{
	public partial class CMcuFuncAVR8BitsBase
	{
		#region 变量定义

		#endregion

		#region 属性定义

		/// <summary>
		/// 功能函数的执行步序1
		/// </summary>
		public virtual int mFuncStep1Mask
		{
			get;
			set;
		}

		/// <summary>
		/// 功能函数的执行步序2
		/// </summary>
		public virtual int mFuncStep2Mask
		{
			get;
			set;
		}

		#endregion

		#region 构造函数

		#endregion

		#region 公有函数

		#region Hex文件操作

		/// <summary>
		/// 加载Flash文件
		/// </summary>
		/// <param name="flash"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_LoadFlashFile(ref byte[] flash, RichTextBox msg)
		{
			int _return = -1;
			OpenFileDialog flashFile = new OpenFileDialog();
			flashFile.AddExtension = true;
			flashFile.DefaultExt = "hex";
			flashFile.Filter = " files(*.hex)|*.hex|All files(*.*)|*.*";
			flashFile.FilterIndex = 0;
			//---选择文件
			if ((flashFile.ShowDialog() == DialogResult.OK) && (!string.IsNullOrEmpty(flashFile.FileName)))
			{
				CHexFile loadFlash = new CHexFile(flashFile.FileName);
				//---校验文件的解析
				if (loadFlash.mIsOK)
				{
					flash = new byte[loadFlash.mSTOPAddr];
					//---填充默认数据是0xFF
					CGenFuncMem.GenFuncMemset(ref flash, 0xFF);
					//---数组拷贝
					Array.Copy(loadFlash.mDataMap,0, flash, loadFlash.mSTARTAddr,loadFlash.mDataMap.Length);
					//---消息显示
					if (msg!=null)
					{
						CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, "调入Flash文件:" + flashFile.FileName, Color.Black);
					}
					_return = 0;
				}
				else
				{
					MessageBox.Show("Flash文件加载失败","消息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			return _return;
		}

		/// <summary>
		/// 加载Flash文件
		/// </summary>
		/// <param name="chb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_LoadFlashFile(CHexBox chb, RichTextBox msg)
		{
			byte[] flash = null;
			int _return = this.CMcuFunc_LoadFlashFile(ref flash, msg);
			//---校验结果
			if ((_return==0)&&(flash!=null))
			{
				if (chb!=null)
				{
					if (chb.InvokeRequired)
					{
						chb.BeginInvoke((EventHandler)
										(delegate
										{
											chb.AddData(flash, this.mMcuInfoParam.mChipFlashByteSize);
										}));
					}
					else
					{
						chb.AddData(flash,this.mMcuInfoParam.mChipFlashByteSize);
					}
				}
			}
			return _return;
		}

		/// <summary>
		/// 加载Flash文件
		/// </summary>
		/// <param name="chb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_LoadFlashFile(CHexBox chb, Label flashSize,  RichTextBox msg)
		{
			byte[] flash = null;
			int _return = this.CMcuFunc_LoadFlashFile(ref flash, msg);
			//---校验结果
			if ((_return == 0) && (flash != null))
			{
				//---显示固件的大小
				if (flashSize!=null)
				{
					if (flashSize.InvokeRequired)
					{
						flashSize.BeginInvoke((EventHandler)
										(delegate
										{
											flashSize.Text = flash.Length.ToString() + "/" + this.mMcuInfoParam.mChipFlashByteSize.ToString();
										}));
					}
					else
					{
						flashSize.Text = flash.Length.ToString() + "/" + this.mMcuInfoParam.mChipFlashByteSize.ToString();
					}
				}
				
				//---刷新数据到Hex控件中
				if (chb != null)
				{
					if (chb.InvokeRequired)
					{
						chb.BeginInvoke((EventHandler)
										(delegate
										{
											chb.AddData(flash, this.mMcuInfoParam.mChipFlashByteSize);
										}));
					}
					else
					{
						chb.AddData(flash, this.mMcuInfoParam.mChipFlashByteSize);
					}
				}
			}
			return _return;
		}

		/// <summary>
		/// 加载Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_LoadEepromhFile(ref byte[] eeprom, RichTextBox msg)
		{
			int _return = -1;
			OpenFileDialog eepromFile = new OpenFileDialog();
			eepromFile.AddExtension = true;
			eepromFile.DefaultExt = "hex";
			eepromFile.Filter = " files(*.hex)|*.hex|All files(*.*)|*.*";
			eepromFile.FilterIndex = 0;
			//---选择文件
			if ((eepromFile.ShowDialog() == DialogResult.OK) && (!string.IsNullOrEmpty(eepromFile.FileName)))
			{
				CHexFile loadFlash = new CHexFile(eepromFile.FileName);
				//---校验文件的解析
				if (loadFlash.mIsOK)
				{
					eeprom = new byte[loadFlash.mSTOPAddr];
					//---填充默认数据是0xFF
					CGenFuncMem.GenFuncMemset(ref eeprom, 0xFF);
					//---数组拷贝
					Array.Copy(loadFlash.mDataMap, 0, eeprom, loadFlash.mSTARTAddr, loadFlash.mDataMap.Length);
					//---消息显示
					if (msg != null)
					{
						CRichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, "调入Eeprom文件:" + eepromFile.FileName, Color.Black);
					}
					_return = 0;
				}
				else
				{
					MessageBox.Show("Eeprom文件加载失败", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			return _return;
		}

		/// <summary>
		/// 加载Eeprom
		/// </summary>
		/// <param name="chb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_LoadEepromhFile(CHexBox chb, RichTextBox msg)
		{
			byte[] eeprom = null;
			int _return = this.CMcuFunc_LoadFlashFile(ref eeprom, msg);
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
											chb.AddData(eeprom, this.mMcuInfoParam.mChipEepromByteSize);
										}));
					}
					else
					{
						chb.AddData(eeprom, this.mMcuInfoParam.mChipEepromByteSize);
					}
				}
			}
			return _return;
		}

		/// <summary>
		/// 加载Eeprom
		/// </summary>
		/// <param name="chb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_LoadEepromhFile(CHexBox chb, Label eepromSize, RichTextBox msg)
		{
			byte[] eeprom = null;
			int _return = this.CMcuFunc_LoadFlashFile(ref eeprom, msg);
			//---校验结果
			if ((_return == 0) && (eeprom != null))
			{
				//---显示固件的大小
				if (eepromSize != null)
				{
					if (eepromSize.InvokeRequired)
					{
						eepromSize.BeginInvoke((EventHandler)
										(delegate
										{
											eepromSize.Text = eeprom.Length.ToString() + "/" + this.mMcuInfoParam.mChipEepromByteSize.ToString();
										}));
					}
					else
					{
						eepromSize.Text = eeprom.Length.ToString() + "/" + this.mMcuInfoParam.mChipEepromByteSize.ToString();
					}
				}

				//---刷新数据到Hex控件中
				if (chb != null)
				{
					if (chb.InvokeRequired)
					{
						chb.BeginInvoke((EventHandler)
										(delegate
										{
											chb.AddData(eeprom, this.mMcuInfoParam.mChipFlashByteSize);
										}));
					}
					else
					{
						chb.AddData(eeprom, this.mMcuInfoParam.mChipFlashByteSize);
					}
				}
			}
			return _return;
		}

		#endregion

		#region 编程常规使用函数

		/// <summary>
		/// 打开连接
		/// </summary>
		/// <returns></returns>
		public virtual int CMcuFunc_OpenConnect(RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 关闭连接
		/// </summary>
		/// <returns></returns>
		public virtual int CMcuFunc_CloseConnect(RichTextBox msg)
		{
			return -1;
		}


		/// <summary>
		/// 芯片擦除
		/// </summary>
		/// <returns></returns>
		public virtual int CMcuFunc_EraseChip( RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 芯片擦除
		/// </summary>
		/// <returns></returns>
		public virtual int CMcuFunc_EraseChip(TextBox lockFuse,RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipFlash(ref byte[] chipFlash, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取Flash
		/// </summary>
		/// <param name="chb">Hex编辑器控件</param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipFlash(CHexBox chb, RichTextBox msg)
		{
			int _return = -1;
			byte[] tempRom = null;
			_return = this.CMcuFunc_ReadChipFlash(ref tempRom,msg);
			if ((_return == 0) && (tempRom != null))
			{
				if (chb.InvokeRequired)
				{
					chb.BeginInvoke((EventHandler)
										(delegate
										{
											chb.AddData(tempRom);
										}));
				}
				else
				{
					chb.AddData(tempRom);
				}
			}
			return _return;
		}

		/// <summary>
		/// 编程Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipFlash( byte[] chipFlash, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 编程Flash
		/// </summary>
		/// <param name="chb">Hex编辑器控件</param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipFlash(CHexBox chb, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 校验Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_CheckChipFlash(byte[] chipFlash, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 校验Flash
		/// </summary>
		/// <param name="chb">Hex编辑器控件</param>
		/// <returns></returns>
		public virtual int CMcuFunc_CheckChipFlash(CHexBox chb, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 校验Flash为空
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_CheckChipFlashEmpty(RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipEeprom(ref byte[] chipEeprom, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取Eeprom
		/// </summary>
		/// <param name="chb">Hex编辑器控件</param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipEeprom(CHexBox chb, RichTextBox msg)
		{
			int _return = -1;
			byte[] tempRom = null;
			_return = this.CMcuFunc_ReadChipEeprom(ref tempRom,msg);
			if ((_return == 0) && (tempRom != null))
			{
				if (chb.InvokeRequired)
				{
					chb.BeginInvoke((EventHandler)
										(delegate
										{
											chb.AddData(tempRom);
										}));
				}
				else
				{
					chb.AddData(tempRom);
				}
			}
			return _return;
		}

		/// <summary>
		/// 编程Eeprom
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipEeprom(byte[] chipEeprom, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 编程Eeprom
		/// </summary>
		/// <param name="chb">Hex编辑器控件</param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipEeprom(CHexBox chb, RichTextBox msg)
		{
			return -1;
		}


		/// <summary>
		/// 校验Flash
		/// </summary>
		/// <param name="flash"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_CheckChipEeprom(byte[] chipEeprom, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 校验Flash
		/// </summary>
		/// <param name="chb">Hex编辑器控件</param>
		/// <returns></returns>
		public virtual int CMcuFunc_CheckChipEeprom(CHexBox chb, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 校验Eeprom为空
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_CheckChipEepromEmpty(RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipFuse(ref byte[] chipFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取熔丝位
		/// </summary>
		/// <param name="chipFuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipFuse(TextBox lowFuse, TextBox highFuse, TextBox externFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 默认熔丝位
		/// </summary>
		/// <param name="chipFuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_DefaultChipFuse(TextBox lowFuse, TextBox highFuse, TextBox externFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipLock(ref byte chipLock, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取加密位
		/// </summary>
		/// <param name="lockFuse"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipLock(TextBox lockFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 写入熔丝位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipFuse( byte[] chipFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 写入熔丝位
		/// </summary>
		/// <param name="chipFuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipFuse(TextBox lowFuse, TextBox highFuse, TextBox externFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 写入加密位
		/// </summary>
		/// <param name="fuse"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipLock( byte chipLock, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 写入加密位
		/// </summary>
		/// <param name="lockFuse"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_WriteChipLock(TextBox lockFuse, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取芯片的ID信息
		/// </summary>
		/// <param name="chipID"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipID(ref byte[] chipID, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取芯片的ID信息
		/// </summary>
		/// <param name="chipID"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipID(RichTextBox msg,Form form=null)
		{
			return -1;
		}

		/// <summary>
		/// 读取校准字
		/// </summary>
		/// <param name="chipCalibration"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipCalibration(ref byte[] chipCalibration, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取校准字
		/// </summary>
		/// <param name="chipCalibration"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipCalibration( TextBox oscValue1, TextBox oscValue2, TextBox oscValue3, TextBox oscValue4, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取ROM信息
		/// </summary>
		/// <param name="chipRom"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipRom(ref byte[] chipRom, RichTextBox msg)
		{
			return -1;
		}

		/// <summary>
		/// 读取ROM信息
		/// </summary>
		/// <param name="chb">Hex编辑器控件</param>
		/// <returns></returns>
		public virtual int CMcuFunc_ReadChipRom(CHexBox chb, RichTextBox msg)
		{
			int _return = -1;
			byte[] tempRom = null;
			_return = this.CMcuFunc_ReadChipRom(ref tempRom,msg);
			if ((_return == 0) && (tempRom != null))
			{
				if (chb.InvokeRequired)
				{
					chb.BeginInvoke((EventHandler)
										(delegate
										{
											chb.AddData(tempRom);
										}));
				}
				else
				{
					chb.AddData(tempRom);
				}
			}
			return _return;
		}

		/// <summary>
		/// 编程时钟设置
		/// </summary>
		/// <param name="chipClock"></param>
		/// <returns></returns>
		public virtual int CMcuFunc_SetProg(byte chipClock, RichTextBox msg)
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
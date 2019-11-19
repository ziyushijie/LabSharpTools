using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Harry.LabTools.LabMcuFunc
{
	/// <summary>
	/// 芯片的基本信息
	/// </summary>
	public class CMcuFuncInfoAVR8BitsParam : CMcuFuncInfoBaseParam,IMcuFuncInfoAVR8BitsParam 
	{
		#region 变量定义

		/// <summary>
		/// 设备支持的编程接口
		/// </summary>
		private string[] defaultInterfaceName = new string[4] { "ISP", "JTAG", "HVPP", "HVSP" };

		/// <summary>
		/// 当前设备的名称
		/// </summary>
		private string defaultChipName = string.Empty;// "ATmega8";

		/// <summary>
		/// 编程接口名称
		/// </summary>
		/// { "ISP", "JTAG", "HVPP", "HVSP" };
		/// <summary>
		/// 支持的编程接口
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultInterface = null;//new byte[] { (byte)AVR8BITS_PROG_INTERFACE.ISP, (byte)AVR8BITS_PROG_INTERFACE.HVPP };

		/// <summary>
		/// 设备ID信息
		/// </summary>
		private byte[] defaultChipID = null;// new byte[] { 0x1E, 0x93, 0x07 };

		/// <summary>
		/// 设备的JTAG的ID信息
		/// </summary>
		private int defaultIDChip = 0x00;

		/// <summary>
		/// 设备的熔丝位
		/// </summary>
		private byte[] defaultChipFuse = null;//new byte[] { 0xE1, 0xD9 };

		/// <summary>
		/// 芯片的加密位
		/// </summary>
		private byte defaultChipLock = 0;//0xFF;

		/// <summary>
		/// 芯片的Flash的页数
		/// </summary>
		private int defaultChipFlashPageNum = 0;//128;

		/// <summary>
		/// 芯片Flash的每页字节数
		/// </summary>
		private int defaultChipFlashPerPageWordNum = 0;//32;

		/// <summary>
		/// 芯片的Eeprom的页数
		/// </summary>
		private int defaultChipEepromPageNum = 0;//128;

		/// <summary>
		/// 芯片Flash的每页字节数
		/// </summary>
		private int defaultChipEepromPerPageByteNum = 0;// 4;

		/// <summary>
		/// 设备的校准字
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipOSC = null;

		/// <summary>
		/// 低位熔丝位,Bits信息
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipLowFuseBits = null;

		/// <summary>
		/// 低位熔丝位,Text信息
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipLowFuseText = null;

		/// <summary>
		/// 高位熔丝位
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipHighFuseBits = null;

		/// <summary>
		/// 高位熔丝位
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipHighFuseText = null;

		/// <summary>
		/// 拓展位熔丝位
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipExternFuseBits = null;

		/// <summary>
		/// 拓展位熔丝位
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipExternFuseText = null;

		/// <summary>
		/// 加密位熔丝位
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipLockFuseBits = null;

		/// <summary>
		/// 加密位熔丝位
		/// </summary>
		private CMcuFuncAVR8BitsParam defaultChipLockFuseText = null;

		/// <summary>
		/// 错误消息提示
		/// </summary>
		private string defaultMsgText = "";

		#endregion

		#region 属性定义

		/// <summary>
		/// 芯片类型
		/// </summary>
		public override string ChipType
		{
			get
			{
				return "AVR";
			}
		}
		/// <summary>
		/// 芯片名称为读写属性
		/// </summary>
		public virtual string ChipName
		{
			get
			{
				return this.defaultChipName;			
			}
			set
			{
				this.defaultChipName = value;
			}
		}

		/// <summary>
		/// 支持的总编程接口为只读属性
		/// </summary>
		public virtual string[] ChipInterfaceName
		{
			get
			{
				return this.defaultInterfaceName;
			}
		}

		/// <summary>
		/// 当前设备支持的编程接口为只读属性
		/// </summary>
		public virtual CMcuFuncAVR8BitsParam ChipInterface
		{
			get
			{
				return this.defaultInterface;
			}
			//set
			//{
			//	if (this.defaultInterface == null)
			//	{
			//		this.defaultInterface = new CMcuAVR8BitsParam(value);
			//	}
			//	else
			//	{
			//		this.defaultInterface.Init(value);
			//	}
			//}
		}

		/// <summary>
		/// Chip的ID信息为读写属性
		/// </summary>
		public virtual byte[] ChipID
		{
			get
			{
				return this.defaultChipID;
			}
			set
			{
				if (value != null)
				{
					this.defaultChipID = new byte[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultChipID, value.Length);
				}
			}
		}

		/// <summary>
		/// JTAG的ID信息为读写属性
		/// </summary>
		public virtual int IDChip
		{
			get
			{
				return this.defaultIDChip;
			}
			set
			{
				this.defaultIDChip = value;
			}
		}

		/// <summary>
		/// 熔丝位为读写属性
		/// </summary>
		public virtual byte[] ChipFuse
		{
			get
			{
				return this.defaultChipFuse;
			}
			set
			{
				if (value != null)
				{
					this.defaultChipFuse = new byte[value.Length];
					//---数据拷贝
					Array.Copy(value, this.defaultChipFuse, value.Length);
				}
			}
		}

		/// <summary>
		/// 默认熔丝位
		/// </summary>
		public virtual byte[] mDefaultFuse
		{
			get
			{
				byte[] _return = new byte[this.defaultChipFuse.Length];
				for (int i = 0; i < _return.Length; i++)
				{
					_return[i] = (byte)this.defaultChipOSC.mMask[i];
				}
				return _return;
			}
		}
		/// <summary>
		/// 加密位为读写属性
		/// </summary>
		public virtual byte ChipLock
		{
			get
			{
				return this.defaultChipLock;
			}
			set
			{
				this.defaultChipLock = value;
			}
		}

		/// <summary>
		/// Flash的页数为读写属性
		/// </summary>
		public virtual int ChipFlashPageNum
		{
			get
			{
				return this.defaultChipFlashPageNum;
			}
			set
			{
				this.defaultChipFlashPageNum = value;
			}
		}

		/// <summary>
		/// 每页Flash的字数为读写属性
		/// </summary>
		public virtual int ChipFlashPerPageWordNum
		{
			get
			{
				return this.defaultChipFlashPerPageWordNum;
			}
			set
			{
				this.defaultChipFlashPerPageWordNum = value;
			}
		}

		/// <summary>
		/// 每页Flash的字节数为只读属性
		/// </summary>
		public virtual int ChipFlashPerPageByteNum
		{
			get
			{
				return this.defaultChipFlashPerPageWordNum * 2;
			}
		}

		/// <summary>
		/// 芯片ROM页的字大小为只读属性
		/// </summary>
		public virtual int ChipRomWordSize
		{
			get
			{
				return this.defaultChipFlashPerPageWordNum;
			}
		}

		/// <summary>
		/// ROM页的字节大小为只读属性
		/// </summary>
		public virtual int ChipRomByteSize
		{
			get
			{
				return this.defaultChipFlashPerPageWordNum * 2;
			}
		}

		/// <summary>
		/// Flash的总字节数为只读属性
		/// </summary>
		public virtual long ChipFlashByteSize
		{
			get
			{
				return (((long)this.defaultChipFlashPageNum) * this.defaultChipFlashPerPageWordNum * 2);
			}
		}

		/// <summary>
		/// Flash的总字数为只读属性
		/// </summary>
		public virtual long ChipFlashWordSize
		{
			get
			{
				return (((long)this.defaultChipFlashPageNum) * this.defaultChipFlashPerPageWordNum);
			}
		}

		/// <summary>
		/// Eeprom的页数为读写属性
		/// </summary>
		public virtual int ChipEepromPageNum
		{
			get
			{
				return this.defaultChipEepromPageNum;
			}
			set
			{
				this.defaultChipEepromPageNum = value;
			}
		}

		/// <summary>
		/// Eeprom的每页字节数为读写属性
		/// </summary>
		public virtual int ChipEepromPerPageByteNum
		{
			get
			{
				return this.defaultChipEepromPerPageByteNum;
			}
			set
			{
				this.defaultChipEepromPerPageByteNum = value;
			}
		}

		/// <summary>
		/// Eeprom的总字节数为读写属性
		/// </summary>
		public virtual long ChipEepromByteSize
		{
			get
			{
				return ((long)this.defaultChipEepromPageNum) * this.defaultChipEepromPerPageByteNum;
			}
		}

		/// <summary>
		/// 内部OSC的校准字为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipOSC
		{
			get
			{
				return this.defaultChipOSC;
			}
			set
			{
				if (this.defaultChipOSC == null)
				{
					this.defaultChipOSC = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipOSC.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位低位值为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipLowFuseBits
		{
			get
			{
				return this.defaultChipLowFuseBits;
			}
			set
			{
				if (this.defaultChipLowFuseBits == null)
				{
					this.defaultChipLowFuseBits = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipLowFuseBits.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位低位值为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipLowFuseText
		{
			get
			{
				return this.defaultChipLowFuseText;
			}
			set
			{
				if (this.defaultChipLowFuseText == null)
				{
					this.defaultChipLowFuseText = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipLowFuseText.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位高位值为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipHighFuseBits
		{
			get
			{
				return this.defaultChipHighFuseBits;
			}
			set
			{
				if (this.defaultChipHighFuseBits == null)
				{
					this.defaultChipHighFuseBits = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipHighFuseBits.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位高位值为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipHighFuseText
		{
			get
			{
				return this.defaultChipHighFuseText;
			}
			set
			{
				if (this.defaultChipHighFuseText == null)
				{
					this.defaultChipHighFuseText = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipHighFuseText.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位拓展位值为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipExternFuseBits
		{
			get
			{
				return this.defaultChipExternFuseBits;
			}
			set
			{
				if (this.defaultChipExternFuseBits == null)
				{
					this.defaultChipExternFuseBits = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipExternFuseBits.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位拓展位值为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipExternFuseText
		{
			get
			{
				return this.defaultChipExternFuseText;
			}
			set
			{
				if (this.defaultChipExternFuseText == null)
				{
					this.defaultChipExternFuseText = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipExternFuseText.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位加密位值为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipLockFuseBits
		{
			get
			{
				return this.defaultChipLockFuseBits;
			}
			set
			{
				if (this.defaultChipLockFuseBits == null)
				{
					this.defaultChipLockFuseBits = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipLockFuseBits.Init(value);
				}
			}
		}

		/// <summary>
		/// 熔丝位加密位值为读写属性
		/// </summary>
		public CMcuFuncAVR8BitsParam ChipLockFuseText
		{
			get
			{
				return this.defaultChipLockFuseText;
			}
			set
			{
				if (this.defaultChipLockFuseText == null)
				{
					this.defaultChipLockFuseText = new CMcuFuncAVR8BitsParam(value);
				}
				else
				{
					this.defaultChipLockFuseText.Init(value);
				}
			}
		}

		/// <summary>
		/// 消息为读写属性
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
		/// 无参数的构造函数
		/// </summary>
		public CMcuFuncInfoAVR8BitsParam ()
		{
			
		}

		/// <summary>
		/// 带有参数的构造函数
		/// </summary>
		/// <param name="mcuInfo"></param>
		public CMcuFuncInfoAVR8BitsParam (CMcuFuncInfoAVR8BitsParam cMcuFuncInfoAVR8BitsParam)
		{
			
		}

		#endregion

		#region 公有函数

		/// <summary>
		/// 
		/// </summary>
		/// <param name="chipName"></param>
		/// <returns></returns>
		public override bool McuTypeInfo(string chipName)
		{
			return this.AnalyseAVR8BitsMcuInfo(chipName);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="chipName"></param>
		/// <returns></returns>
		public override string[] McuTypeList()
		{
			return this.AnalyseAVR8BitsMcuList();
		}

		/// <summary>
		/// 初始化控件
		/// </summary>
		public void FormControlInit(CheckedListBox lowFuseBits, CheckedListBox highFuseBits, CheckedListBox externFuseBits, CheckedListBox lockFuseBits,
									CheckedListBox fuseText,
									Label oscText1,Label oscText2,Label oscText3,Label oscText4,
									TextBox oscValue1,TextBox oscValue2,TextBox oscValue3,TextBox oscValue4,
									TextBox lowFuseValue, TextBox highFuseValue, TextBox externFuseValue, TextBox lockFuseValue)
		{
			this.FuseCheckedListBoxBitsInit(lowFuseBits, this.ChipLowFuseBits);
			this.FuseCheckedListBoxBitsInit(highFuseBits, this.ChipHighFuseBits);
			this.FuseCheckedListBoxBitsInit(externFuseBits, this.ChipExternFuseBits);
			this.FuseCheckedListBoxBitsInit(lockFuseBits, this.ChipLockFuseBits);
			this.FuseCheckedListBoxTextInit(fuseText, lowFuseValue,highFuseValue,externFuseValue,lockFuseValue);
			this.OSCControlInit(oscText1,oscText2,oscText3,oscText4,
								oscValue1, oscValue2, oscValue3, oscValue4);
		}

		#endregion

		#region 保护函数

		#endregion

		#region 私有函数

		/// <summary>
		/// 解析AVR的8Bits的MCU的信息
		/// </summary>
		/// <param name="chipName">设备名称</param>
		/// <returns>true---合格，False---失败</returns>
		private bool AnalyseAVR8BitsMcuInfo(string chipName)
		{
			return this.AnalyseAVR8BitsMcuInfoXml(chipName);
		}

		/// <summary>
		/// 解析AVR的8Bits的MCU的列表
		/// </summary>
		/// <param name="chipName"></param>
		/// <returns></returns>
		private string[] AnalyseAVR8BitsMcuList()
		{
			return this.AnalyseAVR8BitsMcuListXml();
		}

		#region 解析MCU的信息

		/// <summary>
		/// 通过XML文件解析MCU设备的信息
		/// </summary>
		/// <param name="chipName"></param>
		/// <returns></returns>
		private bool AnalyseAVR8BitsMcuInfoXml(string chipName)
		{
			//---获取XML文件的位置
			string xmlPath = System.IO.Directory.GetCurrentDirectory() + "\\deviceXml" + "\\" + chipName + ".xml";
			//---清空错误消息
			this.defaultMsgText = string.Empty;
			//---校验当前XML文件是否存在
			if (!File.Exists(xmlPath))
			{
				this.defaultMsgText = "设备XML文件识别错误！";
				//---打印Debug信息
				Debug.WriteLine(this.defaultMsgText);
				return false;
			}
			try
			{
				XmlDocument xmlDoc = new XmlDocument();
				XmlReaderSettings settings = new XmlReaderSettings();
				//---忽略文档里面的注释
				settings.IgnoreComments = true;      
				XmlReader reader = XmlReader.Create(xmlPath, settings);
				//---加载XML文件
				xmlDoc.Load(reader);
				//---得到更节点所有的子节点
				XmlNodeList xmlNodeList = xmlDoc.SelectSingleNode("AVRPART").ChildNodes;
				//---对于拓展熔丝位进行归零处理
				this.defaultChipExternFuseBits = null;
				this.defaultChipExternFuseText = null;
				//---遍历所有的子节点
				foreach (XmlNode xmlNode in xmlNodeList)
				{
					//---将节点强制转换成元素
					XmlElement xmlElement = (XmlElement)xmlNode;
					//---查找的指定的属性
					string str = xmlElement.GetAttribute("Type").ToString();
					switch (str.ToUpper())
					{
						case "CHIP":
							this.AnalyseChipAVR8BitsMcuChipXml(xmlElement.GetAttribute("ID").ToString(),xmlNode);
							break;
						case "FUSEBITS":
							this.AnalyseChipAVR8BitsMcuFuseBitsXml(xmlElement.GetAttribute("ID").ToString(), xmlNode);
							break;
						case "FUSETEXT":
							this.AnalyseChipAVR8BitsMcuFuseTextXml(xmlElement.GetAttribute("ID").ToString(), xmlNode);
							break;
						default:
							break;
					}
				}
			}
			catch(Exception e)
			{
				this.defaultMsgText = e.ToString();
				//---打印Debug信息
				Debug.WriteLine(this.defaultMsgText);
				return false;
			}
			return true;
		}

		/// <summary>
		/// 从指定的XML节点中分析芯片的信息
		/// </summary>
		/// <param name="xmlNode"></param>
		/// <returns></returns>
		private bool AnalyseChipAVR8BitsMcuChipXml(string chipName,XmlNode xmlNode)
		{
			XmlNodeList xmlNodeList = xmlNode.ChildNodes;
			int _return = 0;
			//---轮询获取数据
			foreach (XmlNode xn in xmlNodeList)
			{
				switch (xn.Name.ToUpper())
				{
					//---获取设备的ID信息
					case "ID":
						this.ChipID = this.AnalyseChipAVR8BitsMcuXml(xn.InnerText, 16);
						_return += 1;
						break;
					//---获取芯片的ChipID
					case "IDCHIP":
						this.defaultIDChip = Convert.ToInt32(xn.InnerText, 16);
						_return += 1;
						break;
					//---获取设备的熔丝位
					case "FUSE":
						this.ChipFuse = this.AnalyseChipAVR8BitsMcuXml(xn.InnerText, 16);
						_return += 1;
						break;
					//---获取设备的加密位
					case "LOCK":
						this.defaultChipLock =(byte)Convert.ToInt32(xn.InnerText, 16);
						_return += 1;
						break;
					//---获取设备的Flash
					case "FLASH":
						if (this.AnalyseChipAVR8BitsMcuMemeryXml(xn.InnerText, ref this.defaultChipFlashPerPageWordNum, ref this.defaultChipFlashPageNum) == true)
						{
							_return += 1;
						}
						break;
					//---获取设备的Eeprom
					case "EEPROM":
						if (this.AnalyseChipAVR8BitsMcuMemeryXml(xn.InnerText, ref this.defaultChipEepromPerPageByteNum, ref this.defaultChipEepromPageNum) == true)
						{
							_return += 1;
						}
						break;
					//---获取内部RC的信息
					case "OSC":
						this.defaultChipOSC = new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuXml("内部RC频率",xn.InnerText));
						_return += 1;
						break;
					case "INTERFACE":
						this.defaultInterface=new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuXml("可用编程接口",xn.InnerText));
						_return += 1;
						break;
					default:
						break;
				}
			}
			if (_return!= xmlNodeList.Count)
			{
				this.defaultMsgText = "XML文件中的设备信息不完整！";
				//---打印Debug信息
				Debug.WriteLine(this.defaultMsgText);
				return false;
			}
			//---作为默认熔丝位
			this.defaultChipOSC.mMask = new int[this.defaultChipFuse.Length];
			//---拷贝数据
			Array.Copy(this.defaultChipFuse, this.defaultChipOSC.mMask, this.defaultChipFuse.Length);

			this.defaultChipName = chipName;
			return true;
		}

		/// <summary>
		/// 熔丝位BIT信息
		/// </summary>
		/// <param name="chipName"></param>
		/// <param name="xmlNode"></param>
		/// <returns></returns>
		private bool AnalyseChipAVR8BitsMcuFuseBitsXml(string chipName, XmlNode xmlNode)
		{
			switch (chipName.ToUpper())
			{
				case "LOWFUSE":
					this.defaultChipLowFuseBits = new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuFuseXml(chipName, xmlNode));
					break;
				case "HIGHFUSE":
					this.defaultChipHighFuseBits = new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuFuseXml(chipName, xmlNode));
					break;
				case "EXTERNFUSE":
					this.defaultChipExternFuseBits = new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuFuseXml(chipName, xmlNode));
					break;
				case "LOCKFUSE":
					this.defaultChipLockFuseBits = new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuFuseXml(chipName, xmlNode));
					break;
				default:
					break;
			}
			return true;
		}

		/// <summary>
		/// 熔丝位展开后的信息
		/// </summary>
		/// <param name="chipName"></param>
		/// <param name="xmlNode"></param>
		/// <returns></returns>
		private bool AnalyseChipAVR8BitsMcuFuseTextXml(string chipName, XmlNode xmlNode)
		{
			switch (chipName.ToUpper())
			{
				case "LOWFUSE":
					this.defaultChipLowFuseText=new CMcuFuncAVR8BitsParam (this.AnalyseChipAVR8BitsMcuFuseXml(chipName,xmlNode,1));
					break;
				case "HIGHFUSE":
					this.defaultChipHighFuseText = new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuFuseXml(chipName, xmlNode, 1));
					break;
				case "EXTERNFUSE":
					this.defaultChipExternFuseText = new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuFuseXml(chipName, xmlNode, 1));
					break;
				case "LOCKFUSE":
					this.defaultChipLockFuseText = new CMcuFuncAVR8BitsParam(this.AnalyseChipAVR8BitsMcuFuseXml(chipName, xmlNode, 1));
					break;
				default:
					break;
			}
			return true;
		}

		/// <summary>
		/// 从指定的字符串中获取mcu的信息
		/// </summary>
		/// <param name=""></param>
		/// <returns></returns>
		private byte[] AnalyseChipAVR8BitsMcuXml(string str, int fromBase)
		{
			string[] tempStr = str.Trim(' ').Split(',');
			byte[] _return = new byte[tempStr.Length];
			for (int i = 0; i < tempStr.Length; i++)
			{
				_return[i] = (byte)Convert.ToInt32(tempStr[i], fromBase);
			}
			return _return;
		}

		/// <summary>
		/// 从XML文件中获取存储器的信息
		/// </summary>
		/// <param name="str"></param>
		/// <param name="perPageNum"></param>
		/// <param name="pageNum"></param>
		/// <returns></returns>
		private bool AnalyseChipAVR8BitsMcuMemeryXml(string str, ref int perPageNum, ref int pageNum)
		{
			string[] tempStr = str.Trim(' ').Split(',');
			int[] _return = new int[tempStr.Length];
			for (int i = 0; i < tempStr.Length; i++)
			{
				_return[i] = Convert.ToInt32(tempStr[i], 10);
			}
			if (_return.Length != 2)
			{
				this.defaultMsgText = "XML文件中的解析错误！";
				//---打印Debug信息
				Debug.WriteLine(this.defaultMsgText);
				return false;
			}
			else
			{
				perPageNum = _return[0];
				pageNum = _return[1];
				return true;
			}
		}

		/// <summary>
		/// 从指定的数据中分析OSC信息
		/// </summary>
		/// <param name="str"></param>
		/// <param name="perPageNum"></param>
		/// <param name="pageNum"></param>
		/// <returns></returns>
		private CMcuFuncAVR8BitsParam AnalyseChipAVR8BitsMcuXml(string name, string str)
		{
			CMcuFuncAVR8BitsParam _return = new CMcuFuncAVR8BitsParam(name);
			string[] tempStr = str.Trim(' ').Split(',');
			if ((tempStr.Length & 0x01) != 0)
			{
				return null;
			}
			else
			{
				_return.mText = new string[tempStr.Length / 2];
				_return.mValue = new int[tempStr.Length / 2];
				for (int i = 0; i < _return.mText.Length; i++)
				{
					_return.mText[i] = tempStr[2 * i];
					_return.mValue[i] = Convert.ToInt32(tempStr[2 * i+1], 16);
				}
			}
			return _return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xmlNode"></param>
		/// <returns></returns>
		private CMcuFuncAVR8BitsParam AnalyseChipAVR8BitsMcuFuseXml(string chipName,XmlNode xmlNode,int offset=0)
		{
			XmlNodeList xmlNodeListP = xmlNode.ChildNodes;
			CMcuFuncAVR8BitsParam _return = null;
			if ((offset == 0)&&(xmlNodeListP.Count < 8))
			{
				_return = new CMcuFuncAVR8BitsParam(8, chipName);
			}
			else
			{
				_return = new CMcuFuncAVR8BitsParam(xmlNodeListP.Count, chipName);
			}
			
			int i = 0;
			//---轮询获取数据
			foreach (XmlNode xnp in xmlNodeListP)
			{
				//---去除字符串中非数字字符
				string str = Regex.Replace(xnp.Name, @"[^\d]*", "");
				i = int.Parse(str)-offset;
				//---获取相关节点下的信息
				XmlNodeList xmlNodeListC = xnp.ChildNodes;
				foreach (XmlNode xnc in xmlNodeListC)
				{
					switch (xnc.Name.ToUpper())
					{
						case "MASK":
							_return.mMask[i] = Convert.ToInt32(xnc.InnerText, 16);
							break;
						case "VALUE":
							_return.mValue[i] = Convert.ToInt32(xnc.InnerText, 16);
							break;
						case "TEXT":
							_return.mText[i] = xnc.InnerText;
							break;
						default:
							break;
						
					}
				}
			}
			return _return;
		}


		#endregion


		#region 解析MCU列表

		/// <summary>
		/// 获取支持的MCU列表
		/// </summary>
		/// <returns></returns>
		private string[] AnalyseAVR8BitsMcuListXml()
		{
			//---获取XML文件的位置
			string xmlPath = System.IO.Directory.GetCurrentDirectory() + "\\deviceXml" + "\\" + "Config.xml";
			//---清空错误消息
			this.defaultMsgText = string.Empty;
			//---校验当前XML文件是否存在
			if (!File.Exists(xmlPath))
			{
				this.defaultMsgText = "设备列别XML文件解析失败！";
				//---打印Debug信息
				Debug.WriteLine(this.defaultMsgText);
				return null;
			}
			List<string> _return = new List<string>();
			try
			{
				XmlDocument xmlDoc = new XmlDocument();
				XmlReaderSettings settings = new XmlReaderSettings();
				//---忽略文档里面的注释
				settings.IgnoreComments = true;
				XmlReader reader = XmlReader.Create(xmlPath, settings);
				//---加载XML文件
				xmlDoc.Load(reader);
				//---得到更节点所有的子节点
				XmlNodeList xmlNodeRoot = xmlDoc.SelectSingleNode("AVRPART").ChildNodes;
				//---遍历所有的子节点
				foreach (XmlNode xmlNode in xmlNodeRoot)
				{
					XmlNodeList xmlNodeA = xmlNode.ChildNodes;
					foreach (XmlNode xmlNodeB in xmlNodeA)
					{
						if (xmlNodeB.Name.ToUpper() == "TYPE")
						{
							XmlNodeList xmlNodeC = xmlNodeB.ChildNodes;
							foreach (XmlNode xmlNodeD in xmlNodeC)
							{
								_return.Add(xmlNodeD.InnerText);
							}
						}
						else
						{
							continue;
						}
					}
				}
			}
			catch (Exception e)
			{
				this.defaultMsgText = e.ToString();
				//---打印Debug信息
				Debug.WriteLine(this.defaultMsgText);
				return null;
			}
			return _return.ToArray();
		}


		#endregion

		#region 控件参数的解析

		/// <summary>
		/// 每Bit的信息
		/// </summary>
		/// <param name="clb"></param>
		/// <param name="fuseBits"></param>
		private void FuseCheckedListBoxBitsInit(CheckedListBox clb, CMcuFuncAVR8BitsParam fuseBits)
		{
			clb.Items.Clear();
			//---轮训解析数据
			for (int i = 0; i < 8; i++)
			{
				//---检验是否为空
				if (fuseBits == null)
				{
					clb.Items.Add("NC");
					clb.SetItemCheckState(i, CheckState.Unchecked);
					clb.SetItemCheckState(i, CheckState.Indeterminate);  //是控件处于不可选定状态
				}
				else
				{
					clb.Items.Add(fuseBits.mText[7 - i]);
					//---检验是不是NC参数
					if (fuseBits.mText[7 - i] == "NC")
					{
						clb.SetItemCheckState(i, CheckState.Unchecked);
						clb.SetItemCheckState(i, CheckState.Indeterminate);  //是控件处于不可选定状态
					}
					else
					{
						if (fuseBits.mValue[7 - i] != 0)
						{
							clb.SetItemCheckState(i, CheckState.Checked);
						}
						else
						{
							clb.SetItemCheckState(i, CheckState.Unchecked);
						}
					}
				}
			}
		}

		/// <summary>
		/// 组合Bit对应的Text值
		/// </summary>
		private void FuseCheckedListBoxTextInit(CheckedListBox clb, TextBox lowFuseValue, TextBox highFuseValue, TextBox externFuseValue, TextBox lockFuseValue)
		{
			int offsetIndex = 0;
			int i = 0;
			clb.Items.Clear();
			int[] tempFuse = new int[this.ChipFuse.Length + 1];
			Array.Copy(this.ChipFuse, tempFuse, (tempFuse.Length - 1));
			//---当前加密位
			tempFuse[tempFuse.Length - 1] = this.ChipLock;
			//---获取拓展位
			CMcuFuncAVR8BitsParam temCMcuParam = this.ChipExternFuseText;
			//---校验熔丝位
			if (temCMcuParam != null)
			{
				for (i = 0; i < temCMcuParam.mLength; i++)
				{
					clb.Items.Add(temCMcuParam.mText[i]);
					if ((tempFuse[2] & temCMcuParam.mMask[i]) == temCMcuParam.mValue[i])
					{
						clb.SetItemCheckState(i + offsetIndex, CheckState.Checked);
					}
					else
					{
						clb.SetItemCheckState(i + offsetIndex, CheckState.Unchecked);
					}
				}
				externFuseValue.Text = tempFuse[2].ToString("X2");
				offsetIndex += i;
			}
			//---获取高位
			temCMcuParam = this.ChipHighFuseText;
			//---校验熔丝位
			if (temCMcuParam != null)
			{
				for (i = 0; i < temCMcuParam.mLength; i++)
				{
					clb.Items.Add(temCMcuParam.mText[i]);
					if ((tempFuse[1] & temCMcuParam.mMask[i]) == temCMcuParam.mValue[i])
					{
						clb.SetItemCheckState(i + offsetIndex, CheckState.Checked);
					}
					else
					{
						clb.SetItemCheckState(i + offsetIndex, CheckState.Unchecked);
					}
				}
				highFuseValue.Text = tempFuse[1].ToString("X2");
				offsetIndex += i;
			}
			//---获取低位
			temCMcuParam = this.ChipLowFuseText;
			//---校验熔丝位
			if (temCMcuParam != null)
			{
				for (i = 0; i < temCMcuParam.mLength; i++)
				{
					clb.Items.Add(temCMcuParam.mText[i]);
					if ((tempFuse[0] & temCMcuParam.mMask[i]) == temCMcuParam.mValue[i])
					{
						clb.SetItemCheckState(i + offsetIndex, CheckState.Checked);
					}
					else
					{
						clb.SetItemCheckState(i + offsetIndex, CheckState.Unchecked);
					}
				}
				lowFuseValue.Text = tempFuse[0].ToString("X2");
				offsetIndex += i;
			}
			//---获取加密位
			temCMcuParam = this.ChipLockFuseText;
			//---校验加密位
			if (temCMcuParam != null)
			{
				for (i = 0; i < temCMcuParam.mLength; i++)
				{
					clb.Items.Add(temCMcuParam.mText[i]);
					if ((tempFuse[tempFuse.Length-1] & temCMcuParam.mMask[i]) == temCMcuParam.mValue[i])
					{
						clb.SetItemCheckState(i + offsetIndex, CheckState.Checked);
					}
					else
					{
						clb.SetItemCheckState(i + offsetIndex, CheckState.Unchecked);
					}
				}
				lockFuseValue.Text = tempFuse[tempFuse.Length - 1].ToString("X2");
				offsetIndex += i;
			}
		}

		/// <summary>
		/// 内部RC控件初始化
		/// </summary>
		private void OSCControlInit(Label oscText1, Label oscText2, Label oscText3, Label oscText4,
							TextBox oscValue1, TextBox oscValue2, TextBox oscValue3, TextBox oscValue4)
		{
			oscText1.Visible = false;
			oscText2.Visible = false;
			oscText3.Visible = false;
			oscText4.Visible = false;

			oscValue1.Visible = false;
			oscValue2.Visible = false;
			oscValue3.Visible = false;
			oscValue4.Visible = false;

			for (int i = 0; i < this.ChipOSC.mLength; i++)
			{
				switch (i)
				{
					case 0:
						oscText1.Visible = true;
						oscValue1.Visible = true;
						oscText1.Text = this.ChipOSC.mText[i];
						oscValue1.Text = this.ChipOSC.mValue[i].ToString("X2");
						break;
					case 1:
						oscText2.Visible = true;
						oscValue2.Visible = true;
						oscText2.Text = this.ChipOSC.mText[i];
						oscValue2.Text = this.ChipOSC.mValue[i].ToString("X2");
						break;
					case 2:
						oscText3.Visible = true;
						oscValue3.Visible = true;
						oscText3.Text = this.ChipOSC.mText[i];
						oscValue3.Text = this.ChipOSC.mValue[i].ToString("X2");
						break;
					case 3:
						oscText4.Visible = true;
						oscValue4.Visible = true;
						oscText4.Text = this.ChipOSC.mText[i];
						oscValue4.Text = this.ChipOSC.mValue[i].ToString("X2");
						break;
					default:
						break;
				}
			}
		}

		#endregion

		#endregion

		#region 事件函数

		#endregion
	}
}

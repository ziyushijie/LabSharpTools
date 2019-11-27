﻿namespace LabMcuForm
{
	partial class CMcuFormAVR8BitsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.cCommBaseControl_ChipCOMM = new Harry.LabTools.LabCommType.CCommBaseControl();
			this.panel_ChipID = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.groupBox_ChipType = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel_ChipMsg = new System.Windows.Forms.Panel();
			this.cRichTextBoxEx_ChipMsg = new Harry.LabTools.LabControlPlus.CRichTextBoxEx();
			this.panel_ChipFunc = new System.Windows.Forms.Panel();
			this.panel_ChipCheckFunc = new System.Windows.Forms.Panel();
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse = new LabMcuForm.CMcuFormAVR8Bits.CMcuFormAVR8BitsFuseAndLockControl();
			this.panel_ChipButtonFunc = new System.Windows.Forms.Panel();
			this.toolStrip_ChipTool = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel_ChipStateName = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel_ChipState = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel_ChipTimeName = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel_ChipTime = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripProgressBar_ChipProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel_ChipRTCTimerName = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel_ChipRTCTimer = new System.Windows.Forms.ToolStripLabel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.cHexBox1 = new Harry.LabTools.LabHexEdit.CHexBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.cHexBox2 = new Harry.LabTools.LabHexEdit.CHexBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.cHexBox3 = new Harry.LabTools.LabHexEdit.CHexBox();
			this.menuStrip_ChipMenu = new System.Windows.Forms.MenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.命令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.编辑XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer_ChipRTCTime = new System.Windows.Forms.Timer(this.components);
			this.panel_ChipID.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox_ChipType.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel_ChipMsg.SuspendLayout();
			this.panel_ChipFunc.SuspendLayout();
			this.toolStrip_ChipTool.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.menuStrip_ChipMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// cCommBaseControl_ChipCOMM
			// 
			this.cCommBaseControl_ChipCOMM.Dock = System.Windows.Forms.DockStyle.Right;
			this.cCommBaseControl_ChipCOMM.Location = new System.Drawing.Point(939, 3);
			this.cCommBaseControl_ChipCOMM.mCCOMM = null;
			this.cCommBaseControl_ChipCOMM.mCCommRichTextBox = null;
			this.cCommBaseControl_ChipCOMM.mIsShowCommParam = true;
			this.cCommBaseControl_ChipCOMM.Name = "cCommBaseControl_ChipCOMM";
			this.cCommBaseControl_ChipCOMM.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.cCommBaseControl_ChipCOMM.Size = new System.Drawing.Size(262, 71);
			this.cCommBaseControl_ChipCOMM.TabIndex = 0;
			// 
			// panel_ChipID
			// 
			this.panel_ChipID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_ChipID.Controls.Add(this.groupBox3);
			this.panel_ChipID.Controls.Add(this.groupBox2);
			this.panel_ChipID.Controls.Add(this.groupBox1);
			this.panel_ChipID.Controls.Add(this.groupBox_ChipType);
			this.panel_ChipID.Controls.Add(this.cCommBaseControl_ChipCOMM);
			this.panel_ChipID.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_ChipID.Location = new System.Drawing.Point(2, 2);
			this.panel_ChipID.Name = "panel_ChipID";
			this.panel_ChipID.Padding = new System.Windows.Forms.Padding(3);
			this.panel_ChipID.Size = new System.Drawing.Size(1206, 79);
			this.panel_ChipID.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.trackBar1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox3.Location = new System.Drawing.Point(518, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(411, 71);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "时钟配置";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(383, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 12);
			this.label8.TabIndex = 11;
			this.label8.Text = "KHz";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(333, 14);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(45, 21);
			this.textBox4.TabIndex = 10;
			this.textBox4.Text = "200";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(332, 42);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(73, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = "时钟设置";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// trackBar1
			// 
			this.trackBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.trackBar1.Location = new System.Drawing.Point(3, 17);
			this.trackBar1.Maximum = 19;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(323, 51);
			this.trackBar1.TabIndex = 0;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox2.Location = new System.Drawing.Point(351, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(167, 71);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "电源选项";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(8, 18);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(84, 16);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "使能自供电";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(114, 42);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(46, 23);
			this.button4.TabIndex = 8;
			this.button4.Text = "读取";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(93, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(11, 12);
			this.label5.TabIndex = 7;
			this.label5.Text = "V";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(42, 42);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(45, 21);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "3.30";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 5;
			this.label6.Text = "电压";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 12);
			this.label7.TabIndex = 2;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(114, 15);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(46, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "设置";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox1.Location = new System.Drawing.Point(184, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(167, 71);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "接口类型";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(114, 42);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(46, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "读取";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(93, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(11, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "V";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(42, 42);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(45, 21);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "3.30";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "电压";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "接口";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(114, 15);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(46, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "应用";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "ISP",
            "JTAG",
            "HVPP",
            "HVSP"});
			this.comboBox2.Location = new System.Drawing.Point(41, 18);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(67, 20);
			this.comboBox2.TabIndex = 2;
			// 
			// groupBox_ChipType
			// 
			this.groupBox_ChipType.Controls.Add(this.comboBox1);
			this.groupBox_ChipType.Controls.Add(this.button1);
			this.groupBox_ChipType.Controls.Add(this.textBox1);
			this.groupBox_ChipType.Controls.Add(this.label1);
			this.groupBox_ChipType.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox_ChipType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox_ChipType.Location = new System.Drawing.Point(3, 3);
			this.groupBox_ChipType.Name = "groupBox_ChipType";
			this.groupBox_ChipType.Size = new System.Drawing.Size(181, 71);
			this.groupBox_ChipType.TabIndex = 1;
			this.groupBox_ChipType.TabStop = false;
			this.groupBox_ChipType.Text = "芯片类型";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 18);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(118, 20);
			this.comboBox1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(131, 42);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "读取";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(29, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(96, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "1E:93:07";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.ItemSize = new System.Drawing.Size(56, 18);
			this.tabControl1.Location = new System.Drawing.Point(2, 28);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1218, 684);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPage1.Controls.Add(this.panel_ChipMsg);
			this.tabPage1.Controls.Add(this.panel_ChipFunc);
			this.tabPage1.Controls.Add(this.panel_ChipButtonFunc);
			this.tabPage1.Controls.Add(this.toolStrip_ChipTool);
			this.tabPage1.Controls.Add(this.panel_ChipID);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(1210, 658);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "编程";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel_ChipMsg
			// 
			this.panel_ChipMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_ChipMsg.Controls.Add(this.cRichTextBoxEx_ChipMsg);
			this.panel_ChipMsg.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_ChipMsg.Location = new System.Drawing.Point(2, 392);
			this.panel_ChipMsg.Name = "panel_ChipMsg";
			this.panel_ChipMsg.Size = new System.Drawing.Size(1038, 239);
			this.panel_ChipMsg.TabIndex = 7;
			// 
			// cRichTextBoxEx_ChipMsg
			// 
			this.cRichTextBoxEx_ChipMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cRichTextBoxEx_ChipMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cRichTextBoxEx_ChipMsg.Location = new System.Drawing.Point(0, 0);
			this.cRichTextBoxEx_ChipMsg.Name = "cRichTextBoxEx_ChipMsg";
			this.cRichTextBoxEx_ChipMsg.Size = new System.Drawing.Size(1036, 237);
			this.cRichTextBoxEx_ChipMsg.TabIndex = 0;
			this.cRichTextBoxEx_ChipMsg.Text = "";
			// 
			// panel_ChipFunc
			// 
			this.panel_ChipFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_ChipFunc.Controls.Add(this.panel_ChipCheckFunc);
			this.panel_ChipFunc.Controls.Add(this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse);
			this.panel_ChipFunc.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_ChipFunc.Location = new System.Drawing.Point(2, 81);
			this.panel_ChipFunc.Name = "panel_ChipFunc";
			this.panel_ChipFunc.Size = new System.Drawing.Size(1038, 311);
			this.panel_ChipFunc.TabIndex = 6;
			// 
			// panel_ChipCheckFunc
			// 
			this.panel_ChipCheckFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_ChipCheckFunc.Location = new System.Drawing.Point(661, 6);
			this.panel_ChipCheckFunc.Name = "panel_ChipCheckFunc";
			this.panel_ChipCheckFunc.Size = new System.Drawing.Size(371, 299);
			this.panel_ChipCheckFunc.TabIndex = 1;
			// 
			// cMcuFormAVR8BitsFuseAndLockControl_ChipFuse
			// 
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.Dock = System.Windows.Forms.DockStyle.Left;
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.Location = new System.Drawing.Point(0, 0);
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.MaximumSize = new System.Drawing.Size(655, 305);
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.MinimumSize = new System.Drawing.Size(655, 305);
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.Name = "cMcuFormAVR8BitsFuseAndLockControl_ChipFuse";
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.Size = new System.Drawing.Size(655, 305);
			this.cMcuFormAVR8BitsFuseAndLockControl_ChipFuse.TabIndex = 0;
			// 
			// panel_ChipButtonFunc
			// 
			this.panel_ChipButtonFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_ChipButtonFunc.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_ChipButtonFunc.Location = new System.Drawing.Point(1040, 81);
			this.panel_ChipButtonFunc.Name = "panel_ChipButtonFunc";
			this.panel_ChipButtonFunc.Size = new System.Drawing.Size(168, 550);
			this.panel_ChipButtonFunc.TabIndex = 5;
			// 
			// toolStrip_ChipTool
			// 
			this.toolStrip_ChipTool.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip_ChipTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_ChipStateName,
            this.toolStripSeparator1,
            this.toolStripLabel_ChipState,
            this.toolStripSeparator2,
            this.toolStripLabel_ChipTimeName,
            this.toolStripSeparator3,
            this.toolStripLabel_ChipTime,
            this.toolStripSeparator4,
            this.toolStripProgressBar_ChipProgressBar,
            this.toolStripSeparator5,
            this.toolStripLabel_ChipRTCTimerName,
            this.toolStripSeparator6,
            this.toolStripLabel_ChipRTCTimer});
			this.toolStrip_ChipTool.Location = new System.Drawing.Point(2, 631);
			this.toolStrip_ChipTool.Name = "toolStrip_ChipTool";
			this.toolStrip_ChipTool.Size = new System.Drawing.Size(1206, 25);
			this.toolStrip_ChipTool.TabIndex = 4;
			this.toolStrip_ChipTool.Text = "toolStrip1";
			// 
			// toolStripLabel_ChipStateName
			// 
			this.toolStripLabel_ChipStateName.Name = "toolStripLabel_ChipStateName";
			this.toolStripLabel_ChipStateName.Size = new System.Drawing.Size(32, 22);
			this.toolStripLabel_ChipStateName.Text = "状态";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel_ChipState
			// 
			this.toolStripLabel_ChipState.AutoSize = false;
			this.toolStripLabel_ChipState.Name = "toolStripLabel_ChipState";
			this.toolStripLabel_ChipState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStripLabel_ChipState.Size = new System.Drawing.Size(160, 22);
			this.toolStripLabel_ChipState.Text = "空闲";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel_ChipTimeName
			// 
			this.toolStripLabel_ChipTimeName.Name = "toolStripLabel_ChipTimeName";
			this.toolStripLabel_ChipTimeName.Size = new System.Drawing.Size(56, 22);
			this.toolStripLabel_ChipTimeName.Text = "使用时间";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel_ChipTime
			// 
			this.toolStripLabel_ChipTime.AutoSize = false;
			this.toolStripLabel_ChipTime.Name = "toolStripLabel_ChipTime";
			this.toolStripLabel_ChipTime.Size = new System.Drawing.Size(96, 22);
			this.toolStripLabel_ChipTime.Text = "00-00-00";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripProgressBar_ChipProgressBar
			// 
			this.toolStripProgressBar_ChipProgressBar.AutoSize = false;
			this.toolStripProgressBar_ChipProgressBar.Name = "toolStripProgressBar_ChipProgressBar";
			this.toolStripProgressBar_ChipProgressBar.Size = new System.Drawing.Size(578, 22);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel_ChipRTCTimerName
			// 
			this.toolStripLabel_ChipRTCTimerName.Name = "toolStripLabel_ChipRTCTimerName";
			this.toolStripLabel_ChipRTCTimerName.Size = new System.Drawing.Size(56, 22);
			this.toolStripLabel_ChipRTCTimerName.Text = "当前时间";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel_ChipRTCTimer
			// 
			this.toolStripLabel_ChipRTCTimer.AutoSize = false;
			this.toolStripLabel_ChipRTCTimer.Name = "toolStripLabel_ChipRTCTimer";
			this.toolStripLabel_ChipRTCTimer.Size = new System.Drawing.Size(148, 22);
			this.toolStripLabel_ChipRTCTimer.Text = "0000-00-00-00-00-00";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPage2.Controls.Add(this.tabControl2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1210, 658);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "编辑";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Controls.Add(this.tabPage5);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl2.ItemSize = new System.Drawing.Size(56, 18);
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(1210, 658);
			this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl2.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPage3.Controls.Add(this.cHexBox1);
			this.tabPage3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabPage3.Location = new System.Drawing.Point(4, 4);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage3.Size = new System.Drawing.Size(1202, 632);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "FLASH";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// cHexBox1
			// 
			this.cHexBox1.BackColor = System.Drawing.Color.White;
			this.cHexBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cHexBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cHexBox1.Location = new System.Drawing.Point(2, 2);
			this.cHexBox1.mExternalLineColor = System.Drawing.Color.DarkGray;
			this.cHexBox1.mExternalLineWidth = 2;
			this.cHexBox1.mFirstRowOffset = 4;
			this.cHexBox1.mFont = new System.Drawing.Font("楷体", 12F);
			this.cHexBox1.mFontBackGroundColor = System.Drawing.Color.White;
			this.cHexBox1.mNewDataChange = false;
			this.cHexBox1.mNowData = new byte[] {
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255))};
			this.cHexBox1.mRowDisplayNum = 16;
			this.cHexBox1.mRowStaffWidth = 8;
			this.cHexBox1.mShowChangeBackGroundColor = System.Drawing.Color.Yellow;
			this.cHexBox1.mShowChangeFlag = false;
			this.cHexBox1.mXScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox1.mXScaleBackGroundRectangleShow = true;
			this.cHexBox1.mXScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox1.mXScaleHeight = 24;
			this.cHexBox1.mXScaleHeightOffset = 2;
			this.cHexBox1.mXScaleShow = true;
			this.cHexBox1.mXScaleShowBit8 = Harry.LabTools.LabHexEdit.CHexBox.XScaleShowBit8.BIT8X16;
			this.cHexBox1.mXScaleStringShow = true;
			this.cHexBox1.mXScaleStringStartWidth = 579;
			this.cHexBox1.mYScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox1.mYScaleBackGroundRectangleShow = true;
			this.cHexBox1.mYScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox1.mYScaleOffsetWidth = 32;
			this.cHexBox1.mYScaleShow = true;
			this.cHexBox1.mYScaleShowBit4 = Harry.LabTools.LabHexEdit.CHexBox.YScaleShowBit4.BIT4X4;
			this.cHexBox1.mYScaleWidth = 86;
			this.cHexBox1.Name = "cHexBox1";
			this.cHexBox1.Size = new System.Drawing.Size(1198, 628);
			this.cHexBox1.TabIndex = 0;
			this.cHexBox1.Text = "cHexBox1";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPage4.Controls.Add(this.cHexBox2);
			this.tabPage4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabPage4.Location = new System.Drawing.Point(4, 4);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage4.Size = new System.Drawing.Size(1202, 632);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "EEPROM";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// cHexBox2
			// 
			this.cHexBox2.BackColor = System.Drawing.Color.White;
			this.cHexBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cHexBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cHexBox2.Location = new System.Drawing.Point(2, 2);
			this.cHexBox2.mExternalLineColor = System.Drawing.Color.DarkGray;
			this.cHexBox2.mExternalLineWidth = 2;
			this.cHexBox2.mFirstRowOffset = 4;
			this.cHexBox2.mFont = new System.Drawing.Font("楷体", 12F);
			this.cHexBox2.mFontBackGroundColor = System.Drawing.Color.White;
			this.cHexBox2.mNewDataChange = false;
			this.cHexBox2.mNowData = new byte[] {
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255))};
			this.cHexBox2.mRowDisplayNum = 16;
			this.cHexBox2.mRowStaffWidth = 8;
			this.cHexBox2.mShowChangeBackGroundColor = System.Drawing.Color.Yellow;
			this.cHexBox2.mShowChangeFlag = false;
			this.cHexBox2.mXScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox2.mXScaleBackGroundRectangleShow = true;
			this.cHexBox2.mXScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox2.mXScaleHeight = 24;
			this.cHexBox2.mXScaleHeightOffset = 2;
			this.cHexBox2.mXScaleShow = true;
			this.cHexBox2.mXScaleShowBit8 = Harry.LabTools.LabHexEdit.CHexBox.XScaleShowBit8.BIT8X16;
			this.cHexBox2.mXScaleStringShow = true;
			this.cHexBox2.mXScaleStringStartWidth = 579;
			this.cHexBox2.mYScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox2.mYScaleBackGroundRectangleShow = true;
			this.cHexBox2.mYScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox2.mYScaleOffsetWidth = 32;
			this.cHexBox2.mYScaleShow = true;
			this.cHexBox2.mYScaleShowBit4 = Harry.LabTools.LabHexEdit.CHexBox.YScaleShowBit4.BIT4X4;
			this.cHexBox2.mYScaleWidth = 86;
			this.cHexBox2.Name = "cHexBox2";
			this.cHexBox2.Size = new System.Drawing.Size(1198, 628);
			this.cHexBox2.TabIndex = 1;
			this.cHexBox2.Text = "cHexBox2";
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.cHexBox3);
			this.tabPage5.Location = new System.Drawing.Point(4, 4);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(1202, 632);
			this.tabPage5.TabIndex = 2;
			this.tabPage5.Text = "ROM";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// cHexBox3
			// 
			this.cHexBox3.BackColor = System.Drawing.Color.White;
			this.cHexBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cHexBox3.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cHexBox3.Location = new System.Drawing.Point(0, 0);
			this.cHexBox3.mExternalLineColor = System.Drawing.Color.DarkGray;
			this.cHexBox3.mExternalLineWidth = 2;
			this.cHexBox3.mFirstRowOffset = 4;
			this.cHexBox3.mFont = new System.Drawing.Font("楷体", 12F);
			this.cHexBox3.mFontBackGroundColor = System.Drawing.Color.White;
			this.cHexBox3.mNewDataChange = false;
			this.cHexBox3.mNowData = new byte[] {
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255))};
			this.cHexBox3.mRowDisplayNum = 16;
			this.cHexBox3.mRowStaffWidth = 8;
			this.cHexBox3.mShowChangeBackGroundColor = System.Drawing.Color.Yellow;
			this.cHexBox3.mShowChangeFlag = false;
			this.cHexBox3.mXScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox3.mXScaleBackGroundRectangleShow = true;
			this.cHexBox3.mXScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox3.mXScaleHeight = 24;
			this.cHexBox3.mXScaleHeightOffset = 2;
			this.cHexBox3.mXScaleShow = true;
			this.cHexBox3.mXScaleShowBit8 = Harry.LabTools.LabHexEdit.CHexBox.XScaleShowBit8.BIT8X16;
			this.cHexBox3.mXScaleStringShow = true;
			this.cHexBox3.mXScaleStringStartWidth = 579;
			this.cHexBox3.mYScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox3.mYScaleBackGroundRectangleShow = true;
			this.cHexBox3.mYScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox3.mYScaleOffsetWidth = 32;
			this.cHexBox3.mYScaleShow = true;
			this.cHexBox3.mYScaleShowBit4 = Harry.LabTools.LabHexEdit.CHexBox.YScaleShowBit4.BIT4X4;
			this.cHexBox3.mYScaleWidth = 86;
			this.cHexBox3.Name = "cHexBox3";
			this.cHexBox3.Size = new System.Drawing.Size(1202, 632);
			this.cHexBox3.TabIndex = 1;
			this.cHexBox3.Text = "cHexBox3";
			// 
			// menuStrip_ChipMenu
			// 
			this.menuStrip_ChipMenu.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.menuStrip_ChipMenu.GripMargin = new System.Windows.Forms.Padding(2);
			this.menuStrip_ChipMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.命令ToolStripMenuItem,
            this.编辑XToolStripMenuItem,
            this.关于WToolStripMenuItem});
			this.menuStrip_ChipMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip_ChipMenu.Location = new System.Drawing.Point(2, 2);
			this.menuStrip_ChipMenu.Margin = new System.Windows.Forms.Padding(3);
			this.menuStrip_ChipMenu.Name = "menuStrip_ChipMenu";
			this.menuStrip_ChipMenu.Padding = new System.Windows.Forms.Padding(3);
			this.menuStrip_ChipMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip_ChipMenu.Size = new System.Drawing.Size(1218, 26);
			this.menuStrip_ChipMenu.TabIndex = 3;
			this.menuStrip_ChipMenu.Text = "menuStrip1";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2);
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.文件ToolStripMenuItem.Text = "文件(&Z)";
			// 
			// 命令ToolStripMenuItem
			// 
			this.命令ToolStripMenuItem.Name = "命令ToolStripMenuItem";
			this.命令ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2);
			this.命令ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.命令ToolStripMenuItem.Text = "命令(&Y)";
			// 
			// 编辑XToolStripMenuItem
			// 
			this.编辑XToolStripMenuItem.Name = "编辑XToolStripMenuItem";
			this.编辑XToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2);
			this.编辑XToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.编辑XToolStripMenuItem.Text = "编辑(&X)";
			// 
			// 关于WToolStripMenuItem
			// 
			this.关于WToolStripMenuItem.Name = "关于WToolStripMenuItem";
			this.关于WToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2);
			this.关于WToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.关于WToolStripMenuItem.Text = "关于(&W)";
			// 
			// timer_ChipRTCTime
			// 
			this.timer_ChipRTCTime.Enabled = true;
			this.timer_ChipRTCTime.Interval = 1000;
			this.timer_ChipRTCTime.Tag = "timer_ChipRTCTime";
			// 
			// CMcuFormAVR8BitsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1222, 714);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip_ChipMenu);
			this.MainMenuStrip = this.menuStrip_ChipMenu;
			this.Name = "CMcuFormAVR8BitsForm";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CMcuFormAVR8Bits";
			this.panel_ChipID.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox_ChipType.ResumeLayout(false);
			this.groupBox_ChipType.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.panel_ChipMsg.ResumeLayout(false);
			this.panel_ChipFunc.ResumeLayout(false);
			this.toolStrip_ChipTool.ResumeLayout(false);
			this.toolStrip_ChipTool.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.menuStrip_ChipMenu.ResumeLayout(false);
			this.menuStrip_ChipMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Harry.LabTools.LabCommType.CCommBaseControl cCommBaseControl_ChipCOMM;
		private System.Windows.Forms.Panel panel_ChipID;
		private System.Windows.Forms.GroupBox groupBox_ChipType;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.MenuStrip menuStrip_ChipMenu;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 命令ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 编辑XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于WToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox4;
		private Harry.LabTools.LabHexEdit.CHexBox cHexBox1;
		private Harry.LabTools.LabHexEdit.CHexBox cHexBox2;
		private System.Windows.Forms.ToolStrip toolStrip_ChipTool;
		private System.Windows.Forms.Panel panel_ChipMsg;
		private System.Windows.Forms.Panel panel_ChipFunc;
		private System.Windows.Forms.Panel panel_ChipCheckFunc;
		private CMcuFormAVR8Bits.CMcuFormAVR8BitsFuseAndLockControl cMcuFormAVR8BitsFuseAndLockControl_ChipFuse;
		private System.Windows.Forms.Panel panel_ChipButtonFunc;
		private Harry.LabTools.LabControlPlus.CRichTextBoxEx cRichTextBoxEx_ChipMsg;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_ChipStateName;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_ChipState;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_ChipTimeName;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_ChipTime;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_ChipProgressBar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_ChipRTCTimerName;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_ChipRTCTimer;
		private System.Windows.Forms.Timer timer_ChipRTCTime;
		private System.Windows.Forms.TabPage tabPage5;
		private Harry.LabTools.LabHexEdit.CHexBox cHexBox3;
	}
}
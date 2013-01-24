// Copyright 2006 ESRI
//
// All rights reserved under the copyright laws of the United States
// and applicable international laws, treaties, and conventions.
//
// You may freely redistribute and use this sample code, with or
// without modification, provided you include the original copyright
// notice and use restrictions.
//
// See use restrictions at /arcgis/developerkit/userestrictions.

using System;
using System.Windows.Forms;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;


namespace MDIApplication
{
  public class ParentForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.ComponentModel.IContainer components;
		private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
        private MenuItem menuItem12;
        private MenuItem menuItem13;
        private MenuItem menuItem17;
        private MenuItem menuItem19;
        private MenuItem menuItem14;
        private MenuItem menuItem15;
        private MenuItem menuItem25;
        private MenuItem menuItem27;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private MenuItem menuItem30;
        private MenuItem menuItem31;
        private MenuItem menuItem32;
        private MenuItem menuItem33;
        private MenuItem menuItem34;
        private MenuItem menuItem35;
        private MenuItem menuItem36;
        private MenuItem menuItem38;
        private MenuItem menuItem40;
        private MenuItem menuItem43;
        private MenuItem menuItem45;
        private MenuItem menuItem47;
        private MenuItem menuItem53;
        private MenuItem menuItem54;
        private MenuItem menuItem62;
        private MenuItem menuItem63;
        private MenuItem menuItem64;
        private MenuItem menuItem66;
        private MenuItem menuItem68;
        private MenuItem menuItem71;
        private MenuItem menuItem76;
        private MenuItem menuItem90;
        private MenuItem menuItem91;
        private MenuItem menuItem92;
        private OpenFileDialog openFileDialog1;
        private int mdiform_sum = 0;//新建窗体总数
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl3;
        private MenuItem menuItem8;
        private MenuItem menuItem26;
        private MenuItem menuItem3;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl4;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl2;
        private ToolBar toolBar1;

        IToolbarItem pToolbarItem;
        private MenuItem menuItem28;
        public ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl5;
        private MenuItem menuItem18;
        private SaveFileDialog saveFileDialog1;
        private MenuItem menuItem16;
        private MenuItem menuItem20;
        private MenuItem menuItem21;
        private MenuItem menuItem22;
        private MenuItem menuItem23;
        private MenuItem menuItem24;
        private MenuItem menuItem29;
        private MenuItem menuItem37;
        private MenuItem menuItem39;
        private MenuItem menuItem41;

        public static int pyBtn;//平移操作

		public ParentForm()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{	
			ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem76 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem32 = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.menuItem36 = new System.Windows.Forms.MenuItem();
            this.menuItem38 = new System.Windows.Forms.MenuItem();
            this.menuItem40 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem43 = new System.Windows.Forms.MenuItem();
            this.menuItem45 = new System.Windows.Forms.MenuItem();
            this.menuItem47 = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.menuItem54 = new System.Windows.Forms.MenuItem();
            this.menuItem53 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.menuItem37 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem68 = new System.Windows.Forms.MenuItem();
            this.menuItem62 = new System.Windows.Forms.MenuItem();
            this.menuItem71 = new System.Windows.Forms.MenuItem();
            this.menuItem63 = new System.Windows.Forms.MenuItem();
            this.menuItem64 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem66 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem31 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.menuItem90 = new System.Windows.Forms.MenuItem();
            this.menuItem91 = new System.Windows.Forms.MenuItem();
            this.menuItem92 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem39 = new System.Windows.Forms.MenuItem();
            this.menuItem41 = new System.Windows.Forms.MenuItem();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axToolbarControl3 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axToolbarControl4 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axToolbarControl2 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.axToolbarControl5 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem10,
            this.menuItem11,
            this.menuItem12,
            this.menuItem13,
            this.menuItem14,
            this.menuItem4,
            this.menuItem15});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem25,
            this.menuItem3,
            this.menuItem27,
            this.menuItem8,
            this.menuItem76,
            this.menuItem26,
            this.menuItem7});
            this.menuItem1.Text = "文件(&F)";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItem2.Text = "新建";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 1;
            this.menuItem25.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItem25.Text = "打开";
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 3;
            this.menuItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItem27.Text = "保存";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 4;
            this.menuItem8.Text = "-";
            // 
            // menuItem76
            // 
            this.menuItem76.Index = 5;
            this.menuItem76.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuItem76.Text = "打印";
            this.menuItem76.Click += new System.EventHandler(this.menuItem76_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 6;
            this.menuItem26.Text = "-";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 7;
            this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.menuItem7.Text = "退出";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem32,
            this.menuItem33,
            this.menuItem34,
            this.menuItem35,
            this.menuItem36,
            this.menuItem38,
            this.menuItem40});
            this.menuItem10.Text = "编辑(&E)";
            // 
            // menuItem32
            // 
            this.menuItem32.Index = 0;
            this.menuItem32.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.menuItem32.Text = "撤销";
            this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 1;
            this.menuItem33.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.menuItem33.Text = "前进";
            this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 2;
            this.menuItem34.Text = "-";
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 3;
            this.menuItem35.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItem35.Text = "剪切";
            this.menuItem35.Click += new System.EventHandler(this.menuItem35_Click);
            // 
            // menuItem36
            // 
            this.menuItem36.Index = 4;
            this.menuItem36.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuItem36.Text = "复制";
            this.menuItem36.Click += new System.EventHandler(this.menuItem36_Click);
            // 
            // menuItem38
            // 
            this.menuItem38.Index = 5;
            this.menuItem38.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuItem38.Text = "粘贴";
            this.menuItem38.Click += new System.EventHandler(this.menuItem38_Click);
            // 
            // menuItem40
            // 
            this.menuItem40.Index = 6;
            this.menuItem40.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.menuItem40.Text = "删除";
            this.menuItem40.Click += new System.EventHandler(this.menuItem40_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem43,
            this.menuItem45,
            this.menuItem47,
            this.menuItem28,
            this.menuItem54,
            this.menuItem53,
            this.menuItem20,
            this.menuItem21});
            this.menuItem11.Text = "视图(&V)";
            // 
            // menuItem43
            // 
            this.menuItem43.Index = 0;
            this.menuItem43.Text = "平面视图";
            // 
            // menuItem45
            // 
            this.menuItem45.Index = 1;
            this.menuItem45.Text = "球面视图";
            this.menuItem45.Click += new System.EventHandler(this.menuItem45_Click);
            // 
            // menuItem47
            // 
            this.menuItem47.Index = 2;
            this.menuItem47.Text = "-";
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 3;
            this.menuItem28.Text = "前视图";
            this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
            // 
            // menuItem54
            // 
            this.menuItem54.Index = 4;
            this.menuItem54.Text = "后视图";
            this.menuItem54.Click += new System.EventHandler(this.menuItem54_Click);
            // 
            // menuItem53
            // 
            this.menuItem53.Index = 5;
            this.menuItem53.Text = "全幅显示";
            this.menuItem53.Click += new System.EventHandler(this.menuItem53_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 6;
            this.menuItem20.Text = "-";
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 7;
            this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem22,
            this.menuItem23,
            this.menuItem24,
            this.menuItem29,
            this.menuItem37});
            this.menuItem21.Text = "投影转换";
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 0;
            this.menuItem22.Text = "摩尔威德";
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 1;
            this.menuItem23.Text = "墨卡托";
            this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 2;
            this.menuItem24.Text = "球面投影(北极)";
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 3;
            this.menuItem29.Text = "球面投影(南极)";
            this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            // 
            // menuItem37
            // 
            this.menuItem37.Index = 4;
            this.menuItem37.Text = "地理参考(WGS84)";
            this.menuItem37.Click += new System.EventHandler(this.menuItem37_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem68,
            this.menuItem62,
            this.menuItem71,
            this.menuItem63,
            this.menuItem64});
            this.menuItem12.Text = "插入(&I)";
            // 
            // menuItem68
            // 
            this.menuItem68.Index = 0;
            this.menuItem68.Text = "图框";
            // 
            // menuItem62
            // 
            this.menuItem62.Index = 1;
            this.menuItem62.Text = "文本";
            // 
            // menuItem71
            // 
            this.menuItem71.Index = 2;
            this.menuItem71.Text = "图例";
            // 
            // menuItem63
            // 
            this.menuItem63.Index = 3;
            this.menuItem63.Text = "比例尺";
            // 
            // menuItem64
            // 
            this.menuItem64.Index = 4;
            this.menuItem64.Text = "指北针";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 4;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem17,
            this.menuItem66,
            this.menuItem16,
            this.menuItem19,
            this.menuItem18});
            this.menuItem13.Text = "处理(&D)";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 0;
            this.menuItem17.Text = "古地磁极";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // menuItem66
            // 
            this.menuItem66.Index = 1;
            this.menuItem66.Text = "校正";
            this.menuItem66.Click += new System.EventHandler(this.menuItem66_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 2;
            this.menuItem16.Text = "欧拉极";
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 3;
            this.menuItem19.Text = "插值";
            this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 4;
            this.menuItem18.Text = "重建";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 5;
            this.menuItem14.Text = "数据库(&D)";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 6;
            this.menuItem4.MdiList = true;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem31,
            this.menuItem5,
            this.menuItem6,
            this.menuItem9,
            this.menuItem30,
            this.menuItem90,
            this.menuItem91,
            this.menuItem92});
            this.menuItem4.Text = "窗口(W)";
            // 
            // menuItem31
            // 
            this.menuItem31.Index = 0;
            this.menuItem31.Text = "排列图标";
            this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "层叠";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "水平平铺";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "垂直平铺";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 4;
            this.menuItem30.Text = "-";
            this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem90
            // 
            this.menuItem90.Index = 5;
            this.menuItem90.Text = "关闭所有子窗口";
            // 
            // menuItem91
            // 
            this.menuItem91.Index = 6;
            this.menuItem91.Text = "-";
            // 
            // menuItem92
            // 
            this.menuItem92.Index = 7;
            this.menuItem92.Text = "窗口列表";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 7;
            this.menuItem15.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem39,
            this.menuItem41});
            this.menuItem15.Text = "帮助(&H)";
            // 
            // menuItem39
            // 
            this.menuItem39.Index = 0;
            this.menuItem39.Text = "帮助主题";
            this.menuItem39.Click += new System.EventHandler(this.menuItem39_Click);
            // 
            // menuItem41
            // 
            this.menuItem41.Index = 1;
            this.menuItem41.Text = "关于";
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 1);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(231, 28);
            this.axToolbarControl1.TabIndex = 8;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(826, 48);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axToolbarControl3
            // 
            this.axToolbarControl3.Location = new System.Drawing.Point(376, 1);
            this.axToolbarControl3.Name = "axToolbarControl3";
            this.axToolbarControl3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl3.OcxState")));
            this.axToolbarControl3.Size = new System.Drawing.Size(128, 28);
            this.axToolbarControl3.TabIndex = 13;
            // 
            // axToolbarControl4
            // 
            this.axToolbarControl4.Location = new System.Drawing.Point(503, 1);
            this.axToolbarControl4.Name = "axToolbarControl4";
            this.axToolbarControl4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl4.OcxState")));
            this.axToolbarControl4.Size = new System.Drawing.Size(413, 28);
            this.axToolbarControl4.TabIndex = 15;
            // 
            // axToolbarControl2
            // 
            this.axToolbarControl2.Location = new System.Drawing.Point(230, 1);
            this.axToolbarControl2.Name = "axToolbarControl2";
            this.axToolbarControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl2.OcxState")));
            this.axToolbarControl2.Size = new System.Drawing.Size(147, 28);
            this.axToolbarControl2.TabIndex = 16;
            // 
            // toolBar1
            // 
            this.toolBar1.AllowDrop = true;
            this.toolBar1.ButtonSize = new System.Drawing.Size(39, 22);
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(1048, 28);
            this.toolBar1.TabIndex = 3;
            // 
            // axToolbarControl5
            // 
            this.axToolbarControl5.Location = new System.Drawing.Point(915, 1);
            this.axToolbarControl5.Name = "axToolbarControl5";
            this.axToolbarControl5.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl5.OcxState")));
            this.axToolbarControl5.Size = new System.Drawing.Size(127, 28);
            this.axToolbarControl5.TabIndex = 18;
            // 
            // ParentForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1048, 571);
            this.Controls.Add(this.axToolbarControl5);
            this.Controls.Add(this.axToolbarControl4);
            this.Controls.Add(this.axToolbarControl3);
            this.Controls.Add(this.axToolbarControl2);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.toolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "ParentForm";
            this.Text = "古大陆再造模拟系统";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.ParentForm_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new 界面());


		}

		private void ParentForm_Load(object sender, System.EventArgs e)
		{
			//Make an MDI parent 
			this.IsMdiContainer = true;

			//Add the commands to the ToolbarControl
			//axToolbarControl1.AddItem("esriControls.ControlsOpenDocCommand",-1,-1,false,-1,esriCommandStyles.esriCommandStyleIconAndText);
			//axToolbarControl1.AddItem("esriControls.ControlsMapZoomInTool",-1,-1,true,-1,esriCommandStyles.esriCommandStyleIconAndText);
			//axToolbarControl1.AddItem("esriControls.ControlsMapZoomOutTool",-1,-1,false,-1,esriCommandStyles.esriCommandStyleIconAndText);
			//axToolbarControl1.AddItem("esriControls.ControlsMapFullExtentCommand",-1,-1,false,-1,esriCommandStyles.esriCommandStyleIconAndText);


            ////this.toolStripStatusLabel1.Text = "就绪";
            ////this.toolStripStatusLabel2.Text = "当前时间：" + DateTime.Now.ToLongTimeString();
            ////this.toolStripStatusLabel3.Text = "地图单位：米";
            ////this.toolStripStatusLabel4.Text = "当前比例尺：1:2000";


		}

		private void ParentForm_MdiChildActivate(object sender, System.EventArgs e)
		{
			ChildForm activeMdiChild = (ChildForm) this.ActiveMdiChild;
			if (activeMdiChild == null) return;
            activeMdiChild.Focus();
			//Set the ToolbarControl's buddy    工具条关联当前活动子窗口

            activeMdiChild.ActiveControl = activeMdiChild.axMapControl1;
            
            axToolbarControl1.SetBuddyControl(activeMdiChild.ActiveControl);
            axToolbarControl2.SetBuddyControl(activeMdiChild.ActiveControl);
            axToolbarControl3.SetBuddyControl(activeMdiChild.ActiveControl); 
            axToolbarControl4.SetBuddyControl(activeMdiChild.ActiveControl);
            
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			//Create a new child form
            //int i=0;
            ChildForm newMDIChild = new ChildForm(this);
            newMDIChild.MdiParent = this;
            mdiform_sum++;

            newMDIChild.Name = "MDIChild" + mdiform_sum.ToString();
            newMDIChild.Text = "地图工程" + mdiform_sum.ToString();
             
			//Show the new child form
			newMDIChild.Show();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			//Close the active child form
			ChildForm activeMdiChild = (ChildForm) this.ActiveMdiChild;
            if (this.MdiChildren.Length!=0)
			activeMdiChild.Close();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			//Close any child forms and exit application
			Form[] childForm = this.MdiChildren ; 
			for(int i=0; i < childForm.Length ; i++) childForm[i].Close();
            Application.Exit();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
		}

            

        private void menuItem30_Click(object sender, EventArgs e)
        {
            //ToolForm newtoolform = new ToolForm();
            //newtoolform.Show();
        }

        private void menuItem31_Click(object sender, EventArgs e)
        {
            ChildForm activeMdiChild = (ChildForm)this.ActiveMdiChild;
           // if (this.MdiChildren.Length != 0)
            //    activeMdiChild.;
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
          
             FrmReconstruct frm = new FrmReconstruct();
            frm.Show();
           
            
            
           
          
        }

        private void menuItem25_Click(object sender, EventArgs e)
        {
            //open
            pToolbarItem = this.axToolbarControl1.GetItem(0);
            pToolbarItem.Command.OnClick();
        }
       
        private void menuItem76_Click(object sender, EventArgs e)
        {
            出图 frm = new 出图();
            frm.Show();
        }              
                
        private void menuItem19_Click(object sender, EventArgs e)
        {
            FrmAnyEulerPole frm = new FrmAnyEulerPole();
            frm.Show();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            VGP frm= new VGP ();
            frm.Show();
        }

        private void menuItem27_Click(object sender, EventArgs e)
        {
            //save
            pToolbarItem = this.axToolbarControl1.GetItem(2);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem32_Click(object sender, EventArgs e)
        {
            //undo
            pToolbarItem = this.axToolbarControl1.GetItem(7);
            pToolbarItem.Command.OnClick();

        }

        private void menuItem33_Click(object sender, EventArgs e)
        {
            //redo
            pToolbarItem = this.axToolbarControl1.GetItem(8);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem35_Click(object sender, EventArgs e)
        {
            //cut
            pToolbarItem = this.axToolbarControl1.GetItem(4);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem36_Click(object sender, EventArgs e)
        {
            //copy
            pToolbarItem = this.axToolbarControl1.GetItem(3);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem38_Click(object sender, EventArgs e)
        {
            //paste
            pToolbarItem = this.axToolbarControl1.GetItem(5);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem40_Click(object sender, EventArgs e)
        {
            //delete
            pToolbarItem = this.axToolbarControl1.GetItem(6);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem49_Click(object sender, EventArgs e)
        {
            //enlarge
            pToolbarItem = this.axToolbarControl2.GetItem(0);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem51_Click(object sender, EventArgs e)
        {
            //reduce
            pToolbarItem = this.axToolbarControl2.GetItem(1);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem53_Click(object sender, EventArgs e)
        {
            //whole
            pToolbarItem = this.axToolbarControl2.GetItem(2);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem28_Click(object sender, EventArgs e)
        {
            //back view
            pToolbarItem = this.axToolbarControl2.GetItem(4);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem54_Click(object sender, EventArgs e)
        {
            //forward view
            pToolbarItem = this.axToolbarControl2.GetItem(5);
            pToolbarItem.Command.OnClick();
        }

        private void menuItem45_Click(object sender, EventArgs e)
        {
            GlobeForm frm = new GlobeForm();
            frm.Show();
        }

        private void menuItem66_Click(object sender, EventArgs e)
        {            
            平移 frm = new 平移();
            frm.Show();
        }
                
        private void menuItem16_Click(object sender, EventArgs e)
        {
            FrmCalEulerPole frm = new FrmCalEulerPole();
            frm.Show();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            数据库查询 frm = new 数据库查询();
            frm.Show();
        }

        private void menuItem22_Click(object sender, EventArgs e)
        {
            Form form_current = Application.OpenForms["ParentForm"];//form_current为主窗口中的当前活动子窗体
            ChildForm activeMdiChild = (ChildForm)form_current.ActiveMdiChild;//activeMdiChild为childform类的当前活动子窗体
                      
            ISpatialReferenceFactory srFactory = new SpatialReferenceEnvironmentClass();
                       
            IProjectedCoordinateSystem pcs = srFactory.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_World_Mollweide);
            activeMdiChild.axMapControl1.SpatialReference = pcs;
            activeMdiChild.axMapControl1.Refresh();
            activeMdiChild.axMapControl2.SpatialReference = pcs;
            activeMdiChild.axMapControl2.Refresh();                    
        }

        private void menuItem23_Click(object sender, EventArgs e)
        {
            Form form_current = Application.OpenForms["ParentForm"];//form_current为主窗口中的当前活动子窗体
            ChildForm activeMdiChild = (ChildForm)form_current.ActiveMdiChild;//activeMdiChild为childform类的当前活动子窗体

            ISpatialReferenceFactory srFactory = new SpatialReferenceEnvironmentClass();

            IProjectedCoordinateSystem pcs = srFactory.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_World_Mercator);
            activeMdiChild.axMapControl1.SpatialReference = pcs;
            activeMdiChild.axMapControl1.Refresh();
            activeMdiChild.axMapControl2.SpatialReference = pcs;
            activeMdiChild.axMapControl2.Refresh();
        }

        private void menuItem24_Click(object sender, EventArgs e)
        {
            Form form_current = Application.OpenForms["ParentForm"];//form_current为主窗口中的当前活动子窗体
            ChildForm activeMdiChild = (ChildForm)form_current.ActiveMdiChild;//activeMdiChild为childform类的当前活动子窗体
            ISpatialReferenceFactory srFactory = new SpatialReferenceEnvironmentClass();
            IProjectedCoordinateSystem pcs = srFactory.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_WGS1984N_PoleStereographic);
            activeMdiChild.axMapControl1.SpatialReference = pcs;
            activeMdiChild.axMapControl1.Refresh();
            activeMdiChild.axMapControl2.SpatialReference = pcs;
            activeMdiChild.axMapControl2.Refresh();
        }

        private void menuItem29_Click(object sender, EventArgs e)
        {
            Form form_current = Application.OpenForms["ParentForm"];//form_current为主窗口中的当前活动子窗体
            ChildForm activeMdiChild = (ChildForm)form_current.ActiveMdiChild;//activeMdiChild为childform类的当前活动子窗体
            ISpatialReferenceFactory srFactory = new SpatialReferenceEnvironmentClass();
            IProjectedCoordinateSystem pcs = srFactory.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_WGS1984S_PoleStereographic);
            activeMdiChild.axMapControl1.SpatialReference = pcs;
            activeMdiChild.axMapControl1.Refresh();
            activeMdiChild.axMapControl2.SpatialReference = pcs;
            activeMdiChild.axMapControl2.Refresh();
        }

        private void menuItem37_Click(object sender, EventArgs e)
        {
            Form form_current = Application.OpenForms["ParentForm"];//form_current为主窗口中的当前活动子窗体
            ChildForm activeMdiChild = (ChildForm)form_current.ActiveMdiChild;//activeMdiChild为childform类的当前活动子窗体
            ISpatialReferenceFactory srFactory = new SpatialReferenceEnvironmentClass();
            IGeographicCoordinateSystem gcs = srFactory.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_WGS1984);
            activeMdiChild.axMapControl1.SpatialReference = gcs;
            activeMdiChild.axMapControl1.Refresh();
            activeMdiChild.axMapControl2.SpatialReference = gcs;
            activeMdiChild.axMapControl2.Refresh();
        }

        private void menuItem39_Click(object sender, EventArgs e)
        {
            string strUrl = Application.StartupPath + "//ypp帮助文档.chm";
            Help.ShowHelp(this, strUrl);

        }

     
	}
}

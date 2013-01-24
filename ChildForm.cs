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
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;


using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.GlobeCore;

//using ESRI.ArcGIS.AxControls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.esriSystem;




namespace MDIApplication
{


    public class ChildForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components;
        private const int WM_ENTERSIZEMOVE = 0x231;
        private StatusStrip statusStrip1; //For resizing
        private const int WM_EXITSIZEMOVE = 0x232;  //For resizing

        IMap pMap;
        IFeature m_pFeature;
        ISpatialReference pSR;
        IDisplayFeedback m_pDisplayFeedback;
        IScreenDisplay m_pScreenDisplay;
        IPoint pPoint;
        //int pyBtn 



        double X_First;   //'保留起点坐标，终点坐标x相等
        double Y_First;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 打开属性表ToolStripMenuItem;
        private ToolStripMenuItem 自动标注ToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
        private TabPage tabPage2;
        private AxTOCControl axTOCControl1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        public ESRI.ArcGIS.Controls.AxMapControl axMapControl2;
        public AxMapControl axMapControl1;
        private ToolStripMenuItem 移除图层ToolStripMenuItem;
        private ToolStripMenuItem 缩放到图层ToolStripMenuItem;
        //public int pyBtn;//平移操作

        public ChildForm(MDIApplication.ParentForm ptfrm)
        {
            InitializeComponent();
            pfrm = ptfrm;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开属性表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动标注ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放到图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axMapControl2 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(774, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开属性表ToolStripMenuItem,
            this.缩放到图层ToolStripMenuItem,
            this.自动标注ToolStripMenuItem,
            this.移除图层ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // 打开属性表ToolStripMenuItem
            // 
            this.打开属性表ToolStripMenuItem.Name = "打开属性表ToolStripMenuItem";
            this.打开属性表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开属性表ToolStripMenuItem.Text = "打开属性表";
            this.打开属性表ToolStripMenuItem.Click += new System.EventHandler(this.打开属性表ToolStripMenuItem_Click);
            // 
            // 自动标注ToolStripMenuItem
            // 
            this.自动标注ToolStripMenuItem.Name = "自动标注ToolStripMenuItem";
            this.自动标注ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.自动标注ToolStripMenuItem.Text = "标注";
            // 
            // 缩放到图层ToolStripMenuItem
            // 
            this.缩放到图层ToolStripMenuItem.Name = "缩放到图层ToolStripMenuItem";
            this.缩放到图层ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.缩放到图层ToolStripMenuItem.Text = "缩放到图层";
            this.缩放到图层ToolStripMenuItem.Click += new System.EventHandler(this.缩放到图层ToolStripMenuItem_Click);
            // 
            // 移除图层ToolStripMenuItem
            // 
            this.移除图层ToolStripMenuItem.Name = "移除图层ToolStripMenuItem";
            this.移除图层ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.移除图层ToolStripMenuItem.Text = "移除图层";
            this.移除图层ToolStripMenuItem.Click += new System.EventHandler(this.移除图层ToolStripMenuItem_Click);
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axPageLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(541, 352);
            this.axPageLayoutControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.axPageLayoutControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "出图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.axTOCControl1.Location = new System.Drawing.Point(2, 1);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(221, 257);
            this.axTOCControl1.TabIndex = 0;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(225, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 377);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axMapControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "工程文件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(541, 352);
            this.axMapControl1.TabIndex = 1;
            this.axMapControl1.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl1_OnExtentUpdated);
            this.axMapControl1.OnViewRefreshed += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnViewRefreshedEventHandler(this.axMapControl1_OnViewRefreshed);
            this.axMapControl1.OnAfterScreenDraw += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnAfterScreenDrawEventHandler(this.axMapControl1_OnAfterScreenDraw);
            // 
            // axMapControl2
            // 
            this.axMapControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.axMapControl2.Location = new System.Drawing.Point(2, 257);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl2.OcxState")));
            this.axMapControl2.Size = new System.Drawing.Size(221, 119);
            this.axMapControl2.TabIndex = 4;
            this.axMapControl2.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl2_OnMouseDown);
            // 
            // ChildForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(774, 401);
            this.Controls.Add(this.axMapControl2);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChildForm";
            this.ShowInTaskbar = false;
            this.Text = "子窗口";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        MDIApplication.ParentForm pfrm;

        private void ChildForm_Load(object sender, System.EventArgs e)
        {
            //Suppress drawing while resizing
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
            axMapControl1.BorderStyle = esriControlsBorderStyle.esriNoBorder;
            //this.reportViewer1.RefreshReport();
            axPageLayoutControl1.Visible = false;



            /////////ypp加入代码：

            this.toolStripStatusLabel1.Text = "就绪";
            this.toolStripStatusLabel2.Text = "当前时间：" + DateTime.Now.ToLongTimeString();
            this.toolStripStatusLabel3.Text = "地图单位：米";
            //this.toolStripStatusLabel4.Text = "当前比例尺：1:2000";

            //comboBox1.Items.Add("QTB");
            //comboBox1.Items.Add("LSA");
            //comboBox1.Items.Add("HIM");
            //listBox1.Items.Add("000" + "Ma");
            //for (int i = 1; i < 28; i++)
            //{

            //    if (i < 10)
            //    {
            //        listBox1.Items.Add("0" + (i * 10) + "Ma");

            //    }
            //    else
            //    {
            //        listBox1.Items.Add((i * 10) + "Ma");
            //    }
            //}

            ////////ypp
        }

        ////////////protected override void OnNotifyMessage(System.Windows.Forms.Message m)
        ////////////{
        ////////////    /*This method of suppressing resize drawing works by examining the windows messages 
        ////////////    sent to the form. When a form starts resizing, windows sends the WM_ENTERSIZEMOVE 
        ////////////    Windows(messge). At this point we suppress drawing to the MapControl and 
        ////////////    PageLayoutControl and draw using a "stretchy bitmap". When windows sends the 
        ////////////    WM_EXITSIZEMOVE the form is released from resizing and we resume with a full 
        ////////////    redraw at the new extent.

        ////////////    Note in DotNet forms we can not simply use the second parameter in a Form_Load 
        ////////////    event to automatically detect when a form is resized as follows:
        ////////////    AxPageLayoutControl1.SuppressResizeDrawing(False, Me.Handle.ToInt32)
        ////////////    This results in a System.NullException when the form closes (after layers have been 
        ////////////    loaded). This is a limitation caused by .Net's particular implementation of its 
        ////////////    windows message pump which conflicts with "windows subclassing" used to watch the
        ////////////    forms window.*/

        ////////////    base.OnNotifyMessage (m);

        ////////////    if (m.Msg == WM_ENTERSIZEMOVE)
        ////////////    {
        ////////////        axMapControl1.SuppressResizeDrawing(true, 0);
        ////////////    }
        ////////////    else if (m.Msg == WM_EXITSIZEMOVE)
        ////////////    {
        ////////////        axMapControl1.SuppressResizeDrawing(false, 0);
        ////////////    }
        ////////////}





        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            //On Error GoTo ErrorHandler


            if (MDIApplication.ParentForm.pyBtn == 1)
            {
                if (this.axMapControl1.ActiveView.FocusMap.SelectionCount >= 1)
                {
                    //////////IGeometry pGeometry ;
                    //////////IPoint pPoint ; 
                    //////////IEnvelope pEnvelope ; 
                    m_pScreenDisplay = this.axMapControl1.ActiveView.ScreenDisplay;
                    //'目前对第一层的要素
                    pMap = this.axMapControl1.ActiveView.FocusMap;
                    pSR = pMap.SpatialReference;
                    // '当前参考系为图层坐标系统WGS84
                    //'Dim name As String
                    //'name = pSR.name
                    //'MsgBox "name is" & name

                    if (this.axMapControl1.ActiveView.FocusMap.LayerCount == 0)
                    {
                        MessageBox.Show("当前工程没有可操作图层");
                        return;
                    }

                    //'得到鼠标点击的起点坐标
                    pPoint = m_pScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y);
                    X_First = pPoint.X;
                    Y_First = pPoint.Y;


                    IEnumFeature pEnumFeat = (IEnumFeature)this.axMapControl1.ActiveView.FocusMap.FeatureSelection;
                    pEnumFeat.Reset();
                    if (pEnumFeat == null)
                    {
                        return;
                    }
                    m_pFeature = pEnumFeat.Next();
                    IPolygon polygon = (IPolygon)m_pFeature.Shape;
                    //'Feature类型为Polygon
                    m_pDisplayFeedback = new MovePolygonFeedback();
                    m_pDisplayFeedback.Display = m_pScreenDisplay;

                    IMovePolygonFeedback pMovePolygonF = (IMovePolygonFeedback)m_pDisplayFeedback;

                    //pMovePolygonF.Start( m_pFeature.Shape, pPoint);

                    pMovePolygonF.Start(polygon, pPoint);

                    this.axMapControl1.ActiveView.Refresh();

                    //    '设置鼠标外观，鼠标形状作为判断标志

                    //    'Dim m_pMouseCursor As esriFramework.MouseCursor
                    //    'Set m_pMouseCursor = New MouseCursor
                    //    'm_pMouseCursor.SetCursor 5
                    //'ErrorHandler:
                    //    'MsgBox Err.Description
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }


        private esriTOCControlItem m_item = esriTOCControlItem.esriTOCControlItemNone;
        private ILayer m_pLayer = null;
        private IBasicMap m_map = null;
        private object m_other = null;
        private object m_index = null;

        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {              
            //确定选择的对象（map or layer）  //hittest右键快捷菜单位置x y等参数
            axTOCControl1.HitTest(e.x, e.y, ref m_item, ref m_map, ref m_pLayer, ref m_other, ref m_index); 

            if (e.button == 2) //右键响应
            {  
                //弹出快捷菜单
                if (m_item == esriTOCControlItem.esriTOCControlItemMap)
                {
                    axTOCControl1.SelectItem(m_map, null);
                }
                else if (m_item == esriTOCControlItem.esriTOCControlItemLayer && !(m_pLayer is IGroupLayer))
                {
                    axTOCControl1.SelectItem(m_pLayer, null);                  
                    contextMenuStrip1.Show(axTOCControl1,e.x + 5, e.y + 10);                  
                }
            }


            
        }        
       

        private void button6_Click(object sender, System.EventArgs e)
        {
            FrmReconstruct frm1 = new FrmReconstruct();
            frm1.Show();
        }
        
        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            try
            {
                //'状态栏显示当前坐标，wgs84，经纬度

                //'StatusBar1.Panels(1).Text = Format(mapX, ".0") & "        " & Format(mapY, ".0") & " " & "Degree"   'sMapUnits
                //MDIApplication.ParentForm pfrm = new ParentForm();


                this.toolStripStatusLabel4.Text = "X坐标：" + e.mapX.ToString() + "," + "Y坐标：" + e.mapY.ToString();

                //ypp需要改
                //StatusBar1.Panels(3) = "MapX：" & mapX & "     " & "MapY：" & mapY;
                //this.axMapControl1.MousePointer = esriPointerDefault;
                this.axMapControl1.MousePointer = esriControlsMousePointer.esriPointerDefault;
                if (MDIApplication.ParentForm.pyBtn == 1)
                {
                    if (m_pDisplayFeedback != null)
                    {

                        ////////IPoint pPoint;
                        //' 得到鼠标点击位置在地图上的坐标
                        //Set pPoint = m_pScreenDisplay.displayTransformation.ToMapPoint(X, Y)   

                        //'pPoint.x = X_First
                        pPoint.Y = Y_First;
                        m_pDisplayFeedback.MoveTo(pPoint);
                    }
                    return;
                }

                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        private void axMapControl1_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            IGeometry pGeometry;
            try
            {
                if (MDIApplication.ParentForm.pyBtn == 1)
                {
                    MDIApplication.ParentForm.pyBtn = 0;
                    // '检查是否存在一个元素
                    if (m_pFeature != null)
                    {
                        //'针对polygon类型

                        IMovePolygonFeedback pMovePolygonF = (IMovePolygonFeedback)m_pDisplayFeedback;
                        pGeometry = pMovePolygonF.Stop();
                        // '更新元素
                        m_pFeature.Shape = pGeometry;

                        m_pFeature.Store();
                        m_pDisplayFeedback = null;
                        this.axMapControl1.ActiveView.Refresh();
                        //'将鼠标外观还原
                        //'Set m_pMouseCursor = New MouseCursor
                        //'m_pMouseCursor.SetCursor 0
                        this.axMapControl1.ActiveView.FocusMap.FeatureSelection.Cut();
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string proj;
        //    proj = comboBox2.Text;

        //    ISpatialReferenceFactory srFactory = new SpatialReferenceEnvironmentClass();

        //    if (proj == "Mollweide")
        //    {
        //        IProjectedCoordinateSystem pcs = srFactory.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_World_Mollweide);
        //        axMapControl1.SpatialReference = pcs;
        //        axMapControl1.Refresh();
        //    }
        //    if (proj == "Mercator")
        //    {
        //        IProjectedCoordinateSystem pcs = srFactory.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_World_Mercator);
        //        axMapControl1.SpatialReference = pcs;
        //        axMapControl1.Refresh();
        //    }
        //    if (proj == "North_Pole_Stereographic")
        //    {
        //        IProjectedCoordinateSystem pcs = srFactory.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_WGS1984N_PoleStereographic);
        //        axMapControl1.SpatialReference = pcs;
        //        axMapControl1.Refresh();
        //    }
        //    if (proj == "South_Pole_Stereographic")
        //    {
        //        IProjectedCoordinateSystem pcs = srFactory.CreateProjectedCoordinateSystem((int)esriSRProjCSType.esriSRProjCS_WGS1984S_PoleStereographic);
        //        axMapControl1.SpatialReference = pcs;
        //        axMapControl1.Refresh();
        //    }
        //    if (proj == "WGS 1984")
        //    {
        //        IGeographicCoordinateSystem gcs = srFactory.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_WGS1984);
        //        axMapControl1.SpatialReference = gcs;
        //        axMapControl1.Refresh();
        //    }

        //}

        private void button4_Click(object sender, EventArgs e)
        {
            平移 frm = new 平移();   //this
            frm.Show();

        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabcontrol选择标签改变对应事件，mapcontrol和pagelayoutcontrol转换
            if (tabControl1.SelectedIndex == 1)
            {
                //mapcontrol和pagelayout交互            
                IObjectCopy pOCopy = new ObjectCopyClass();
                System.Object pToCopyMap = axMapControl1.Map;
                System.Object pCopiedMap = pOCopy.Copy(pToCopyMap);
                System.Object pToOverMap = axPageLayoutControl1.ActiveView.FocusMap;
                pOCopy.Overwrite(pCopiedMap, ref pToOverMap);
                axPageLayoutControl1.ActiveView.Refresh();

                axPageLayoutControl1.Show();
                axMapControl1.Visible = false;

                pfrm.axToolbarControl5.SetBuddyControl(this.axPageLayoutControl1);

            }

            if (tabControl1.SelectedIndex == 0)
            {
                axMapControl1.Visible = true;
                axPageLayoutControl1.Visible = false;
            }
        }

        private void axMapControl1_OnAfterScreenDraw(object sender, IMapControlEvents2_OnAfterScreenDrawEvent e)
        {
            IObjectCopy pOCopy = new ObjectCopyClass();
            System.Object pToCopyMap = axMapControl1.Map;
            System.Object pCopiedMap = pOCopy.Copy(pToCopyMap);
            System.Object pToOverMap = axPageLayoutControl1.ActiveView.FocusMap;

            pOCopy.Overwrite(pCopiedMap, ref pToOverMap);
            axPageLayoutControl1.ActiveView.Refresh();
        }

        private void axMapControl2_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            ////鹰眼操作主控件
            IRubberBand pBand = new RubberEnvelopeClass();
            IGeometry pGeometry = pBand.TrackNew(axMapControl2.ActiveView.ScreenDisplay, null);
            if (pGeometry.IsEmpty)
            {
                IPoint pPt = new PointClass();
                pPt.PutCoords(e.mapX, e.mapY);
                //改变主控件的视图范围
                axMapControl1.CenterAt(pPt);
            }
            else
            {
                axMapControl1.Extent = pGeometry.Envelope;
                axMapControl1.ActiveView.Refresh();
            }
        }

        private void setMap2(IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            //动态生产鹰眼红框
            // 得到新范围
            IEnvelope pEnv = (IEnvelope)e.newEnvelope;   //传递参数，e指mapcontrol1
            IGraphicsContainer pGra = axMapControl2.Map as IGraphicsContainer;
            IActiveView pAv = pGra as IActiveView;
            //在绘制前，清除axMapControl2中的任何图形元素
            pGra.DeleteAllElements();
            IRectangleElement pRectangleEle = new RectangleElementClass();
            IElement pEle = pRectangleEle as IElement;
            pEle.Geometry = pEnv;
            //设置鹰眼图中的红线框
            IRgbColor pColor = new RgbColorClass();
            pColor.Red = 255;
            pColor.Green = 0;
            pColor.Blue = 0;
            pColor.Transparency = 255;
            //产生一个线符号对象
            ILineSymbol pOutline = new SimpleLineSymbolClass();
            pOutline.Width = 2;
            pOutline.Color = pColor;
            //设置颜色属性
            pColor = new RgbColorClass();
            pColor.Red = 255;
            pColor.Green = 0;
            pColor.Blue = 0;
            pColor.Transparency = 0;
            //设置填充符号的属性
            IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            pFillSymbol.Color = pColor;
            pFillSymbol.Outline = pOutline;
            IFillShapeElement pFillShapeEle = pEle as IFillShapeElement;
            pFillShapeEle.Symbol = pFillSymbol;
            pGra.AddElement((IElement)pFillShapeEle, 0);
            pAv.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }

        private void axMapControl1_OnExtentUpdated(object sender, IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            setMap2(e);
        }

       

        private void axMapControl1_OnViewRefreshed(object sender, IMapControlEvents2_OnViewRefreshedEvent e)
        {
            //主控件图层添加到鹰眼 
            axMapControl2.Map.ClearLayers();
            IMap pMap = axMapControl1.Map;
            for (int i = 0; i <= pMap.LayerCount - 1; i++)
            {
                axMapControl2.Map.AddLayer(pMap.get_Layer(i));               
            }
            axMapControl2.Refresh();
        }

        private void 打开属性表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFeatureLayer pFeatLayer = m_pLayer as IFeatureLayer;
            FrmAttribute frmAtr = new FrmAttribute();
            frmAtr.Show();
            
            IFeatureClass pFeatCls = pFeatLayer.FeatureClass;
            IFields pFields = pFeatCls.Fields;
            IField pField;
            int nCol = pFields.FieldCount;
            frmAtr.dgrid.ColumnCount = nCol;
            for (int n = 0; n <= nCol - 1; n++)            {
               frmAtr.dgrid.Columns[n].HeaderText = pFields.get_Field(n).Name;
            }
            IQueryFilter pQueryFilter = new QueryFilterClass();
            pQueryFilter.WhereClause = "";
            IGeometryDef pGeometryDef;
            IFeatureCursor pFeatCur = pFeatCls.Search(pQueryFilter, true);
            IFeature pFeat = pFeatCur.NextFeature();
            if (pFeat != null)
            {
                int nRow = -1;
                while (pFeat != null)
                {
                    nRow = nRow + 1;
                    frmAtr.dgrid.RowCount = nRow + 1;
                    frmAtr.dgrid.Rows.Add();

                    for (int j = 0; j <= nCol - 1; j++)
                    {
                        if (pFeat.Fields.get_Field(j).Type == esriFieldType.esriFieldTypeGeometry)
                        {
                            pField = pFeat.Fields.get_Field(j);
                            pGeometryDef = pField.GeometryDef;
                            //dgrid.Rows.Item(nRow).Cells(j).Value = pGeometryDef.GeometryType;
                            frmAtr.dgrid.Rows[nRow].Cells[j].Value = pGeometryDef.GeometryType;
                        }
                        else
                        {
                            //dgrid.Rows.Item(nRow).Cells(j).Value = pFeat.get_Value (j);
                            frmAtr.dgrid.Rows[nRow].Cells[j].Value = pFeat.get_Value(j);
                        }
                    }
                    pFeat = pFeatCur.NextFeature();
                }
            }            
        }

        

        private void 可视范围ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 缩放到图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFeatureLayer pFeatLayer = m_pLayer as IFeatureLayer;
            IEnvelope pEnv = new EnvelopeClass();
            pEnv = pFeatLayer.AreaOfInterest;
            axMapControl1.ActiveView.Extent = pEnv;
            axMapControl1.Refresh();
        }

        private void 移除图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            IFeatureLayer pFLayer = m_pLayer as IFeatureLayer;
            axMapControl1.Map.DeleteLayer(pFLayer);

            axMapControl1.Refresh();
            //axMapControl2.Refresh();

        }

        


       

       

       
    }
}

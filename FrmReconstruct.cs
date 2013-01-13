using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.GlobeCore;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;


namespace MDIApplication
{
    public partial class FrmReconstruct : Form
    {
        public FrmReconstruct()
        {
            InitializeComponent();
            
        }
        String name;

        CCEuler.EulerPole pole;
        Double Ang;
        Double t;
        String filename = "";
        int compmode = 0;
        private Boolean DeleteDatasetIfExist(IWorkspace pWS, string sDatasetName)
        {
            IEnumDataset pEnumDataset = pWS.get_Datasets(esriDatasetType.esriDTAny);
            IDataset pDS = pEnumDataset.Next();
            while (pDS != null)
            {
                if (pDS.Name.ToLower() == sDatasetName.ToLower())
                {
                    if (pDS.CanDelete())
                    {
                        pDS.Delete();
                        return true;
                    }
                }
                pDS = pEnumDataset.Next();
            }
            return false;
        }

        private void 重建_Load(object sender, EventArgs e)
        {
           
            if (SystemEnvironment.BoolFeatName == true)
            {
               
            }                     
        }     
      
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected == true)
                {
                    listView1.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                object Missing = Type.Missing;

                IPoint pPointNew = new PointClass();
                int count = listView1.Items.Count;
                if (count == 0)
                {
                    MessageBox.Show("There is no Euler Pole!");
                    return;
                }
                string ContiName = listView1.Items[0].Text;

                CCEuler.EulerPole rotpol;
                CCEuler.EulerPole p;

                double eulerangle;
                double[,] m = new double[3, 3];             

                double Ptime;
               
                Form form_current = Application.OpenForms["ParentForm"];

                ChildForm activeMdiChild = (ChildForm)form_current.ActiveMdiChild;
                IMap pMap = activeMdiChild.axMapControl1.ActiveView.FocusMap;
                IEnvelope pEnv = activeMdiChild.axMapControl1.ActiveView.Extent;
                ISpatialReference pSR = pMap.SpatialReference;
                                
                int lPart;
                int lVertex;
               
                double firstx = 0;
                double firsty = 0;

                if (activeMdiChild.axMapControl1.ActiveView.FocusMap.SelectionCount < 0)
                {
                    MessageBox.Show("selectable is not correct!");
                    return;
                }

                for (int i = 0; i < count; i++)
                {
                    IEnumFeature pEnumFeat = (IEnumFeature)activeMdiChild.axMapControl1.ActiveView.FocusMap.FeatureSelection;
                    pEnumFeat.Reset();
                    IFeature pFeat = pEnumFeat.Next();

                    rotpol.Lattd = Convert.ToDouble(listView1.Items[i].SubItems[2].Text);
                    rotpol.Longttd = Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                    eulerangle = Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
                    Ptime = Convert.ToDouble(listView1.Items[i].SubItems[1].Text);
                  
                    CCEuler.calc_pole2matrix(out m, rotpol, eulerangle);
                  
                    saveFileDialog1.ShowDialog();
                    string fullpath = saveFileDialog1.FileName;
                    string strName = System.IO.Path.GetFileNameWithoutExtension(fullpath);
                    string folder = System.IO.Path.GetDirectoryName(fullpath);
                    
                    IFeatureClass pFeatClass = null;

                    if (pFeat.Shape.GeometryType == esriGeometryType.esriGeometryPolygon)
                    {
                        CCCreatePolygonFile CrteatePolygonFile = new CCCreatePolygonFile();
                        pFeatClass = CrteatePolygonFile.CreatePolygonFile(folder, strName, pEnv, pSR);

                        while (pFeat != null)  
                        {
                            IFields pFlds = pFeat.Table.Fields;
                            long lIndex = pFlds.FindField("Shape");
                            IField pFld = pFlds.get_Field(Convert.ToInt32(lIndex));
                            IPoint pPoint = new PointClass();

                            IPointCollection pPointCollection = (IPointCollection)pFeat.get_Value(Convert.ToInt32(lIndex));
                            IEnumVertex pEnum = pPointCollection.EnumVertices;

                            pEnum.Reset();
                            IPointCollection pNewPointCol = new PolygonClass();                           
                            pEnum.Next(out pPoint, out  lPart, out lVertex);
                            int first = 0;


                            while (pPoint != null)
                            {
                                p.Longttd = pPoint.X;
                                p.Lattd = pPoint.Y;
                               
                                double X, Y, z;
                                double X1, Y1, z1;
                               
                                CCEuler.sphere2kart(out X, out Y, out z, p);
                                X1 = m[0, 0] * X + m[0, 1] * Y + m[0, 2] * z;
                                Y1 = m[1, 0] * X + m[1, 1] * Y + m[1, 2] * z;
                                z1 = m[2, 0] * X + m[2, 1] * Y + m[2, 2] * z;
                                CCEuler.kart2sphere(out p, X1, Y1, z1);

                                pPointNew.PutCoords(p.Longttd, p.Lattd);

                                if (first == 0)
                                {
                                    firstx = p.Longttd;
                                    firsty = p.Lattd;
                                }
                              
                                pNewPointCol.AddPoint(pPointNew, ref Missing, ref Missing);
                              
                                pEnum.Next(out pPoint, out  lPart, out lVertex);
                                first = 1;
                            }
                        
                            pPointNew.PutCoords(firstx, firsty);

                            pNewPointCol.AddPoint(pPointNew, ref Missing, ref Missing);
                           
                            IFeature pNewfeature = pFeatClass.CreateFeature();
                            pNewfeature.Shape = (IGeometry)pNewPointCol;
                            pNewfeature.Store();

                            pFeat = pEnumFeat.Next();
                        }
                        IFeatureLayer pFLayer = new FeatureLayerClass();
                        pFLayer.FeatureClass = pFeatClass;
                        pFLayer.Name = pFeatClass.AliasName;
                        pMap.AddLayer(pFLayer);

                        activeMdiChild.axMapControl1.ActiveView.Refresh();
                        System.Threading.Thread.Sleep(800);
                        
                        break;
                    }

                    if (pFeat.Shape.GeometryType == esriGeometryType.esriGeometryPolyline)
                    {
                        CCCreatePolygonFile CreatePolygonFile = new CCCreatePolygonFile();
                        pFeatClass = CreatePolygonFile.CreatePolylineFile(folder, strName, pEnv, pSR);

                        while (pFeat != null) 
                        {
                            IFields pFlds = pFeat.Table.Fields;
                            long lIndex = pFlds.FindField("Shape");
                            IField pFld = pFlds.get_Field(Convert.ToInt32(lIndex));
                            IPoint pPoint = new PointClass();

                            IPointCollection pPointCollection = (IPointCollection)pFeat.get_Value(Convert.ToInt32(lIndex));
                            IEnumVertex pEnum = pPointCollection.EnumVertices;

                            pEnum.Reset();
                            
                            IPointCollection pNewPointCol = new PolylineClass();
                            pEnum.Next(out pPoint, out  lPart, out lVertex);

                            int first = 0;

                            while (pPoint != null)
                            {
                                p.Longttd = pPoint.X;  
                                p.Lattd = pPoint.Y;
                                
                                double X, Y, z;
                                double X1, Y1, z1;
                              
                                CCEuler.sphere2kart(out X, out Y, out z, p);
                                X1 = m[0, 0] * X + m[0, 1] * Y + m[0, 2] * z;
                                Y1 = m[1, 0] * X + m[1, 1] * Y + m[1, 2] * z;
                                z1 = m[2, 0] * X + m[2, 1] * Y + m[2, 2] * z;
                                CCEuler.kart2sphere(out p, X1, Y1, z1);

                                pPointNew.PutCoords(p.Longttd, p.Lattd);

                                if (first == 0)
                                {
                                    firstx = p.Longttd;
                                    firsty = p.Lattd;
                                }
                           
                                pNewPointCol.AddPoint(pPointNew, ref Missing, ref Missing);
                           
                                pEnum.Next(out pPoint, out  lPart, out lVertex);
                                first = 1;
                            }
                      
                            pNewPointCol.AddPoint(pPointNew, ref Missing, ref Missing);
                        
                            IFeature pNewfeature = pFeatClass.CreateFeature();
                            pNewfeature.Shape = (IGeometry)pNewPointCol;
                            pNewfeature.Store();

                            pFeat = pEnumFeat.Next();
                        }

                        IFeatureLayer pFLayer = new FeatureLayerClass();
                        pFLayer.FeatureClass = pFeatClass;
                        pFLayer.Name = pFeatClass.AliasName;
                        pMap.AddLayer(pFLayer);

                        activeMdiChild.axMapControl1.ActiveView.Refresh();
                        System.Threading.Thread.Sleep(800);

                        break;
                    }

                    if (pFeat.Shape.GeometryType == esriGeometryType.esriGeometryPoint)
                    {

                        CCCreatePolygonFile CreatePolygonFile = new CCCreatePolygonFile();
                        pFeatClass = CreatePolygonFile.CreatePointFile(folder, strName, pEnv, pSR);

                        while (pFeat != null) 
                        {
                            IFields pFlds = pFeat.Table.Fields;
                            long lIndex = pFlds.FindField("Shape");
                            IField pFld = pFlds.get_Field(Convert.ToInt32(lIndex));                         
                            IPoint pPoint = (IPoint)pFeat.get_Value(Convert.ToInt32(lIndex));

                            while (pPoint != null)
                            {
                                p.Longttd = pPoint.X;   
                                p.Lattd = pPoint.Y;
                              
                                pPointNew.PutCoords(p.Longttd, p.Lattd);
                                break;
                            }
                           
                            IFeature pNewfeature = pFeatClass.CreateFeature();
                            pNewfeature.Shape = (IGeometry)pPointNew;
                      
                            pNewfeature.Store();
                            pFeat = pEnumFeat.Next();
                        }

                        IFeatureLayer pFLayer = new FeatureLayerClass();
                        pFLayer.FeatureClass = pFeatClass;
                        pFLayer.Name = pFeatClass.AliasName;
                        pMap.AddLayer(pFLayer);

                        activeMdiChild.axMapControl1.ActiveView.Refresh();
                        System.Threading.Thread.Sleep(800);

                        break;
                    }
                }
               
                MessageBox.Show("OK!");
                FrmReconstruct.ActiveForm.Close();
            }
            catch
            {
                MessageBox.Show("Choose the plate to reconstruct");
            }            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            switch (compmode)
            {
                case 0:
                    ListViewItem itmx = new ListViewItem();
                    listView1.Items.Add(itmx);

                    if ( FPoleLat.Text != "" && FPoleLong.Text != "" && FAngle.Text  != "")
                    {
                        itmx.Text = NameComboBox.Text;
                        itmx.SubItems.Add(comboBox2.Text);
                        itmx.SubItems.Add(FPoleLat.Text);
                        itmx.SubItems.Add(FPoleLong.Text);
                        itmx.SubItems.Add(FAngle.Text);
                    }
                    else
                    {
                        MessageBox.Show("Import Euler Pole");
                        return;
                    }                   

                    break;
                case 1:
                    try
                    {
                        if (openFileDialog1.FileName == "")
                        {
                            MessageBox.Show("Filename is null");
                            return;
                        }                       

                        filename = openFileDialog1.FileName;
                        StreamReader sr = File.OpenText(filename);
                        string strLine;

                        while ((strLine = sr.ReadLine()) != null)
                        {
                            string[] split = null;
                            split = strLine.Split('\t');
                            name = split[0];
                            t = Convert.ToDouble(split[1]);
                            pole.Lattd = Convert.ToDouble(split[2]);
                            pole.Longttd = Convert.ToDouble(split[3]);
                            Ang = Convert.ToDouble(split[4]);                                                   

                            ListViewItem item1 = new ListViewItem("item1", 0);
                            item1.Checked = true;
                            item1.Text = name;
                            item1.SubItems.Add(t.ToString());
                            item1.SubItems.Add(pole.Lattd.ToString());
                            item1.SubItems.Add(pole.Longttd.ToString());
                            item1.SubItems.Add(Ang.ToString());
                            listView1.Items.AddRange(new ListViewItem[] { item1 });
                        }
                    }
                    catch
                    {
                        return;
                    }
                    break;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {                       
                try
                {                    
                    openFileDialog1.ShowDialog();                   
                    txtWay.Text = openFileDialog1.FileName;                   
                }
              catch
                {                   
                    return;
                }
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            compmode = 0;
            listView1.Items.Clear();
            txtWay.Enabled = false;
            button3.Enabled = false;
            FPoleLat.Enabled = true;
            FPoleLong.Enabled = true;
            FAngle.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            compmode = 1;
            listView1.Items.Clear();
            txtWay.Enabled = true;
            button3.Enabled = true;
            FPoleLat.Enabled = false;
            FPoleLong.Enabled = false;
            FAngle.Enabled = false;

        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
              {
                 if (listView1.Items[i].Selected == false)
                     continue;
                          
                     for (int j = 0; j <= listView1.Items[i].SubItems.Count - 1; j++)
                          s = s + listView1.Items[i].SubItems[j].Text + "\t";
                          s = s + "\r";
                          Clipboard.SetDataObject(s);
                        }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected == false)
                    continue;
              
                listView1.Items[i].BeginEdit();
            }
        }

        private void 插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected == false)
                    continue;
                listView1.Items[i].Remove();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReconstruct.ActiveForm.Close();
        }

        private void FPoleLat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double aa = Convert.ToDouble(FPoleLat.Text);
            }
            catch
            {
                FPoleLat.Text = "";
            }   
            
        }

        private void FPoleLong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double aa = Convert.ToDouble(FPoleLong.Text);
            }
            catch
            {
                FPoleLong.Text = "";
            }   
        }

        private void FAngle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double aa = Convert.ToDouble(FAngle.Text);
            }
            catch
            {
                FAngle.Text = "";
            }  
        }

        private void NameComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int aa = Convert.ToInt32(NameComboBox.Text);
                NameComboBox.Text = "";
            }
            catch { }

            try
            {
                double bb = Convert.ToDouble(NameComboBox.Text);
                NameComboBox.Text = "";
            }
            catch { }  
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double aa = Convert.ToDouble(comboBox2.Text);
            }
            catch
            {
                comboBox2.Text = "";
            }    
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

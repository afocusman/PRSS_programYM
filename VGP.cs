using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace MDIApplication
{
    public partial class VGP : Form
    {
        public VGP()
        {
            InitializeComponent();
        }

        CCEuler.EulerPole vgp;
        CCEuler.EulerPole p;
        double Angle;
        double time;        
        bool polarity;
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (VGPLat.Text == "")
                    MessageBox.Show("VGP Lat. is null");
                else
                    vgp.Lattd = Convert.ToDouble(VGPLat.Text);
                if (VGPLong.Text == "")
                    MessageBox.Show("VGP Lon. is null");
                else
                    vgp.Longttd = Convert.ToDouble(VGPLong.Text);
                if (NorthP.Checked == true)    
                    polarity = true;
                if (SouthP.Checked == true)     
                    polarity = false;

                CCEuler.calc_VGP2pole(vgp, out p, out Angle, polarity);
                IPoint pPointNew = new PointClass();

                CCEuler.EulerPole rotpol;
                double eulerangle, Ptime;
                double[,] m = new double[3, 3];
                IMap pMap = null;
                IFeatureClass pFeatclass;
                IEnvelope pEnv;
                ISpatialReference pSR;

                Form form_current = Application.OpenForms["ParentForm"];

                ChildForm activeMdiChild = (ChildForm)form_current.ActiveMdiChild;

                if (activeMdiChild != null)
                {
                    pMap = activeMdiChild.axMapControl1.ActiveView.FocusMap;
                    if (pMap.SelectionCount < 1)
                    {
                        MessageBox.Show("No selection");                       
                    }
                }
                else
                {
                    return;
                }
                IFeature pFeat;
                IFields pFlds;
                IField pFld;
                int lIndex;
                IPoint pPoint;
                int lPart, lVertex;

                int first;
                Double firstx = 0, firsty = 0;
                IPointCollection pPointCollection;
                IEnumVertex pEnum;
                IEnumFeature pEnumFeat;
                object Missing = Type.Missing;

                pEnumFeat = (IEnumFeature)activeMdiChild.axMapControl1.ActiveView.FocusMap.FeatureSelection;
                pEnumFeat.Reset();
            
                IFeatureLayer pFLayer;

                rotpol.Lattd = p.Lattd;
                rotpol.Longttd = p.Longttd;
                eulerangle = Angle;
                
                Ptime = time;

                CCEuler.calc_pole2matrix(out m, rotpol, eulerangle);
               
                saveFileDialog1.ShowDialog();
                string fullpath = saveFileDialog1.FileName;
                string folder = System.IO.Path.GetDirectoryName(fullpath);
                string strName = System.IO.Path.GetFileNameWithoutExtension(fullpath);

                pEnv = activeMdiChild.axMapControl1.ActiveView.Extent;
                pSR = pMap.SpatialReference;
                CCCreatePolygonFile CreatePolygonFile = new CCCreatePolygonFile();
                pFeatclass = CreatePolygonFile.CreatePolygonFile(folder, strName, pEnv, pSR);

                pFeat = pEnumFeat.Next();

                while (pFeat != null)
                {
                    pFlds = pFeat.Table.Fields;
                    lIndex = pFlds.FindField("Shape");
                    pFld = pFlds.get_Field(lIndex);
                    pPoint = new PointClass();

                    pPointCollection = (IPointCollection)pFeat.get_Value(lIndex);
                    pEnum = pPointCollection.EnumVertices;

                    pEnum.Reset();
                    IPointCollection pNewPointCol;
                    pNewPointCol = new PolygonClass();
                    pEnum.Next(out pPoint, out lPart, out lVertex);
                    first = 0;
                    while (pPoint != null)
                    {
                       
                        p.Lattd = pPoint.Y;
                        p.Longttd = pPoint.X;
                      
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
                        pEnum.Next(out pPoint, out lPart, out lVertex);
                        first = 1;
                    }
                   
                    pPointNew.PutCoords(firstx, firsty);
                    pNewPointCol.AddPoint(pPointNew, ref Missing, ref Missing);                   
                    IFeature pNewfeature = pFeatclass.CreateFeature();                   
                    pNewfeature.Shape = (IGeometry)pNewPointCol;
                    pNewfeature.Store();
                    pFeat = pEnumFeat.Next();
                }

                pFLayer = new FeatureLayerClass();
                pFLayer.FeatureClass = pFeatclass;
                pFLayer.Name = pFeatclass.AliasName;
                pMap.AddLayer(pFLayer);

                activeMdiChild.axMapControl1.ActiveView.Refresh();
                MessageBox.Show("OK");
            }
            catch
            {
                MessageBox.Show("Choose the plate");
            }
        }      

        private void VGPLat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double aa = Convert.ToDouble(VGPLat.Text);
            }
            catch
            {
                VGPLat.Text = "";
            }    
        }

        private void VGPLong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double aa = Convert.ToDouble(VGPLong.Text);
            }
            catch
            {
                VGPLong.Text = "";
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VGP.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }      
        
    }
}

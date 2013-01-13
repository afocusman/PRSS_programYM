using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.GlobeCore;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;

namespace MDIApplication
{
    public class CCCreatePolygonFile
    {
        public IFeatureClass CreatePolygonFile(String strFolder, String filename, IEnvelope pEnvBorder, ISpatialReference pSR)
        {
            // Open the folder to contain the shapefile as a workspace
            IWorkspaceFactory pWF = new ESRI.ArcGIS.DataSourcesFile.ShapefileWorkspaceFactoryClass();
            IFeatureWorkspace pfws = (IFeatureWorkspace)pWF.OpenFromFile(strFolder, 0);

            //Set up a simple fields collection
            IField pField = new FieldClass();
            IFieldEdit pFieldEdit = (IFieldEdit)pField;
            IFields pFields = new FieldsClass();
            IFieldsEdit pFieldsEdit = (IFieldsEdit)pFields;

            // Make the shape field
            //it will need a geometry definition, with a spatial reference

            pFieldEdit.Name_2 = "Shape";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;

            IGeometryDef pGeomDef = new GeometryDef();
            IGeometryDefEdit pGeomDefEdit = (IGeometryDefEdit)pGeomDef;

            pGeomDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;
            pGeomDefEdit.SpatialReference_2 = pSR;

            pFieldEdit.GeometryDef_2 = pGeomDef;
            pFieldsEdit.AddField(pField);

            // Add ID field
            IField pFieldOID = new Field();
            pFieldEdit = (IFieldEdit)pFieldOID;
            pFieldEdit.Name_2 = "OBJECTID";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeOID;
            pFieldEdit.IsNullable_2 = false;

            pFieldsEdit.AddField(pFieldOID);

            //EulerPoleReFrmgwn eulerfrm=new EulerPoleReFrmgwn();

            if (File.Exists(strFolder + filename + ".shp") == true)
            {
                DialogResult result = MessageBox.Show("There is a shapefile have the same name in this foler, do you want to overwrite it?", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    File.Delete(strFolder + filename);
                  
                }
                else
                {
                    return null;                   
                }
            }

            IFeatureClass pFeatclass = pfws.CreateFeatureClass(filename, pFields, null, null, esriFeatureType.esriFTSimple, "Shape", "");
            return pFeatclass;
        }

        public IFeatureClass CreatePolylineFile(String strFolder, String filename, IEnvelope pEnvBorder, ISpatialReference pSR)
        {
            // Open the folder to contain the shapefile as a workspace
            IWorkspaceFactory pWF = new ESRI.ArcGIS.DataSourcesFile.ShapefileWorkspaceFactoryClass();
            IFeatureWorkspace pfws = (IFeatureWorkspace)pWF.OpenFromFile(strFolder, 0);

            //Set up a simple fields collection
            IField pField = new FieldClass();
            IFieldEdit pFieldEdit = (IFieldEdit)pField;
            IFields pFields = new FieldsClass();
            IFieldsEdit pFieldsEdit = (IFieldsEdit)pFields;

            // Make the shape field
            //it will need a geometry definition, with a spatial reference
            pFieldEdit.Name_2 = "Shape";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;

            IGeometryDef pGeomDef = new GeometryDef();
            IGeometryDefEdit pGeomDefEdit = (IGeometryDefEdit)pGeomDef;

            pGeomDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolyline;
            pGeomDefEdit.SpatialReference_2 = pSR;

            pFieldEdit.GeometryDef_2 = pGeomDef;
            pFieldsEdit.AddField(pField);

            // Add ID field
            IField pFieldOID = new Field();
            pFieldEdit = (IFieldEdit)pFieldOID;
            pFieldEdit.Name_2 = "OBJECTID";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeOID;
            pFieldEdit.IsNullable_2 = false;

            pFieldsEdit.AddField(pFieldOID);

            //EulerPoleReFrmgwn eulerfrm=new EulerPoleReFrmgwn();

            if (File.Exists(strFolder + filename + ".shp") == true)
            {
                DialogResult result = MessageBox.Show("There is a shapefile have the same name in this foler, do you want to overwrite it?", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    File.Delete(strFolder + filename);
                
                }
                else
                {
                    return null;                   
                }
            }

            IFeatureClass pFeatclass = pfws.CreateFeatureClass(filename, pFields, null, null, esriFeatureType.esriFTSimple, "Shape", "");
            return pFeatclass;
        }

        public IFeatureClass CreatePointFile(String strFolder, String filename, IEnvelope pEnvBorder, ISpatialReference pSR)
        {
            // Open the folder to contain the shapefile as a workspace
            IWorkspaceFactory pWF = new ESRI.ArcGIS.DataSourcesFile.ShapefileWorkspaceFactoryClass();
            IFeatureWorkspace pfws = (IFeatureWorkspace)pWF.OpenFromFile(strFolder, 0);

            //Set up a simple fields collection
            IField pField = new FieldClass();
            IFieldEdit pFieldEdit = (IFieldEdit)pField;
            IFields pFields = new FieldsClass();
            IFieldsEdit pFieldsEdit = (IFieldsEdit)pFields;

            // Make the shape field
            //it will need a geometry definition, with a spatial reference
                       
            pFieldEdit.Name_2 = "Shape";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;

            IGeometryDef pGeomDef = new GeometryDef();
            IGeometryDefEdit pGeomDefEdit = (IGeometryDefEdit)pGeomDef;

            pGeomDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;

            pGeomDefEdit.SpatialReference_2 = pSR;

            pFieldEdit.GeometryDef_2 = pGeomDef;
            pFieldsEdit.AddField(pField);

            // Add ID field
            IField pFieldOID = new Field();
            pFieldEdit = (IFieldEdit)pFieldOID;
            pFieldEdit.Name_2 = "OBJECTID";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeOID;
            pFieldEdit.IsNullable_2 = false;

            pFieldsEdit.AddField(pFieldOID);


            if (File.Exists(strFolder + filename + ".shp") == true)
            {
                DialogResult result = MessageBox.Show("There is a shapefile have the same name in this foler, do you want to overwrite it?", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    File.Delete(strFolder + filename);
                  
                }
                else
                {
                    return null;                  
                }
            }
            IFeatureClass pFeatclass = pfws.CreateFeatureClass(filename, pFields, null, null, esriFeatureType.esriFTSimple, "Shape", "");
            return pFeatclass;
        }
    }
}

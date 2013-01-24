PRSS_programYM
==============

Title of the paper: PRSS to Aid Palaeocontinental Reconstructions Simulation Research 
Authors: Liang Feng, Chen Jianping, Yu Miao, Gong Fuxiu, Yu Pingping, Tian Hui
The paper will be published in Computers and Geosciences. 

Description of the code: 
  The Palaeocontinental Reconstructions Simulation System (PRSS) was independently developed using a set of methods based on paleomagnetism, computer models of plate tectonics, motion characteristics on a spherical surface and relevant mathematical algorithms to analyse quantitatively and simulate dynamically plate motions during geologic history.
  PRSS is mainly intended for geoscientists who wish to study plate tectonics and produce palaeocontinental reconstructions. PRSS integrates many of the necessary functions required for this research: (1) Palaeocontinental reconstructions with known Euler data; (2) Palaeocontinental reconstructions based on palaeomagnetic data; (3) Use of spherical geometric principles to construct Euler poles; (4) Generating positions of continents at any geological time by interpolation algorithms.

Running Environment:
Before run the program, you need to install the .net3.5 framework for windows and the ArcEngineRuntime9.3.
The program can be compiled by Microsoft Visual Studio 2008. 
Program Interfaces includes ESRI.ArcGIS.3DAnalyst, ESRI.ArcGIS.ADF, ESRI.ArcGIS.Animation, ESRI.ArcGIS.AxControls, ESRI.ArcGIS.Carto, ESRI.ArcGIS.Controls, ESRI.ArcGIS.DataSourcesFile, ESRI.ArcGIS.DataSourcesGDB, ESRI.ArcGIS.DataSourcesNetCDF, ESRI.ArcGIS.DataSourcesRaster, ESRI.ArcGIS.Display, ESRI.ArcGIS.Geodatabase, ESRI.ArcGIS.GeoDatabaseDistributed, ESRI.ArcGIS.GeoDatabaseExtensions, ESRI.ArcGIS.Geometry, ESRI.ArcGIS.Geoprocessing, ESRI.ArcGIS.GISClient, ESRI.ArcGIS.GlobeCore, ESRI.ArcGIS.NetworkAnalyst, ESRI.ArcGIS.Output, ESRI.ArcGIS.Server, ESRI.ArcGIS.System, ESRI.ArcGIS.SystemUI, System, System.Data, System.Drawing, System.Web, System.Web.Services, System.Windows.Forms, System.XML

Instructions:
You can start the program from the module "frmlogin.cs" which is used for authenticate user logins, and then "ParentForm.cs" will be loaded. After choose the "new" selection, the "ChildForm.cs" will be loaded and you can call the main functions of palaeocontinental reconstructions by using controls.



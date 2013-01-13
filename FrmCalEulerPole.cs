using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;


namespace MDIApplication
{
    public partial class FrmCalEulerPole : Form
    {

        int numN = 0;
        int numS = 0;

        public FrmCalEulerPole()
        {
            InitializeComponent();           
        }

        private void CalEulerPoleFrm_Load(object sender, EventArgs e)
        {
          
        }
        public void plane_solution()
        {
            Double X, X1, Y, Y1, Angle, tgp1, tgp2, tgp3; 
            Double latm1, latm2, latm3, longm1, longm2, longm3;
         
            Double latC1, latC2, latC3;
            Double longC1, longC2, longC3;
            Double latP1, latP2, latP3;
            Double longP1, longP2, longP3;
            Double half, dis;

            longC1 = Convert.ToDouble(textBox7.Text);
            longP1 = Convert.ToDouble(textBox8.Text);
            latC1 = Convert.ToDouble(textBox5.Text);
            latP1 = Convert.ToDouble(textBox6.Text);

            longC2 = Convert.ToDouble(textBox11.Text);
            longP2 = Convert.ToDouble(textBox12.Text);
            latC2 = Convert.ToDouble(textBox9.Text);
            latP2 = Convert.ToDouble(textBox10.Text);

            longC3 = 10270456.38;
            longP3 = 8324089.25;
            latC3 = 2721701.63;
            latP3 = -204952.6;

            longm1 = longC1 + (longP1 - longC1) / 2;
            latm1 = latC1 + (longm1 - longC1) * (latP1 - latC1) / (longP1 - longC1);

            longm2 = longC2 + (longP2 - longC2) / 2;
            latm2 = latC2 + (longm2 - longC2) * (latP2 - latC2) / (longP2 - longC2);

            longm3 = longC3 + (longP3 - longC3) / 2;
            latm3 = latC3 + (longm3 - longC3) * (latP3 - latC3) / (longP3 - longC3);

            tgp1 = -(longP1 - longC1) / (latP1 - latC1);
            tgp2 = -(longP2 - longC2) / (latP2 - latC2);
            tgp3 = -(longP3 - longC3) / (latP3 - latC3);

            Y = (latm2 - tgp2 * longm2 - latm1 + tgp1 * longm1) / (tgp1 - tgp2);
            X = (Y - longm1) / tgp1 + latm1;
            Y1 = (latm3 - tgp3 * longm3 - latm1 + tgp1 * longm1) / (tgp1 - tgp3);
            X1 = (Y1 - longm1) / tgp1 + latm1;

            half = Math.Sqrt((longP1 - longC1) * (longP1 - longC1) + (latP1 - latC1)*(latP1 - latC1)) / 2;
            dis = Math.Sqrt((Y - longC1) *(Y - longC1) + (X - latC1)*(X - latC1));
            Angle = -2 * CCEuler.deg(Math.Asin(half / dis));
                          

            textBox14.Text = X.ToString();
            textBox13.Text = Y.ToString();
            textBox15.Text = Angle.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.plane_solution();
        }
               
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class FrmAnyEulerPole : Form
    {
        public FrmAnyEulerPole()
        {
            InitializeComponent();
            ListView.View = View.Details;
            listView1.View = View.Details;
        }
        double t1, t2;
        CCEuler.EulerPole cpole;
        double cang;
        CCEuler.EulerPole[] s_pole = new CCEuler.EulerPole[100];
        double[] s_angle = new double[100];
        CCStage_Velocity.rotpol[] r = new CCStage_Velocity.rotpol[100];
        double[] v = new double[100];
        double[] omega = new double[100];
        int compmode=0;

        private void button1_Click(object sender, EventArgs e)
        {
            //CCEuler.EulerPole p;
            double tt;
            int count, i;
            count = ListView.Items.Count;
            
           if (count < 2)
            {
                MessageBox.Show("Euler pole less than two");
                return;
            }
            for (i = 0; i <= count-1; i++)
            {

                r[i].name1 = ListView.Items[i].Text;
                r[i].hiage = Convert.ToDouble(ListView.Items[i].SubItems[1].Text);
                r[i].p.Lattd = Convert.ToDouble(ListView.Items[i].SubItems[2].Text);
                r[i].p.Longttd = Convert.ToDouble(ListView.Items[i].SubItems[3].Text);
                r[i].Angle = Convert.ToDouble(ListView.Items[i].SubItems[4].Text);
            }
            double tmin, tmax;
            int index = 2;
        
            tmin = r[0].hiage;
            tmax = r[count - 1].hiage;           

            CCStage_Velocity.StagePole(r, count, out s_pole, out s_angle);           
            CCStage_Velocity.velocity(count, r, s_pole, s_angle, out omega, out v);            
            int k = 1;
            switch (compmode)
            {
                case 0:
                    int d = (int)timeinteval.Value;
                    tt = (int)tmin + d;

                    while (tt < (int)tmax)
                    {
                        for (i = 0; i <= count - 1; i = i + 1)
                        {
                            if (tt < r[i].hiage)
                            {
                                index = i;
                                k = i;
                                if (tt == r[i - 1].hiage)
                                    k = i - 1;
                                break;
                            }
                        }

                        CalcSingleEuler(index - 1, s_pole[index], s_angle[index], r[index - 1].hiage, r[index].hiage, tt);
                        ListViewItem itmx = new ListViewItem();
                        listView1.Items.Add(itmx);
                        itmx.Text = CombTName.Text;
                        itmx.SubItems.Add(tt.ToString());
                        itmx.SubItems.Add(cpole.Lattd.ToString());
                        itmx.SubItems.Add(cpole.Longttd.ToString());
                        itmx.SubItems.Add(cang.ToString());
                        itmx.SubItems.Add(v[k].ToString());   

                        tt = tt + d;
                    }
                    break;

                case 1:
                    if (TimeG.Text == "")
                    {
                        MessageBox.Show("Age is null");
                        TimeG.Focus();
                        break;
                    }

                    tt = Convert.ToDouble(TimeG.Text);

                    if (tt <= tmin || tt >= tmax)
                    {
                        MessageBox.Show("Beyond the time range");
                        TimeG.Focus();
                        break;
                    }

                    for (i = 0; i <= count-1; i++)
                    {
                        if (tt < r[i].hiage)
                        {
                            index = i;
                            k = i;
                            if (tt == r[i - 1].hiage)
                                k = i - 1;
                            break;
                        }
                    }
                    CalcSingleEuler(index - 1, s_pole[index], s_angle[index], r[index - 1].hiage, r[index].hiage, tt);
                    ListViewItem itmx2 = new ListViewItem();
                    listView1.Items.Add(itmx2);
                    itmx2.Text = CombTName.Text;
                    itmx2.SubItems.Add(tt.ToString());
                    itmx2.SubItems.Add(cpole.Lattd.ToString());
                    itmx2.SubItems.Add(cpole.Longttd.ToString());
                    itmx2.SubItems.Add(cang.ToString());
                    itmx2.SubItems.Add(v[k].ToString()); 

                    break;

                case 2:
                    if (Time1G.Text == "" || Time2G.Text == "")
                    {
                        MessageBox.Show("Age is null");
                        Time1G.Focus();
                        break;
                    }

                    t1 = Convert.ToDouble(Time1G.Text);
                    t2 = Convert.ToDouble(Time2G.Text);

                    if (t1 > t2)
                    {
                        MessageBox.Show("Beyond the time range");
                        Time1G.Focus();
                        break;
                    }
                    if (t2 >= tmax || t1 <= tmin)
                    {
                        MessageBox.Show("Beyond the time range");
                        Time1G.Focus();
                        break;
                    }

                    tt = (int)t1 + 1;
                    while (tt < (int)t2)
                    {
                        for (i = 0; i <= count-1; i++)
                        {
                            if (tt < r[i].hiage)
                            {
                                index = i;
                                k = i;
                                if (tt == r[i - 1].hiage)
                                    k = i - 1;
                                break;
                            }
                        }
                        CalcSingleEuler(index - 1, s_pole[index], s_angle[index], r[index - 1].hiage, r[index].hiage, tt);
                        ListViewItem itmx3 = new ListViewItem();
                        listView1.Items.Add(itmx3);
                        itmx3.Text = CombTName.Text;

                        itmx3.SubItems.Add(tt.ToString());
                        itmx3.SubItems.Add(cpole.Lattd.ToString());
                        itmx3.SubItems.Add(cpole.Longttd.ToString());
                        itmx3.SubItems.Add(cang.ToString());
                        itmx3.SubItems.Add(v[k].ToString());

                        tt = tt + 1;
                    }
                    break;
            }
        }
      private void CalcSingleEuler(int index, CCEuler.EulerPole spole, double sang, double tt1,double tt2 , double ctt)
      {
        double omega;        
        omega = sang / (tt2 - tt1);          
        double anglex;
        CCStage_Velocity.matrix m1,mx,ms;        

        anglex = (ctt - tt1) * omega;
        CCEuler.calc_pole2matrix( out m1.ma, r[index].p, r[index].Angle);
        CCEuler.calc_pole2matrix(out mx.ma, spole, anglex);
        
        CCEuler.matrix_mult( m1.ma, mx.ma, out ms.ma);  
        CCEuler.calc_matrix2pole(ms.ma, out cpole, out cang);    
     }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            compmode = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            compmode = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            compmode = 2;
        }               

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem itmx = new ListViewItem();
            ListView.Items.Add(itmx);
            itmx.Text = CombTName.Text;
            itmx.SubItems.Add(TimeT.Text);
            itmx.SubItems.Add(FPoleLat.Text);
            itmx.SubItems.Add(FPoleLong.Text);
            itmx.SubItems.Add(FAngle.Text);              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = ListView.Items.Count - 1; i >= 0; i--)
            {
                if (ListView.Items[i].Selected == false)
                    continue;
                ListView.Items[i].Remove();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected == false)
                    continue;
                listView1.Items[i].Remove();
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = ListView.Items.Count - 1; i >= 0; i--)
            {
                if (ListView.Items[i].Selected == false)
                    continue;
                ListView.Items[i].Remove();
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i =0; i<=ListView.Items.Count - 1;  i++)
            {
                if (ListView.Items[i].Selected == false)
                    continue;
                              
                for (int j = 0; j <= ListView.Items[i].SubItems.Count - 1; j++)
                    s = s + ListView.Items[i].SubItems[j].Text+"\t";
                s = s + "\r";
                Clipboard.SetDataObject(s);
            }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = ListView.Items.Count - 1; i >= 0; i--)
            {
                if (ListView.Items[i].Selected == false)
                    continue;
                ListView.Items[i].BeginEdit();
            }
        }              

       private void TimeT_TextChanged(object sender, EventArgs e)
       {
                    
           try
           {
               double aa = Convert.ToDouble(TimeT.Text);
           }
           catch
           {
               TimeT.Text = "";
           }    
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

       private void TimeEnd_TextChanged(object sender, EventArgs e)
       {
           try
           {
               double aa = Convert.ToDouble(TimeEnd.Text);
           }
           catch
           {
               TimeEnd.Text = "";
           }   
           
       }    

       private void CombTerrID_TextChanged(object sender, EventArgs e)
       {
           try
           {
               int aa = Convert.ToInt32(CombTerrID.Text);
           }
           catch
           {
               CombTerrID.Text = "";
           }
       }

       private void CombTName_TextChanged(object sender, EventArgs e)
       {
           try
           {
               int aa = Convert.ToInt32(CombTName.Text);
               CombTName.Text = "";
           }
           catch { }

           try {
               double bb = Convert.ToDouble(CombTName.Text);
               CombTName.Text = "";
           }
           catch{ }  
       }

       private void TimeG_TextChanged(object sender, EventArgs e)
       {
           try
           {
               double aa = Convert.ToDouble(TimeG.Text);
           }
           catch
           {
               TimeG.Text = "";
           }   
       }

       private void Time1G_TextChanged(object sender, EventArgs e)
       {
           try
           {
               double aa = Convert.ToDouble(Time1G.Text);
           }
           catch
           {
               Time1G.Text = "";
           }   
       }

       private void Time2G_TextChanged(object sender, EventArgs e)
       {
           try
           {
               double aa = Convert.ToDouble(Time2G.Text);
           }
           catch
           {
               Time2G.Text = "";
           }   
       }                              
    }
}

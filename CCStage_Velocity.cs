using System;
using System.Collections.Generic;
using System.Text;

namespace MDIApplication
{
    public class CCStage_Velocity
    {
        public struct rotpol
        {
           public string name1, name2;
           public double loage, hiage;
           public CCEuler.EulerPole p;
           public double Angle;
           public string s;
        }
        public struct matrix
        {
            public double[,] ma;          
        }        
       
        public const double EarthRadius = 6371.04;//earth radius

        rotpol[] rs = new rotpol[100];
        CCEuler.EulerPole[] s_pole1 = new CCEuler.EulerPole[100];
        double[] s_angle1 = new double[100];
        
      public static  void StagePole( rotpol[] r,  int n, out CCEuler.EulerPole[] s_pole, out double[] s_angle)

        {  
            int o;
            matrix[] m = new matrix[100];
            matrix[] mt = new matrix[100];
            matrix[] ms = new matrix[100];

            s_pole = new CCEuler.EulerPole[100];
            s_angle = new double[100];

            CCEuler.matrix_1(out m[1].ma);
            CCEuler.matrix_1(out mt[0].ma);
            for (o = 0; o <= n - 1; o++)
            {
                CCEuler.calc_pole2matrix(out m[o].ma, r[o].p, r[o].Angle);
                CCEuler.calc_pole2matrix(out mt[o].ma, r[o].p, -r[o].Angle);                 
            }
            for (o = 0; o < n-1; o++)
            {
                CCEuler.matrix_mult(mt[o].ma, m[o+1 ].ma, out ms[o+1].ma);                
                CCEuler.calc_matrix2pole(ms[o+1].ma, out s_pole[o+1], out s_angle[o+1]);                
            }          
      }
        public static void  velocity(int n, rotpol[] r,  CCEuler.EulerPole[] s_pole,  double[] s_angle, out double[] omega, out double[] v)
        {
            int o;
            CCEuler.EulerPole p;
            p.Lattd = 0;
            p.Longttd = 0;
            
            omega = new double[100];
            v = new double[100]; 
            double X, Y, z;
            for (o = 0; o <= n - 1; o++)
            {
             CCEuler.vectorproduct (out X, out Y, out z, s_pole[o], p);
             omega[o] = s_angle[o] / (r[o + 1].hiage - r[o].hiage) ;
             v[o] = Math.Sqrt(X * X + Y * Y + z * z) * EarthRadius * CCEuler.rad(omega[o]); 
            }        
        }
    }
}

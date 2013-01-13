using System;
using System.Collections.Generic;
using System.Text;

namespace MDIApplication
{
    //Define class CCEuler
    public class CCEuler
    {
        //Define struct
        public struct EulerPole
        {
            public double Longttd;
            public double Lattd;
        }
        
        double[,] m = new double[3,3];

        //transformation from degrees to radians
        public static double rad(double alpha)
        {
            double r;
            r = alpha *  Math.PI / 180;
            return r;
        }
        //transformation from radians to degrees
        public static double deg(double alpha)
        {
            double d;
            d = alpha / Math.PI * 180;
            return d;
        }
        //mathematic formulas in .net is ready.
        //such as Acos(arccos),Asin(arcsin) and so on.And the result and the input parameter of angle is radian!!

        //transformation from spherical to orthogonal coordiantes
        //use 'out' and 'void' instead of return() because of multi-returned values
        public static void sphere2kart(out double X,out double Y,out double z ,EulerPole p)
        {
          X = Math.Cos (rad (p.Lattd )) * Math.Cos (rad(p.Longttd ));
          Y = Math.Cos (rad(p.Lattd )) * Math.Sin (rad(p.Longttd ));
          z = Math.Sin (rad(p.Lattd ));          
        }
        //transformation from orthogonal to spherical coordinates
        public static void kart2sphere(out EulerPole p, double X, double Y, double z)
        {
          //Initialize,otherwise,error:
           p.Lattd = 0;
           p.Longttd = 0;
          //lattitude in z-axis or not
          if ((X * X + Y * Y)!= 0)
            {p.Lattd = Math.Atan (z / Math.Sqrt (X * X + Y * Y));}
          else
            {if (z > 0)
              {p.Lattd = Math.PI /2;}
            if (z < 0)
              {p.Lattd = -Math.PI /2;}}
          //longtitude,decide which quadrant
          //first and second quadrant
          if (X > 0)
            {if (Y > 0)
              {p.Longttd = Math.Atan (Y/X);}
            if (Y < 0)
              {p.Longttd = Math.Atan (Y/X) + 2 * Math.PI;}}
          //longtitude in y-axis or pole or not
          if (X == 0)
            {if (Y > 0)
              {p.Longttd = Math.PI /2;}
            if (Y < 0)
              {p.Longttd = -Math.PI /2;}
            if (Y == 0)
              {p.Longttd =0;}}
          //the third or forth quadrant
          if (X < 0)
            {p.Longttd = Math.Atan (Y/X) + Math.PI ;}
          //transform result from radian to degree
          p.Longttd = deg ( p.Longttd );
          p.Lattd = deg (p.Lattd );
          //ensure the longtitude of the EulerPole is between -180 to 180
          if (p.Longttd > 180 )
            {p.Longttd = p.Longttd - 360;}
          if (p.Longttd < -180)
            {p.Longttd = p.Longttd + 360;}}
        //calculation of the vector product
        //OA*OB=(a2b3-a3b2)i-(a1b3-a3b1)j+(a1b2-a2b1)k, |OA|*|OB|sina
        public static void vectorproduct(out double X,out double Y,out double z,EulerPole A,EulerPole B)
        {
          double ax,ay,az;
          double bx,by,bz;
          sphere2kart(out ax, out ay, out az, A);
          sphere2kart(out bx, out by, out bz, B);
          X = ay * bz - az * by;
          Y = az * bx - ax * bz;
          z = ax * by - ay * bx;
        }
        //calculation of the rotation matrix from an euler pole,maybe have sth wrong with it
        public static void calc_pole2matrix(out double[,] m ,EulerPole p,double Angle1 )
        {
          double X,Y,z;
          double Angle=rad(Angle1);
          m = new double[3, 3];
          sphere2kart(out X, out Y, out z, p);

          m[0,0]= X * X * (1 - Math.Cos(Angle)) + Math.Cos(Angle);
          m[0,1] = X * Y * (1 - Math.Cos(Angle)) - z * Math.Sin(Angle);
          m[0,2] = X * z * (1 - Math.Cos(Angle)) + Y * Math.Sin(Angle);
          m[1,0] = Y * X * (1 - Math.Cos (Angle)) + z * Math.Sin (Angle);
          m[1,1] = Y * Y * (1 - Math.Cos (Angle)) + Math.Cos (Angle);
          m[1,2] = Y * z * (1 - Math.Cos (Angle)) - X * Math.Sin (Angle);
          m[2,0] = z * X * (1 - Math.Cos (Angle)) - Y * Math.Sin (Angle);
          m[2,1] = z * Y * (1 - Math.Cos (Angle)) + X * Math.Sin (Angle);
          m[2,2] = z * z * (1 - Math.Cos (Angle)) + Math.Cos (Angle);
        }
        //calculation of the euler pole from a rotation matrix
        public static void calc_matrix2pole(double[,] m,out EulerPole p , out double Angle)
        {
          double X1,Y1,z1;
          
          X1 = m[2,1]-m[1,2];
          Y1 = m[0,2]-m[2,0];
          z1 = m[1,0]-m[0,1];
          p.Lattd = 0;
          p.Longttd = 0;
          kart2sphere( out p,X1,Y1,z1);
          Angle = deg (Math.Atan (Math.Sqrt ( X1*X1 + Y1*Y1 + z1*z1)/( m[0,0]+m[1,1]+m[2,2] - 1)));
          //if the latitude of the EulerPole is less than zero,then change in the below way
          //ensure the EulerPole is at north earth,in fact it's the same but the order of the P and P'
          if ( p.Lattd < 0 )
          {
              p.Lattd = -p.Lattd;
              p.Longttd = p.Longttd - 180;
              Angle = -Angle;
          }
          //ensure the longtitude of the EulerPole is betwen -180 to 180
          if (p.Longttd > 180)
          { p.Longttd = p.Longttd - 360; }
          if (p.Longttd < 180)
          { p.Longttd = p.Longttd + 360; }
        }
        //calculation of euler pole from VGP(virtual paeomagnetic pole)
        public static void calc_VGP2pole(EulerPole vgp,out EulerPole p,out double Angle,Boolean polarity)
        {
            //polarity represent North pole or South pole,true is N ,false is S
            p.Lattd = 0;
            p.Longttd = vgp.Longttd + 90;
            //ensure the longtitude of the EulerPole is betwen -180 to 180
            if (p.Longttd > 360)
            {p.Longttd = p.Longttd - 360;}
            Angle = vgp.Lattd - 90;      
        }
        //multiplication of 2 matrices
        public static void matrix_mult(double[,] A,double[,] B,out double[,] m)
        {
          //initialize array 'm',otherwise error:

          m = new double[3, 3];
          m[0, 0] = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0] + A[0, 2] * B[2, 0];
          m[0, 1] = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1] + A[0, 2] * B[2, 1];
          m[0, 2] = A[0, 0] * B[0, 2] + A[0, 1] * B[1, 2] + A[0, 2] * B[2, 2];
          m[1, 0] = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0] + A[1, 2] * B[2, 0];
          m[1, 1] = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1] + A[1, 2] * B[2, 1];
          m[1, 2] = A[1, 0] * B[0, 2] + A[1, 1] * B[1, 2] + A[1, 2] * B[2, 2];
          m[2, 0] = A[2, 0] * B[0, 0] + A[2, 1] * B[1, 0] + A[2, 2] * B[2, 0];
          m[2, 1] = A[2, 0] * B[0, 1] + A[2, 1] * B[1, 1] + A[2, 2] * B[2, 1];
          m[2, 2] = A[2, 0] * B[0, 2] + A[2, 1] * B[1, 2] + A[2, 2] * B[2, 2];
        }
        //define an unity-matrix
        public static void matrix_1(out double[,] m) //3*3 unit matrix
        {
            int A,B;
            m = new double[3, 3];
            for (A=0;A<=2;A++)
            {
              for (B=0;B<=2;B++)
              {
                if(A==B)
                { m[A,B] =1; }
                else
                { m[A,B] =0; }
              }
            }
        }
        //rotate P to P' with the matrix M
        public static void euler_rot(out EulerPole p,double[,] m)
        {
          double X,Y,z;
          double X1,Y1,z1;
          //Initialize,otherwise,error
         p.Lattd = 0;
         p.Longttd = 0;
          sphere2kart(out X, out Y, out z,  p);
          X1 = m[0, 0] * X + m[0, 1] * Y + m[0, 2] * z;
          Y1 = m[1, 0] * X + m[1, 1] * Y + m[1, 2] * z;
          z1 = m[2, 0] * X + m[2, 1] * Y + m[2, 2] * z;
          kart2sphere(out p,X1,Y1,z1);
        }
        //calculate the angle between two vectors
        public static double calc_angle(EulerPole A,EulerPole B)
        {
          double a1,a2,a3;
          double b1,b2,b3;
          double w;
          sphere2kart(out a1, out a2, out a3, A);
          sphere2kart(out b1, out b2, out b3, B);
          w = Math.Acos(a1*b1 + a2*b2 + a3*b3);
          return w;
        }
    }
}

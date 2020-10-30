using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Task1
{
   public class Geometry
    {

        public double CalculateArea(double R)

        {
            return 3.14159 * R * R;

        }

        public double CalculatePerimeter(double R)
        {
            return 2 * 3.14159 * R;
        }


        public double CalculateArea(double H,double W)

        {
            return H * W;

        }

        public double CalculatePerimeter(double H,double W)
        {
            return 2 * (H + W);
        }
        public double CalculateArea(double  s1,double s2,double s3)

        {
            var s = (s1 + s2 + s3)/2.0;

            var r = s * (s - s1) * (s - s2) * (s - s3);


            var re = Math.Sqrt(r);
            return re;


        }

        public double CalculatePerimeter(double s1, double s2, double s3)
        {
            return (s1 + s2 + s3);

        }



    }
}

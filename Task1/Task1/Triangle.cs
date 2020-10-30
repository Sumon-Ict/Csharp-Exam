using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
   public  class Triangle:Shape
    {

        private double side1;
        private double side2;
        private double side3;
        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        
        public double Side2
        {
            get { return side2; }
            set
            {
                side2 = value;
            }
        }

        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }

    }
}

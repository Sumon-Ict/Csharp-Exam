using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Rectangle:Shape
    {


        private double height;
        private double width;
        public double Height
        {

            get { return height; }
            set
            {
                height = value;
            }
        }
        public double Width
        {
            get { return width; }

            set
            {
                width = value;
            }
        }

    }
}

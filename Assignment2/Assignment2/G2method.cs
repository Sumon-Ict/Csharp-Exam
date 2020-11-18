using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
   public  class G2method
    {
        public void swapvalue<T>(ref T a,ref T b )  //generic method created 
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
   public class Gclass<T>   //created  generic class 
    {

        private T datavalue;


        public T Data
        {
            get { return datavalue; }
            set
            {
                datavalue = value;
            }
        }

    }
}

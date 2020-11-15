using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class StudenInfo<Tkey, Tvalue>    //generic class created 
    {
        public Tkey roll { get; set; }
        public Tvalue name { get; set; }


        public void addroll(Tkey r)   // generic methd 
        {
            roll = r;
        }

        public void addname(Tvalue n)   //generic method 
        {
            name = n;
        }


       
    }
}

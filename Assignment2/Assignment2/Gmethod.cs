using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
   public  class Gmethod
    {
        public void displayInfo<Tkey, Tvalue>(Tkey kvalue,Tvalue value )  //    generic method
        {
            Console.WriteLine($"{kvalue} , {value} ");

        }



        public void display<T1,T2,T3>(T1 value1, T2 value2,T3 value3)   //generic method 
        {

            Console.WriteLine($"{ value1},  {value2},  {value3} ");

        }








    }
}

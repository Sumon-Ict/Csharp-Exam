using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
   public  class Gmethod
    {
        public void displayInfo<Tkey, Tvalue>(Tkey k,Tvalue v )  //    generic method
        {
            Console.WriteLine($"{k} , {v} ");

        }



        public void display<T1,T2,T3>(T1 v1, T2 v2,T3 v3)   //generic method 
        {

            Console.WriteLine($"{ v1},  {v2},  {v3} ");

        }





    }
}

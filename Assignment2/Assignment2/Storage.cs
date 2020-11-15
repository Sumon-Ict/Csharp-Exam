using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
   public class Storage<T>
    {
        
       
        
        private T[] items;
        public Storage(int size)
        {
            items = new T[size];

        }

        public void insertitem(int index, T insertValue)
        {
            items[index] = insertValue;
        }

        public T getitem(int index) 
        {
            return items[index];

        }




        
    }
}

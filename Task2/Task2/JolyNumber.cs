using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
   public class JolyNumber
    {
        public int Number { get; set; }
        public JolyNumber()
        {

        }

        public JolyNumber(int n)
        {
            Number = n;
        }
        public virtual int Increment()
        {
            return Number+1;

        }
        public int Increment(int n)
        {
            return Number + n;

        }

    }
}

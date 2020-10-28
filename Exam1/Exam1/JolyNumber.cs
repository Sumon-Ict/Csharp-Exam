using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Exam1
{
      public class JolyNumber



    {

        private int number;

        public int NUMBER
        {
            get { return number; }
            set
            {
                number = value;

            }
        }

        



        public int  Increment()
        {
            return number = number + 1;

           
        }
        public int Increment(int num )
        {
            return num = num + 1;
        }


        JolyNumber()
        {
            this.number = 0;

        }
        JolyNumber(int number)
        {
            this.number = number;

        }

            
    }
}

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // without parameter value
            JolyNumber J = new JolyNumber();
            var v =Convert.ToInt32( Console.ReadLine());

            J.Number = v;

            Console.WriteLine(J.Increment());
            Console.WriteLine(J.Increment(v));


            //creating molynumber class object 

            MolyNumber M = new MolyNumber();

            Console.WriteLine(M.Increment());


            //by using parameter value

            JolyNumber J2 = new JolyNumber(Convert.ToInt32(Console.ReadLine()));

           Console.WriteLine(J2.Increment());

           Console.WriteLine(J2.Increment(Convert.ToInt32(Console.ReadLine())));




                







        }
    }
}

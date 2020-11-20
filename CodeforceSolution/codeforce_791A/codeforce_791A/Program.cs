using System;
using System.Linq;

namespace codeforce_791A
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int a = value[0];
            int b = value[1];


            int d = 0;
            for(int i=0; ; i++)
            {
                if (a > b)
                    break;
                else
                {
                    a = a * 3;
                    b = b * 2;
                    d++;

                }

            }

            Console.WriteLine(d);



                
        }
    }
}

using System;
using System.Linq;

namespace codeforce_1108A
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());

            for(int i=0;i<testcase;i++)
            {
                int[] value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int a = value[0];
                int b = value[1];
                int c = value[2];
                int d = value[3];


                int r = 0;
                int r2 = 0;

                if(a==c&&b==d)
                {
                    r = a;
                    r2 = b;
                }
                else if(a!=c&&b!=d)
                {
                    r = a;
                    r2 = c;
                }
                else if(a!=c&&b==d)
                {
                    r = a;
                    r2 = c;
                }
                else if(a==c&&b!=d)
                {
                    r = b;
                    r2 = d;

                }


                Console.WriteLine($"{r} {r2}");

            }
        }
    }
}

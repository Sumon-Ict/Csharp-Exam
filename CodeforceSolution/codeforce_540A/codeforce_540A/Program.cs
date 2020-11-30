using System;

namespace codeforce_540A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int d = 0;

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            for(int i=0;i<n;i++)
            {

                int a = (char)str1[i];
                int b = (char)str2[i];

                int r = Math.Abs(a - b);

                if (r > 5)
                    d += (10 - r);
                else
                    d += r;

            }
            Console.WriteLine(d);



        }
    }
}

using System;
using System.Linq;

namespace codeforce_977A
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = value[0];
            int k = value[1];

            for(int i=0;i<k;i++)
            {
                if (n % 10 == 0)
                {
                    n = n / 10;
                }
                else
                    n = n - 1;

            }
            Console.WriteLine(n);

        }
    }
}

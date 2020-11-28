using System;
using System.Linq;

namespace codeforce_686A
{
    class Program
    {
        static void Main(string[] args)
        {



            long[] v = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long n = v[0];
            long amount = v[1];
            int d = 0;

            for (int i = 0; i < n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');

                string a = value[0];

                int b = int.Parse(value[1]);

                if(string.Equals(a,"+"))
                {
                    amount += b;
                }

                else
                {
                    if (amount >= b)
                        amount -= b;
                    else
                        d++;
                }
                
            }

            Console.WriteLine($"{amount} {d}");



        }
    }
}

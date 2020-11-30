using System;
using System.Linq;

namespace codeforce_427A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int amount =0;
            int d = 0;


            for(int i=0;i<n;i++)
            {
                if (value[i] == -1 && amount == 0)
                {
                    d++;
                }
                else if (value[i] == -1 && amount > 0)
                    amount -= 1;
                else
                    amount += value[i];
            }

            Console.WriteLine(d);

        }
    }
}

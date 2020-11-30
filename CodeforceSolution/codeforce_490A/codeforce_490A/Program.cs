using System;
using System.Collections.Generic;
using System.Linq;

namespace codeforce_490A
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());
            var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List < int > d1 = new List<int>();
            List<int> d2 = new List<int>();
            List<int> d3 = new List<int>();

            for(int i=0;i<n;i++)
            {
                if (value[i] == 1)
                    d1.Add(i + 1);
                else if (value[i] == 2)
                    d2.Add(i + 1);
                else if (value[i] == 3)
                    d3.Add(i + 1);

            }

            int r = Math.Min(d1.Count, Math.Min(d2.Count, d3.Count));

            if (r == 0)
                Console.WriteLine("0");
            else
            {
                Console.WriteLine(r);

                for(int i=0;i<r;i++)
                {
                  
                    Console.WriteLine($"{d1[i]} {d2[i]} {d3[i]}");

                   
                }
            }

      


        }
    }
}

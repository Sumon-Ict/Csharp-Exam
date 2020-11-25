using System;
using System.Collections.Generic;
using System.Linq;

namespace codeforce_237A
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SortedSet<int> ss = new SortedSet<int>();
            List<int> list = new List<int>();

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n + 1];


            for(int i=0;i<n;i++)
            {
                int[] value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int hm = value[0] * 60 + value[1];
                array[i] = hm;
                ss.Add(hm);
             




            }

           foreach(int v in ss)
            {
                int d = 0;
                int v1=v;

                for(int i=0;i<n;i++)
                {
                    if (v1 == array[i])
                        d++;

                }

                list.Add(d);


            }

            int result = list.Max();

            Console.WriteLine(result);




           

            



        }
    }
}

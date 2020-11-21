using System;
using System.Linq;

namespace codeforces_155A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int max = value[0];
            int min = value[0];
            int d = 0;

            for(int i=1;i<n;i++)
            {
                if(value[i]>max)
                {
                    d++;
                    max = value[i];
                }

                else if(value[i]<min)
                {
                    d++;
                    min = value[i];

                }
            }
            Console.WriteLine(d);


        }
    }
}

using System;
using System.Linq;

namespace codeforce_200B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] value = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double sum = 0;

            for(int i=0;i<n;i++)
            {
                sum += value[i] / 100;

            }

            double r = (sum / n)*100;


            valueformat(r);
        
                


        }

        static void valueformat(double v)
        {
            Console.WriteLine(v.ToString("0.000000000000"));
        }
    }
}

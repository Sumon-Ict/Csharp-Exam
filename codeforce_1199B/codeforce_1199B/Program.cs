using System;
using System.Linq;

namespace codeforce_1199B
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            double r = (Math.Pow(value[0], 2) + Math.Pow(value[1], 2)) / (2 * value[0]);


            double r2 = r - value[0];
            valueformate(r2);



        }
        static void valueformate(double v)
        {
            Console.WriteLine(v.ToString("0.0000000000000"));
            
        }
    }
}

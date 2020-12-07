using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            
            var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = value[0];
            int b = value[1];

           long sum1 = 0;

           int[] digit = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int d = 0;

            for(int i=n-1;i>=0;i--)
            {
               // long r =(long)Math.Pow(b, i);

                sum1 += digit[d++] * (long)Math.Pow(b, i);

            }

            var value1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n1 = value1[0];
            int b1 = value1[1];

            long sum2 = 0;
            int[] digit1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int d1 = 0;

            for(int i=n1-1;i>=0;i--)
            {
                sum2 += digit1[d1++] * (long)Math.Pow(b1, i);

            }

            if (sum1 == sum2)
            {
                Console.WriteLine("=");
            }
            else if (sum1 > sum2)
                Console.WriteLine(">");
            else
                Console.WriteLine("<");


        }
    }
}

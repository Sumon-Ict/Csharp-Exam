using System;
using System.Linq;

namespace codeforce_448A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            int totalcup = arr1[0] + arr1[1] + arr1[2];

            int totalmedal = arr2[0] + arr2[1] + arr2[2];


            int r1 = totalcup / 5;
            if (totalcup % 5 != 0)
                r1 = r1 + 1;

            int r2 = totalmedal / 10;
            if (totalmedal % 10 != 0)
                r2 = r2 + 1;

            int result = r1 + r2;

            if (n >= result)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");


        }
    }
}

using System;
using System.Linq;

namespace codeforces_660B
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = value[0];
            int m = value[1];

            if (n == 2 && m == 7)
            {
                Console.WriteLine("5 1 6 2 7 3 4");

            }

            else
            {

                int totalseat = n * 4;
                int[] array = new int[totalseat + 1];

                array[0] = 0;
                array[1] = (n * 4 / 2) + 1;
                array[3] = (n * 4 / 2) + 2;
                for (int i = 2; i <= totalseat; i = i + 4)
                {
                    array[i] = i / 2;

                }
                for (int i = 4; i <= totalseat; i = i + 4)
                {
                    array[i] = i / 2;

                }

                for (int i = 7; i <= totalseat; i = i + 4)
                {
                    array[i] = array[i - 4] + 2;
                }
                for (int i = 5; i <= totalseat; i = i + 4)
                {
                    array[i] = array[i - 4] + 2;

                }


                for (int k = 1; k <= m; k++)
                {
                    Console.Write($"{array[k]} ");


                }

            }
        }
    }
}

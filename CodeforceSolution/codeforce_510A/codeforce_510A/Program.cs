using System;
using System.Linq;

namespace codeforce_510A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = value[0];
            int m = value[1];
            int d = 0;
            for(int i=1;i<=n;i++)
            {
                if(i%2==1)
                {
                    for (int j = 1; j <= m; j++)
                        Console.Write("#");

                }
                else
                {
                    if (d == 1)
                    {
                        Console.Write("#");
                        for (int j = 1; j < m; j++)
                            Console.Write(".");
                        d = 0;
                    }
                    else
                    {

                        for (int j = 1; j < m; j++)
                        {
                            Console.Write(".");
                        }
                        Console.Write("#");
                        d = 1;
                    }

                }
                Console.WriteLine();

            }

        }
    }
}

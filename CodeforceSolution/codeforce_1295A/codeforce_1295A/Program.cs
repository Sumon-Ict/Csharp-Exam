using System;

namespace codeforce_1295A
{
    class Program
    {
        static void Main(string[] args)
        {

            int testcase = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<testcase;i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if(n%2==1)
                {
                    int m = n - 3;

                    Console.Write("7");

                    for (int j=0;j<m/2;j++)
                    {
                      
                        Console.Write("1");
                       
                    }
                    

                    

                }
                else
                {
                    for(int k=0;k<n/2;k++)
                    {
                        Console.Write("1");
                    }
                    //Console.WriteLine("1");

                }

                Console.WriteLine();


            }
        }
    }
}

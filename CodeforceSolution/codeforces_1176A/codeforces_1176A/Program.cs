using System;

namespace codeforces_1176A
{
    class Program
    {
        static void Main(string[] args)
        { 
            int testcase = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<testcase;i++)
            {
                long n = long.Parse(Console.ReadLine());

                long d = 0;

               
                for(int j=0; ;j++)
                {
                    if(n%2==0)
                    {
                        n = n / 2;
                        d++;
                    }
                    else if(n%3==0)
                    {
                        n = (n * 2) / 3;
                        d++;
                    }
                    else if(n%5==0)
                    {
                        n = (4 * n) / 5;
                        d++;
                    }
                    else if(n%2!=0||n%3!=0||n%5!=0)
                    {
                        break;
                    }
                }

                if (n == 1)
                    Console.WriteLine(d);
                else
                    Console.WriteLine("-1");




            }

        }
    }
}

using System;

namespace codeforce_746B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string  str = Console.ReadLine();

            string st = "";


            if(n%2==1)
            {
                for(int i=0;i<n;i++)
                {
                    if (i % 2 == 0)
                        st = st + str[i];
                    else
                        st = str[i] + st;
                }

            }

            else
            {
                for(int i=0;i<n;i++)
                {
                    if (i % 2 == 0)
                        st = str[i] + st;
                    else
                        st = st + str[i];
                }
            }
            Console.WriteLine(st);


        }
    }
}

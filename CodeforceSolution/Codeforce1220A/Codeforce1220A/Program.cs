using System;
using System.Linq;

namespace Codeforce1220A
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitnumber = Convert.ToInt32(Console.ReadLine());

            string str = Console.ReadLine();

            //var num = str.TakeWhile(x => x == 'n');

            //var num1 = str.TakeWhile(x => x == 'z');

            int onecount = str.Split('n').Length - 1;
            int zercount = str.Split('z').Length - 1;

           // Console.WriteLine(onecount);
            //Console.WriteLine(zercount);

            if(onecount>0 &&zercount==0)
            {
                int t = 1;
                for(int i=1;i<=onecount;i++)
                {
                    if (t != onecount)
                    {
                        Console.Write("1 ");
                        t++;
                    }
                    else
                        Console.Write("1");



                }

            }

            else if(onecount>0&&zercount>0)
            {
                for(int i=1;i<=onecount;i++)
                {
                    Console.Write("1 ");

                }

               
                for(int j=1;j<=zercount;j++)
                {
                    int t = 1;
                    if (t != zercount)
                    {
                        Console.Write("0 ");
                        t++;
                    }
                    else
                        Console.Write("0");

                }
                
            }


            else if(onecount==0&&zercount>0)
            {
                int t = 1;

                for(int i=1;i<=zercount;i++)
                {
                    if (t != zercount)
                    {
                        Console.Write("0 ");
                        t++;

                    }
                    else
                        Console.Write("0");

                }

            }


        }
    }
}

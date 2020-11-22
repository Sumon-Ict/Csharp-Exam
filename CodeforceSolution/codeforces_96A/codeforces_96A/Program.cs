using System;

namespace codeforces_96A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int k = 0;

            for(int i=0;i<(str.Length-6);i++)
            {

                int d = 0;
                int d1 = 0;
                 if(str[i]=='1')
                { 

                    for(int j=i;j<=i+6;j++)
                    {
                        if (str[j] == '1')
                            d++;

                    }
                   
                }
                 else if(str[i]=='0')
                {

                    //int d1 = 0;
                    for(int j=i;j<=i+6;j++)
                    {
                        if (str[j] == '0')
                            d1++;
                    }

                }

                 if(d==7||d1==7)
                {
                    Console.WriteLine("YES");
                    
                    k = 1;
                    break;

                }
            }

            if (k == 0)
                Console.WriteLine("NO");

        }
    }
}

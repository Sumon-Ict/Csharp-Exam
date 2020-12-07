using System;
using System.Collections.Generic;

namespace codeforce_847G
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for(int i=0;i<n;i++)
            {
                string s = Console.ReadLine();
                list.Add(s);

            }

            int maxvalue = 0;
            for(int i=0;i<7;i++)
            {
                int sum = 0;

                for(int j=0;j<n;j++)
                {
                    string str = list[j];
                    sum+= str[i]-'0';
                  
                }
                if (sum > maxvalue)
                    maxvalue = sum;

            }

            Console.WriteLine(maxvalue);



        }
    }
}

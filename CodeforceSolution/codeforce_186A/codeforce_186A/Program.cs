using System;
using System.Linq;

namespace codeforce_186A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();


            if(str1.Length != str2.Length)

                Console.WriteLine("NO");

            else
            {
                int count = 0;

                for(int i=0;i<str1.Length;i++)
                {
                    if (str1[i] != str2[i])
                        count++;

                }

                string str3 = string.Concat(str1.OrderBy(c => c));
                string str4 = string.Concat(str2.OrderBy(c => c));

                if (str3 == str4 && count == 2)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");


            }


        }
    }
}

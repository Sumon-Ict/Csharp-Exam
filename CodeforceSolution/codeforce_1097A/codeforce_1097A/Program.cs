using System;

namespace codeforce_1097A
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = Console.ReadLine();

            string str2 = Console.ReadLine();

            if (str2.Contains(str1[1])||str2.Contains(str1[0]))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");


         
        }
    }
}

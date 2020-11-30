using System;

namespace codeforces_186A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();


            if (str1.Length < 2 || (str1.Length != str2.Length))

                Console.WriteLine("NO");

            else
            {


                str1 = str1.Replace(str1[0], '/').Replace(str1[1], str1[0]).Replace('/', str1[1]);
                     
                if (str1.Equals(str2))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }




            

        }
    }
}

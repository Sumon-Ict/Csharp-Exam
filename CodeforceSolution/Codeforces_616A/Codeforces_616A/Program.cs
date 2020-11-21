using System;

namespace Codeforces_616A
{
    class Program
    {
        static void Main(string[] args)
        {


            
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            string str3 = str1.TrimStart('0');
            string str4 = str2.TrimStart(new char[] { '0' });

            if (str3.Equals(str4))
                Console.WriteLine("=");
            else if (str3.Length > str4.Length)

                Console.WriteLine(">");
            else if (str3.Length < str4.Length)
                Console.WriteLine("<");
            else
            {

                double v = res(str3, str4);

                if (v == 1)
                    Console.WriteLine(">");
                else if (v == 2)
                    Console.WriteLine("<");
            }



        }
        static double res(string s1,string s2)
        {
            double d=0;

            for(int i=0;i<s1.Length;i++)
            {
                double x = char.GetNumericValue(s1[i]);
                double y = char.GetNumericValue(s2[i]);

                if (x == y)
                    continue;
                else if (x > y)
                {
                    d = 1;
                    break;
                }
                    
                else if (x < y)
                {
                    d = 2;
                    break;

                }
                    

            }
            return d;
            

        }
    }
}

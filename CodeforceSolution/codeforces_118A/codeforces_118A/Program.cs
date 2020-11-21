using System;

namespace codeforces_118A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();

            //string str2 = (str1.Trim(new char[] { 'A', 'E', 'I', 'O', 'U', 'Y' }));

             str1= str1.Replace('A', ' ');
            str1 = str1.Replace('E', ' ');
            str1 = str1.Replace('I', ' ');
            str1 = str1.Replace('O', ' ');
            str1 = str1.Replace('U', ' ');
            str1 = str1.Replace('Y', ' ');
            str1 = str1.Replace('a', ' ');
            str1 = str1.Replace('e', ' ');
            str1 = str1.Replace('i', ' ');
            str1 = str1.Replace('o', ' ');
            str1 = str1.Replace('u', ' ');
            str1 = str1.Replace('y', ' ');
           

            string str2 = str1.ToLower();

            for(int i=0;i<str2.Length;i++)
            {
                if(str2[i]!=' ')
                {
                    Console.Write($".{str2[i]}");

                }
            }
            

        }
    }
}

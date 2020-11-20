using System;

namespace Codeforces_43A
{
    class Program
    {
        static void Main(string[] args)
        {

            int team = Convert.ToInt32(Console.ReadLine());

            string str1 = Console.ReadLine();
            string str2=" ";

            int d = 1;

            for(int i=1;i<team;i++)
            {
                string str3 = Console.ReadLine();

               // bool b = str1.Equals(str3);



                if(str1.Equals(str3))
                {
                    d++;
                }

                else
                {
                    str2 = str3;
                }
            }

            int d2 = team - d;

            if (d > d2)
            {
                Console.WriteLine(str1);
            }
            else
                Console.WriteLine(str2);



        }
    }
}

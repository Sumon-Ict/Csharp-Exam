using System;
using System.Collections.Generic;

namespace Exam2Answer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int testcase = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> data = new Dictionary<string, string>();


            for(int i=0;i<testcase;i++)
            {
                string str1 = Console.ReadLine();

                string st2 = str1;

                str1.Remove(3, 7);

                data.Add(str1, st2);

            }

            Console.WriteLine("===========");

            List<string> mylist = new List<string>();



            for(int j=0;j<testcase;j++)
            {
                string value = Console.ReadLine();

                mylist.Add(value);



               
            }

            for (int i = 0; i < testcase; i++)
            {
                string str2 = Console.ReadLine();

                if (data.ContainsKey(str2) == true)

                    Console.WriteLine(data.ContainsValue(str2));
                else

                {
                    Console.WriteLine(str2);
                    Console.WriteLine("confused");


                }








            }


        }
    }
}

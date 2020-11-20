using System;
using System.Collections.Generic;

namespace Exam2Answer
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> mylist = new List<string>();

            Dictionary<string, string> data = new Dictionary<string, string>();


            string s1 = Console.ReadLine();

            string s2 = s1;

            s1.Remove(3, 7);

            Console.WriteLine(s1);
            Console.WriteLine(s2);


            data.Add(s1, s2);


            string str2 = Console.ReadLine();
            str2.Remove(3, 7);

            Console.WriteLine(str2);



            mylist.Add(str2);
            int i = 0;

            string str = mylist[i];

            if (data.ContainsKey(str) == true)
            {
                var result = data.ContainsValue(str);

                Console.WriteLine(result);

               // Console.WriteLine(data.ContainsValue(str));
            }

            else
                Console.WriteLine("no");







            /*

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

                value.Remove(3, 7);


                mylist.Add(value);
               
            }

            for (int i = 0;i<mylist.Count;i++)
            {
                //string str2 = Console.ReadLine();

                string s = mylist[i];



                if (data.ContainsKey(s) == true))

                    Console.WriteLine(data.ContainsValue(s));
                else 

                {
                    Console.WriteLine(s);
                    Console.WriteLine("confused");


                }




            }*/


        }
    }
}

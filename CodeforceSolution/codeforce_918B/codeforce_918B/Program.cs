using System;
using System.Linq;
using System.Collections.Generic;

namespace codeforce_918B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionnay<string,string>
            Dictionary<string, string> datastore = new Dictionary<string, string>();
           

            

            var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = value[0];
            int m = value[1];

            for(int i=0;i<n; i++)
            {
                var str = Console.ReadLine().Split(' ');

                string s1 = str[0];
                string s2 = str[1];
                datastore.Add(s2, s1);

            }

            for(int i=0;i<m;i++)
            {

                var s = Console.ReadLine().Split(' ');

                string str1 = s[0];

                string str2 = s[1];

              string str3=  str2.Remove(str2.Length - 1);

                Console.WriteLine($"{str1} {str2} #{datastore[str3]}");


               // Console.WriteLine($" #{datastore[str3]}");


            }



        }
    }
}

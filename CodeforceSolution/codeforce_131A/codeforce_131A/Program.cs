using System;

namespace codeforce_131A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string uppercase = str.ToUpper();


            string s1 = char.ToLower(uppercase[0]) + uppercase.Substring(1);


           



            if (str.Equals(uppercase))
            {
                string lowercase = str.ToLower();

                Console.WriteLine(lowercase);

            }


            else if (str.Equals(s1))
            {
                string lowercase = str.ToLower();

                string res = char.ToUpper(lowercase[0]) + lowercase.Substring(1);

                Console.WriteLine(res);

            }

            else
                Console.WriteLine(str);


        }
    }
}

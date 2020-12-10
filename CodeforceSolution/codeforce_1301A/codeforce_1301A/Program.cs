using System;

namespace codeforce_1301A
{
    class Program
    {
        static void Main(string[] args)
        {


           
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                string s3 = Console.ReadLine();


                int d = 0;
                int len = s1.Length;


                for (int j = 0; j < len; j++)
                {
                    if (s3[j] != s1[j] && s3[j] != s2[j])
                    {
                        d = 1;
                        break;
                    }


                }


                if (d == 1)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");

            }
               


        }
        
    }
}

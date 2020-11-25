using System;
using System.Collections.Generic;

namespace codeforce_519A
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('Q', 9);
            d.Add('R', 5);
            d.Add('B', 3);
            d.Add('N', 3);
            d.Add('P', 1);
            d.Add('K', 0);
           // d.Add('K', 0);


            d.Add('q', 9);
            d.Add('r', 5);
            d.Add('b', 3);
            d.Add('n', 3);
            d.Add('p', 1);
            d.Add('k', 0);



            int whitesum = 0;
            int blacksum = 0;

            for(int i=0;i<8;i++)
            {
                string str = Console.ReadLine();

                for(int j=0;j<8;j++)
                {
                    if (str[j] >= 'a' && str[j] <= 'z')
                    {
                       // int v = d[str[j]];
                        //blacksum = blacksum + v;
                         blacksum += d[str[j]];
                    }
                    else if (str[j] >= 'A' && str[j] <= 'Z')
                    {
                       // int v = d[str[j]];
                        //whitesum = whitesum + v;
                        whitesum += d[str[j]];
                    }


                }

            }




            if (whitesum > blacksum)
                Console.WriteLine("White");
            else if (blacksum > whitesum)
                Console.WriteLine("Black");
            else
                Console.WriteLine("Draw");


        }
    }
}

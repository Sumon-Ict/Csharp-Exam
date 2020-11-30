using System;
using System.Collections.Generic;
using System.Linq;

namespace codeforce_63A
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoplenumber = Convert.ToInt32(Console.ReadLine());

            List<string> rat = new List<string>();
           
            List<string> womanandchild = new List<string>();
            //List<string> child = new List<string>();

            List<string> man = new List<string>();
            List<string> captain = new List<string>();


            for (int i=0;i<peoplenumber;i++)
            {
                string[] value = Console.ReadLine().Split(' ').ToArray();

                string str1 = value[0];
                string str2 = value[1];

                if (str2.Equals("rat"))
                {
                    rat.Add(str1);
                }

                else if (str2.Equals("woman")||str2.Equals("child"))

                    womanandchild.Add(str1);

                else if (str2.Equals("man"))
                    man.Add(str1);

                else
                    captain.Add(str1);

                    
            }


            foreach (string r in rat)
            {
                Console.WriteLine(r);

            }
           

        foreach(string wc in womanandchild)
            {
                Console.WriteLine(wc);

            }
           

            foreach (string m in man)
            {
                Console.WriteLine(m);

            }
            foreach (string c in captain)
            {
                Console.WriteLine(c);

            }
        }
    }
}

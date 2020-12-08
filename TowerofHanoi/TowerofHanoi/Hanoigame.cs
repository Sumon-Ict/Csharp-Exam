using System;
using System.Collections.Generic;
using System.Text;

namespace TowerofHanoi
{
    class Hanoigame
    {


        public void movecolordice( int d,List<char> From_list, int from_n1, List<char>To_list,int To_n2)
        {
            Console.WriteLine($"try no: {d}");



            Console.WriteLine($"Dice move from {from_n1} to {To_n2}");
            Console.WriteLine();



            char ch =From_list[From_list.Count - 1];
            To_list.Add(ch);

            From_list.RemoveAt(From_list.Count - 1);

        }
        public void presensituation(List<char> list1, List<char> list2, List<char> list3)
        {
          

           

            int maxsizeof_list = Math.Max(list1.Count, Math.Max(list2.Count, list3.Count));


            for(int i=maxsizeof_list-1;i>=0;i--)
            {
                if (i < list1.Count)
                    Console.Write($"{list1[i]}     ");
                if (i >= list1.Count)
                    Console.Write("      ");
                if (i < list2.Count)
                    Console.Write($"{list2[i]}     ");
                if (i >= list2.Count)
                    Console.Write("      ");
                if (i < list3.Count)
                    Console.Write($"{list3[i]}     ");
                if (i >= list3.Count)
                    Console.Write("      ");

                Console.WriteLine();


            }

            Console.WriteLine();


        }
    }
}

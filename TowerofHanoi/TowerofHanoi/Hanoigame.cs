using System;
using System.Collections.Generic;
using System.Text;

namespace TowerofHanoi
{
    class Hanoigame
    {

        // List<char> li = new List<char>();
        //List<char> li2 = new List<char>();



        public void movecolordice(List<char> li, List<char> li2)
        {
            char ch = li[li.Count - 1];
            li2.Add(ch);
            li.RemoveAt(li.Count - 1);

        }
        public void presensituation(int d, List<char> list1, List<char> list2, List<char> list3)
        {
            Console.WriteLine($"try no {d}");

            Console.WriteLine("the color dice at present in rod1 ");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"{list1[i]}   ");

            }

            Console.WriteLine();


            Console.WriteLine("the color dice at present in rod2 ");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine($"{list2[i]}   ");
            }
            Console.WriteLine();

            Console.WriteLine("the coor dice at present in rod3");

            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine($"{list3[i]}   ");

            }
            Console.WriteLine();



        }
    }
}

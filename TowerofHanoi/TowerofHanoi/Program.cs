using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace TowerofHanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Hanoigame hg = new Hanoigame();

            List<char> list1 = new List<char>();
            List<char> list2 = new List<char>();
            List<char> list3 = new List<char>();


            Console.WriteLine("insert the color dice into the rod");

            for(int i=0;i<3;i++)
            {
                char[] colordice = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                 list1.Add(colordice[0]);
                list2.Add(colordice[1]);
                list3.Add(colordice[2]);


            }



            int d = 0;
            int list2count = list2.Count;

            for(int i=1;i<list2count;i++)
            {
                hg.movecolordice(list2, list1);

            }

            char ch2 = list2[0];


            int list1elementnum = list1.Count;

            for(int i=list1elementnum-1;i>=0;i--)
            {
                if (ch2 == list1[i])
                    hg.movecolordice(list1, list2);
                else
                    hg.movecolordice(list1, list3);
            }

            

            int list3elementnum = list3.Count;

            for(int i=list3elementnum-1;i>=0;i--)
            {
                if (ch2 == list3[i])
                    hg.movecolordice(list3, list2);
                else
                    hg.movecolordice(list3, list1);
            }

            

            char ch3 = list1[list1.Count - 1];
            int list1elementnumber = list1.Count;

            for(int i=list1elementnumber-1;i>=0;i--)
            {
                if (ch3 == list1[i])
                    hg.movecolordice(list1, list3);
                else
                    hg.movecolordice(list1, list2);

            }


            Console.WriteLine(list2.Count);



            for(int i=0;i<3;i++)
            {
                hg.movecolordice(list2, list1);

            }

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);

            }

            for(int i=0;i<list3.Count;i++)
            {
                Console.WriteLine(list3[i]);

            }

        }
     

            
    }
}

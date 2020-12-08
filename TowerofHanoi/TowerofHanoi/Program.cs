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



            Console.WriteLine("insert the 9  color dice into the rod with 3 by 3 matrix");


            for(int i=0;i<3;i++)
            {
                char[] colordice = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                 list1.Add(colordice[0]);
                list2.Add(colordice[1]);
                list3.Add(colordice[2]);


            }

            list1.Reverse();
            list2.Reverse();
            list3.Reverse();


            int trynumber = 1;
            int list2count = list2.Count;

            for(int i=1;i<list2count;i++)
            {
                hg.movecolordice(trynumber++,list2,2, list1,1);
                hg.presensituation(list1, list2, list3);

            }

            char colorofdice_rod2 = list2[0];

                while (list1.Contains(colorofdice_rod2))
                {

                    if (colorofdice_rod2 == list1[list1.Count-1])
                    {
                        hg.movecolordice(trynumber++, list1,1, list2,2);
                        hg.presensituation( list1, list2, list3);
                    }
                    else
                    {
                        hg.movecolordice(trynumber++,list1,1, list3,3);
                        hg.presensituation(list1, list2, list3);
                    }
                }




            while (list3.Contains(colorofdice_rod2))
            {
                if (colorofdice_rod2 == list3[list3.Count - 1])
                {
                    hg.movecolordice( trynumber++, list3,3, list2,2);
                    hg.presensituation(list1, list2, list3);
                }
                else
                {
                    hg.movecolordice( trynumber++, list3,3, list1,1);
                    hg.presensituation(list1, list2, list3);
                }
            }



            int list3size = list3.Count;
            for(int i=0;i<list3size;i++)
            {
                hg.movecolordice( trynumber++, list3,3, list1,1);
                hg.presensituation(list1, list2, list3);


            }


            char colorofdice_rod3 = list1[list1.Count - 1];


            while(list1.Contains(colorofdice_rod3))
            {
                if(colorofdice_rod3==list1[list1.Count-1])
                {
                    hg.movecolordice(trynumber++, list1,1, list3,3);
                    hg.presensituation(list1, list2, list3);

                }
                else
                {
                    hg.movecolordice(trynumber++, list1,1, list2,2);
                    hg.presensituation(list1, list2, list3);
                }
            }

            int list2size = list2.Count-3;
            for(int i=0;i<list2size;i++)     //storing the rest of other  color dice in rod_1
            {
                hg.movecolordice( trynumber++, list2,2, list1,1);
                hg.presensituation(list1, list2, list3);

            }


            Console.WriteLine($"success, Total try: {trynumber-1}");

                                  
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace codeforce807A
{
    class Program
    {
        static void Main(string[] args)
        {


            int participatenumber = Convert.ToInt32(Console.ReadLine());

           // int[] arr1 = new int[participatenumber];
            //int[] arr2 = new int[participatenumber];

            List<int> list1 = new List<int>();

            List<int> list2 = new List<int>();




            for (int i = 0; i < participatenumber; i++)
            {


                var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


                int a = value[0];
                int b = value[1];

                list1.Add(a);
                list2.Add(b);

            }

            int[] arr1 = list1.ToArray();
            int[] arr2 = list2.ToArray();


            bool b1 = arr1.SequenceEqual(arr2);

            if (b1 == false)
            {
                Console.WriteLine("rated");

            }
                
            else
            {


               //
                list2.Sort();





                int[] arr3 = list2.ToArray();

                int[] revesorder = arr3.OrderByDescending(x => x).ToArray();


                bool b4 = arr1.SequenceEqual(revesorder);
                if (b4 == true)
                    Console.WriteLine("maybe");
                else
                    Console.WriteLine("unrated");



                /*
                

                int[] arr4 = list2.ToArray();


                bool b2 = arr2.SequenceEqual(arr3);
                bool b3 = arr2.SequenceEqual(arr4);


               // if (b2 == false && b3 == false)
                 //   Console.WriteLine("unrated");
                if (b2 == true || b3 == true)
                    Console.WriteLine("maybe");

                else
                    Console.WriteLine("unrated");

               */



            }













        }
    }
}

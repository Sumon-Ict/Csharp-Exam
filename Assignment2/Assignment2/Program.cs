using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*

            Box<double> box1 = new Box<double>();

            box1.Height =Convert.ToDouble( Console.ReadLine());
            box1.Width = Convert.ToDouble(Console.ReadLine());
            box1.Length = Convert.ToDouble(Console.ReadLine());



            var Area = box1.Height * box1.Width;


            Console.WriteLine($"the area of the box is {Area}");

            var Volume = box1.Height * box1.Width * box1.Length;

            Console.WriteLine($"the volume of the box is {Volume}");




            var storage1 = new Storage<string>(12);

            storage1.insertitem( 1, "Bangla");

            storage1.insertitem(2, "English");
            storage1.insertitem(4, "Mathematics");
            storage1.insertitem(5, "ICT");

            storage1.insertitem(6, "Islamic Studies");

            var subject = storage1.getitem(2);

            Console.WriteLine($"subject of index 2 is {subject}");  



            //generic class of student information 

            StudenInfo<int, string> s1 = new StudenInfo<int, string>();
            s1.roll = Convert.ToInt32(Console.ReadLine());
            s1.name = Console.ReadLine();


            StudenInfo<long, string> s2 = new StudenInfo<long, string>();

            s2.addroll(1234);
            s2.addname("sumon");

          */





            Gmethod G = new Gmethod();
            G.displayInfo<int, string>(23, "Bangla");

            G.displayInfo<string, string>("kajol", "suvo");

            G.display<int, int, string>(78, 8, "Bangla");
            G.display<long, double, bool>(890, 89.90, true);




            Gclass<string> G1 = new Gclass<string>();

            G1.Data = Convert.ToString(Console.ReadLine());

            Gclass<double> G2 = new Gclass<double>();

            G2.Data = Convert.ToDouble(Console.ReadLine());



            int a = 2;
            int b = 4;

            swap<int>( ref a, ref b);

            Console.WriteLine(a);






          static void swap<T>(ref T v, ref T v2)
            {
                T temp;
                temp = v;
                v = v2;
                v2 = temp;
            }


        }
    }
}

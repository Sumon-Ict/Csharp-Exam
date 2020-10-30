using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry g = new Geometry();

            Circle c = new Circle();

            Rectangle r = new Rectangle();
            Triangle t = new Triangle();

            var radius_value = Convert.ToDouble(Console.ReadLine());

            c.Radius = radius_value;



            Console.WriteLine(g.CalculateArea(c.Radius));
           
            Console.WriteLine(g.CalculatePerimeter(c.Radius));



            var height_value = Convert.ToDouble(Console.ReadLine());
            var width_value = Convert.ToDouble(Console.ReadLine());

            r.Height = height_value;
            r.Width = width_value;
            Console.WriteLine(g.CalculateArea(r.Height, r.Width));
            Console.WriteLine(g.CalculatePerimeter(r.Height, r.Width));


            var s1_value= Convert.ToDouble(Console.ReadLine());
            var s2_value= Convert.ToDouble(Console.ReadLine());
            var s3_value= Convert.ToDouble(Console.ReadLine());

            t.Side1 = s1_value;
            t.Side2 = s2_value;
            t.Side2 = s3_value;

            Console.WriteLine(g.CalculateArea(t.Side1,t.Side2,t.Side3));
            Console.WriteLine(g.CalculatePerimeter(t.Side1, t.Side2, t.Side3));



        }
       

    }
}

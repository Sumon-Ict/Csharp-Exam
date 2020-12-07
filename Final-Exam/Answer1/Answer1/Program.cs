using System;
using System.Linq;

namespace Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[,,] cube = new int[20, 20, 20];
           
            for(int i=0;i<20;i++)
            {
                for(int j=0;j<20;j++)
                {
                    for(int k=0;k<20;k++)
                    {
                        cube[i, j, k] = 0;
                    }
                            
                }
                        
            }


            Console.WriteLine("enter the number of item element  and their position");


            int item = int.Parse(Console.ReadLine());

          

            for(int i=0;i<item;i++)
            {
                int itemvalue = int.Parse(Console.ReadLine());

                var position = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int x = position[0];
                int y = position[1];
                int z = position[2];


                cube[x, y, z] = cube[x, y, z] + itemvalue;


            }

            int maxitem = 0;

            int position_x1 = 100;
            int position_y1 = 100;

            for(int i=0;i<20;i++)
            {
                for(int j=0;j<20;j++)
                {
                    for(int k=0;k<20;k++)
                    {
                        if(cube[i,j,k]>maxitem)
                        {
                            position_x1 = i;
                            position_y1 = j;

                        }
                    }
                }
            }



            Console.WriteLine($"the cordianate of (x,y) is ({position_x1},{position_y1})");



        }
    }
}

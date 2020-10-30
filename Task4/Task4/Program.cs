using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {


            var dimension = Convert.ToInt32(Console.ReadLine());


            int[,] array = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());   //insert value in array



                }
            }

            var d = dimension - 1;

            var sum = 0;
            for (int i = 0; i < dimension; i++)
            {
                sum = sum + array[i,i]+ array[i, d];
                d--;

            }


            if(dimension%2==1)
            {
                var d1 = (dimension - 1) / 2;

                sum = sum - array[d1, d1];

            }

            Console.WriteLine(sum);

        }
    }
}

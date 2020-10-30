using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {


           
            string value = Console.ReadLine();

           

            string[] array = value.Split(' ');

            int[] intarray = new int[array.Length];

            for(int i=0;i<array.Length;i++)
            {
                intarray[i] = Convert.ToInt32(array[i]);

            }

            ///reverse the order of the number 
            for(int j=intarray.Length-1;j>=0;j--)
            {
               
                    Console.WriteLine(intarray[j]);
             

            }

            int oddarraylen = intarray.Length + 1 / 2;
            int evenarraylen = intarray.Length + 1 / 2;

            int[] oddnumber = new int[oddarraylen];
            int[] evennumber = new int[evenarraylen];

            int p = 0;
            int q = 0;

            //separare the odd and even number

            for(int k=0;k<intarray.Length;k++)
            {
                if (k % 2 == 0)
                    oddnumber[p++] = intarray[k];
                else
                    evennumber[q++] = intarray[k];



            }

            //print the odd numbers 
            for(int i=0;i<oddnumber.Length;i++)
            {
                Console.WriteLine(oddnumber[i]);


            }
           
            //print the even number 

            for(int j=0;j<evennumber.Length;j++)
            {

                Console.WriteLine(evennumber[j]);

            }

            //reverse the even position number 
            for(int j=evennumber.Length-1;j>=0;j--)
            {
                Console.WriteLine(evennumber[j]);

            }

            //revers the odd position number 

            for(int j=oddnumber.Length-1;j>=0;j--)
            {

                Console.WriteLine(oddnumber[j]);
            }

            for(int k=0;k<oddnumber.Length;k++)
            {
                Console.WriteLine($"{oddnumber[k]} ,");

            }

            for(int c=0;c<evennumber.Length;c++)
            {
                Console.WriteLine($" {evennumber[c]} ,");

            }



        }
    }
}

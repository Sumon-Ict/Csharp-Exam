using System;

namespace codeforce_711A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());


            string[] array = new string[n + 1];
            int d = 0;
            int k=-1;



            for(int i=0;i<n;i++)
            {
                array[i] = Console.ReadLine();
            }

            
            for(int i=0;i<n;i++)
            {
                string str = array[i];

                if(str[0]=='O'&&str[1]=='O'||str[3]=='O'&&str[4]=='O')
                {
                    k = i;
                    d = 1;
                    break;


                }    
            }

            if(d==0)
            {
                Console.WriteLine("NO");

            }

            else
            {
                Console.WriteLine("YES");
                for(int i=0;i<n;i++)
                {
                    if (k == i)
                    {
                        string str = array[k];

                        if (str[0] == 'O' && str[1] == 'O')
                            Console.WriteLine($"++{str[2]}{str[3]}{str[4]}");
                        else
                            Console.WriteLine($"{str[0]}{str[1]}{str[2]}++");

                    }
                    else
                        Console.WriteLine(array[i]);

                }
            }


        }
    }
}

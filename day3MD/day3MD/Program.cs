using System;

namespace day3MD
{
    class Program
    {
        static void Main(string[] args)
        {
            zvaigznites2();
            whileuzd();
        }


        static void zvaigznites2()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }


            for (int i = 4; i >= 1; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static void whileuzd()
            {
            Console.WriteLine("Ievadiet skaitli!");
            String input = Console.ReadLine();
            Convert.ToInt32(input);
            
            while (input != "break")
                {


                    if (input == "break")
                        {
                            break;
                        } 
                    else
                        {
                            whileuzd();
                        }
                        //while uzdevuma pamats varētu būt šāds 

                }
        }
    }
}

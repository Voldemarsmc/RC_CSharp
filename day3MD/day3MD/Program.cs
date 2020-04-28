using System;

namespace day3MD
{
    class Program
    {
        static void Main(string[] args)
        {
            zvaigznites2();
            whiletask();
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


            for (int i = 3; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
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


        static void whiletask()
        {
            String choice = " ";
            int biggest = Int32.MinValue;
            int smallest = Int32.MaxValue;
            while (choice != "n")
            {
                Console.WriteLine("ievadiet skaitli");
                int sk = Convert.ToInt32(Console.ReadLine());
                if(sk > biggest)
                {
                    biggest = sk;
                } 
                if(sk < smallest)
                {
                    smallest = sk;

                }
                Console.WriteLine("vai vēlaties turpināt? ne?");
                choice = Console.ReadLine();
                choice = choice.ToLower();
                Console.WriteLine(choice);            
            }
            Console.WriteLine("lielakais" + biggest);
            Console.WriteLine("mazakais" + smallest);
        }

        static void whileOption2()
        {

        }
    }
}

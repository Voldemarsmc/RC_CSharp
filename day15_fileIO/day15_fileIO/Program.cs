using System;

namespace day15_fileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. rakstīt");
            Console.WriteLine("2. lasit");
            Console.WriteLine("0. iziet");

            String choice = "";
            while(choice != "0")
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Example.write();
                        break;

                    case "2":
                        Example.Read();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("nepareiza ievade");
                        break;
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace day17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> listofvalues = new List<String>();

            String choice = "";
            while (choice != 0)
            {
                Console.WriteLine("1 - pievienot sutdentu sarakstam");
                Console.WriteLine("2 - nolasit sarakstu");
                Console.WriteLine("3 - saglabāt sarakstu failā");
                Console.WriteLine("4 - dzest objektu no saraksta");
                Console.WriteLine("5 - rediģēt objektu no saraksta");
                Console.WriteLine("6 - izvadit studentus pēc kursa");

                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":

                }
                private void list()
                {
                    

                   
                    
                        Console.WriteLine("ievadiet studentu");
                    listofvalues.Add(Console.ReadLine());
                        Console.WriteLine("vai turpinat?");
                        String choice = Console.ReadLine();

                        if (choice == "n")
                        {
                            break;
                        }
                    
                }
                private void Delete()
                {
                    for(int i = 0; i < listofvalues.Count; i++)
                    {
                        Console.WriteLine(i + "- " + listofvalues[i]);

                    }
                }
                
            }
        }
    }
}

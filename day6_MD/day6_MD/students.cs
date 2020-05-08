using System;
using System.Collections.Generic;
using System.Text;

namespace day6_MD
{
    class students
    {
        public static void print()
        {
            String vards, uzvards;
            int kurss;
            Console.WriteLine("ievadiet studenta vārdu");
            vards = Console.ReadLine();
            Console.WriteLine("ievadiet studenta uzvārdu");
            uzvards = Console.ReadLine();
            Console.WriteLine("ievadiet studenta kursu");
            kurss = Convert.ToInt32(Console.ReadLine());
            
            if (kurss <= 3 && kurss >= 1)
            {
                Console.WriteLine(vards + " " + uzvards + " " + kurss + "kurss");
            }
                
            else
            {
                Console.WriteLine("dati ir ievadīti nepareizi!");
            }

            
        }
    }
}

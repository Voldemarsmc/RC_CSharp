using System;

namespace day6_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //students.print();
            
            rekini();
        }

        static void rekini()
        {
            Console.WriteLine("ievadiet pirmo skaitli");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("izvēlieties darbību");
            String z = Console.ReadLine();

            Console.WriteLine("ievadiet otro skaitli");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(kalkulators.aprekini(x, z, y));
            


        }



    }
}

using System;

namespace day11_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer("Janis", 22, 1000.0, "C#");
            p1.Work();

            Manager m = new Manager("Martins", 27, 2000.0, 2);
            m.Work();



            m.Test();

            p1.Test();
        }


        static Programmer GetProgrammer()
        {
            Console.WriteLine("ievadeit vardu");
            String name = Console.ReadLine();

            Console.WriteLine("ievadiet vecumu");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ievadiet menesa algu");
            double monthlySalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ievadiet programmetaja milako valodu");
            String lang = Console.ReadLine();

            Programmer pr = new Programmer(name, age, monthlySalary, lang);
            return pr;
        }
    }
}
 
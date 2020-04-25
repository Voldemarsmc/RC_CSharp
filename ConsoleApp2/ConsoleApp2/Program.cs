using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadiet skaitli");
            String skaitlis = Console.ReadLine();
            int result = Int32.Parse(skaitlis);

            Console.WriteLine(skaitlis.GetType() + " " + skaitlis);
            Console.WriteLine(result.GetType() + " " + result);
        } 
    }
}

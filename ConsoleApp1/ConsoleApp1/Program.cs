using System;

namespace ConsoleApp1
{
    public class Kata
    {
        public static double Calculator(double a, double b, char op)
        {
            Console.WriteLine("ievadiet skaitli");
            String skaitlis = Console.ReadLine();
            int result = Int32.Parse(skaitlis);
            Console.WriteLine(result);
        }
    }
}

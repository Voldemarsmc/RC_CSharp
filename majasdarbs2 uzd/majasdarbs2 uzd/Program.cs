using System;

namespace majasdarbs2_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("lūdzu ievadiet savu vārdu :");
            String ievade = Console.ReadLine();
            String combined = "sveiki, " + ievade;
            Console.WriteLine(combined);


            Console.WriteLine("ievadīt 3 simbolu virknes");
            Console.WriteLine("lūdzu ievadiet pirmo virkni :");
            String a = Console.ReadLine();
            Console.WriteLine("lūdzu ievadiet otro virkni :");
            String b = Console.ReadLine();
            Console.WriteLine("lūdzu ievadiet trešo virkni :");
            String c = Console.ReadLine();

            string kopa = a + " " + b + " " + c;
            Console.WriteLine(kopa);
        }
            
    }
}

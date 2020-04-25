using System;

namespace Day1_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int - vesels skaitlis
            //float ,  double skaitli ar komatu
            //char viens simbols
            //string simbolu virkne
            //bool true or false


            int a;
            a = 7;
            int c;
            c = 5;

            int result = a + c;

            Console.WriteLine(c + result);


            string b;
            b = "54657687980";
            Console.WriteLine(b);
            a = 99;

            Console.WriteLine("ievadiet simbolu virkni!");
            string ievade = Console.ReadLine();
            Console.WriteLine(ievade);
            string combined = ievade + ", hello world";
            Console.WriteLine(combined);

        }
    }
}

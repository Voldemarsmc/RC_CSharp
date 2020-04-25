using System;

namespace majasdarbs
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("4. uzdevums");
            int a = 3;
            int b = 9;
            int temp;

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = " +a);
            Console.WriteLine("b = " +b);
        }
    }
}

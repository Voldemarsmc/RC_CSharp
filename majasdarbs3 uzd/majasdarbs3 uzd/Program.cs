using System;

namespace majasdarbs3_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. uzdevums");

            int a, b, c;
            Console.WriteLine("ievadiet a vērtību :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ievadiet b vērtību :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ievadiet c vērtību :");
            c = int.Parse(Console.ReadLine());

            if (c < a & b < a)
            {
                Console.WriteLine("augstākā vērtība ir a : " + a);
            }
            else if (c < b & a < b)
            {
                Console.WriteLine("augstākā vērtība ir b : " + b);
            }
            else if (b < c & a < c)
            {
                Console.WriteLine("augstākā vērtība ir c : " + c);
            }
            else
            {
                Console.WriteLine("something went wrong");
            }
        }
    }
}

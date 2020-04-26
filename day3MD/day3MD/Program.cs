using System;

namespace day3MD
{
    class Program
    {
        static void Main(string[] args)
        {
            zvaigznites2();
        }


        static void zvaigznites2()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }


            for (int i = 4; i >= 1; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

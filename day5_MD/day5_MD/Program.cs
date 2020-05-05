using System;

namespace day5_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3();

        }

        static void Task3()
        {
            int[] a = new int[10];
            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1, 11);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine("Ievadiet skaitli, ko meklet!");
            int sk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indeksi: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (sk == a[i])
                {
                    Console.Write(i + " ");
                    break;
                }
                else if (sk != a[i])
                {
                    Console.WriteLine("skaitlis neatrodas masīvā");
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}

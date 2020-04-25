using System;

namespace majasdarbs_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadiet pirmo skaitli");
            String d = Console.ReadLine();
            Console.WriteLine("ievadiet otro skaitli");
            String e = Console.ReadLine();
            int x = Convert.ToInt32(d);
            int y = Convert.ToInt32(e);
            Console.WriteLine("lielākais skaitlis ir: ");
            InputNumber(x, y);
            
            Console.WriteLine("ievadiet skaitli");
            String r = Console.ReadLine();
            int z = Convert.ToInt32(r);
            VaiDalas(z);

            //definējot int tieši, meta kaut kādu erroru, tāpēc ievadīju kā string un tad pārkonvertēju uz int un tālāk ar to nebija problēma
        }
        static int InputNumber(int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine(a);
            } else if(b > a)
            {
                Console.WriteLine(b);
            } else
            {
                Console.WriteLine("something went wrong");
            }
            return 0;
        }

        static int VaiDalas(int s)
        {
            if (s % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            return 0;
        }

    }
}

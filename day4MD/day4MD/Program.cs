using System;

namespace day4MD
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumber();
            //task2(2, 3);
            //piramida();
        }
        static void RandomNumber()
        {
            Random random = new Random();
            
            int atbilde = random.Next(1, 10);
            
            Console.WriteLine("skaitlis kas jāuzmin ir intervālā no 1 - 10. vai zini kurš tas ir?");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ievadiet skaitli");
                int minejums = Convert.ToInt32(Console.Read());

                if (minejums != atbilde)
                {
                    Console.WriteLine("meģini vēlreiz!");
                    minejums = Convert.ToInt32(Console.Read());
                } 
                else if (minejums == atbilde)
                {

                    Console.WriteLine("jauki! atbilde bija " + atbilde);
                }

            }
        }
        
       
        
        
        static void task2(int a, int b)
        {
            double first = Math.Pow(a, b);
            Console.WriteLine(first);
        }
       
        
        
        
        
        
        static void piramida()
        {
            int i, j, t = 1;

            for (i = 1; i <= 4; i++)
            {

                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                
            }
        }
    }
}

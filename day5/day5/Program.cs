using System;

namespace day5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArraySample();
            //arrayuzd();
            //task2();
            task3();
        }

        static void ArraySample()
        {
            int[] a = new int[5];
            a[0] = 1;
            a[1] = 5;
            a[2] = 8;
            a[3] = 7;
            a[4] = 99;

            Console.WriteLine(a[0]);
            int sum = a[0] + a[4];
            Console.WriteLine(sum);


            for(int i = 0; i < 5; i++)
            {
                Console.Write(a[i] + " ");
            }
            
        }

        
        
        
        
        
        
        
        
        
        
        
        
        static void arrayuzd()
        {

            
            int sum = 0;
            int[] b = new int[5];
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("ievadiet skaitli");
                b[i] = Convert.ToInt32(Console.ReadLine());
                sum += b[i];

                
            }

            Console.WriteLine(sum);
        }












        static void task2()
        {
            double sum = 0;
            double[] c = { 1, 2, 3, 4, 6, 7 };
            for(int i = 0; i < c.Length; i++)
            {
                sum += c[i];
            }
            Console.WriteLine(sum / c.Length);
        }





        static void task3()
        {

            int[] a = new int[10];
            Random randNum = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(1, 11);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("ievadiet skaitli");
            int sk = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                if(sk == a[i])
                {
                    Console.Write(i + " ");
                }

            }
        }


    }
}

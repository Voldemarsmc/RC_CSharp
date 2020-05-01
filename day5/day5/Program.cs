using System;

namespace day5
{
    class Program
    {
        static void Main(string[] args)
        {
           // ArraySample();
            arrayuzd();
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

            
            int x, sum = 0;
            int[] b = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ievadiet skaitli");
                b[i] = Convert.ToInt32(Console.ReadLine());
                sum += b[i];


            }

            Console.WriteLine(sum);
        }
    }
}

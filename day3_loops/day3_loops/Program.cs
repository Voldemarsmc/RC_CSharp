using System;

namespace day3_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            uzdDay3();
        }
        static void uzdDay3()
        {



   int i, j, n;
   

            n = 7;   
   for(i = 0; i < n; i++)
   {

     for(j = 1 ; j <= 2 * i - 1; j++)
  
                
                for (j = 1 ; j <= 2 * i + 1; j++)
                    Console.Write("*");
                Console.Write("\n");
   }
            for (i = 10; i < n; i++)
            {



                for (j = 3; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");

            }




            }
    }
}

using System;

namespace day10_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] a = new int [8];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
            }
            int N = a.Length;

            int up = 1;   // means sort in ascending order  
            GFG.sort(a, N, up);

            Console.Write("Sorted array: \n");
            for (int i = 0; i < N; i++)
                Console.Write(a[i] + " ");
        }
    }



       // static void BubbleSort()
       // {
        //    int[] arr = new int[10];

         //   fillArr(arr);
         //   PrintArr(arr);
    //
         //   for(int i = 0; i < arr.Length - 1; i++)
          //  {
          //      for(int j = 0; j < arr.Length - 1 - i; j++)
          //      {
             //       if(arr[j] > arr[j + 1])
             //       {
             //           int temp = arr[j];
             //           arr[j] = arr[j + 1];
             //           arr[j + 1] = temp;
             //       }
            //    }
           // }

           // PrintArr(arr);
            
        //}

       // static void fillArr(int[] arr)
       // {
         //   Random random = new Random();
            
          //  for(int i = 0; i < arr.Length; i++)
          ///  {
          //      arr[i] = random.Next(41);
          //  }
        //}

        //static void PrintArr(int[] arr)
        //{
            
       // }
    //}
}

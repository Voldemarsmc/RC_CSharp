using System;

namespace day10_MD
{
    class Program
    {
        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            CycleSort();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            bitcoin();
            watch.Stop();
            var elapsedMs2 = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs2);

            Console.WriteLine();
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));

        }





        static void CycleSort()
        {
            int[] arr = new int[10000];
            int n = arr.Length;

            
            GFG2.cycleSort(arr, n);

            Console.Write("After sort : ");
            for (int i = 0; i < n; i++) ;
                
        }




        static void bitcoin()
        {
            int[] a = new int[10000];
            int N = a.Length;

            int up = 1;   
            GFG.sort(a, N, up);
            Console.WriteLine();
            Console.Write("Sorted array: ");
            for (int i = 0; i < N; i++) ;
               
        }
    
    
    }
}

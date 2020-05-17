using System;
using System.Collections.Generic;
using System.Text;

namespace day10_MD
{
    class GFG
    {
       
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public static void compAndSwap(int[] a, int i, int j, int dir)
        {

            int k;
            if ((a[i] > a[j]))
                k = 1;
            else
                k = 0;
            if (dir == k)
                Swap(ref a[i], ref a[j]);
        }


        public static void bitonicMerge(int[] a, int low, int cnt, int dir)
        {
            if (cnt > 1)
            {
                int k = cnt / 2;
                for (int i = low; i < low + k; i++)
                    compAndSwap(a, i, i + k, dir);
                bitonicMerge(a, low, k, dir);
                bitonicMerge(a, low + k, k, dir);
            }
        }


        public static void bitonicSort(int[] a, int low, int cnt, int dir)
        {
            if (cnt > 1)
            {
                int k = cnt / 2;

                 
                bitonicSort(a, low, k, 1);

                 
                bitonicSort(a, low + k, k, 0);

               
                bitonicMerge(a, low, cnt, dir);
            }
        }


        public static void sort(int[] a, int N, int up)
        {
            bitonicSort(a, 0, N, up);
        }

    }
}

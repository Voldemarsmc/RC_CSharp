using System;
using System.Collections.Generic;
using System.Text;

namespace day_9
{
    class tasks
    {
        public bool CompareLists(List<int> a, List<int> b)
        {
            if(a.Count != b.Count)
            {
                return false;
            }

            for(int i = 0; i < a.Count; i++)
            {
                if(a[i] != b[i])
                {
                    return false;
                }
            }

            return false;
        }
        public void ReverseArray()
        {
            int[] a = new int[5];
            int[] b = new int[5];
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("ievadiet skaitli");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[a.Length - 1 - i];

                Console.Write(b[i] + " ");
            }
        }
    }
}

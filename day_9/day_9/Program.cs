using System;
using System.Collections.Generic;
     

namespace day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                a.Add(i);
            }

            List<int> b = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                b.Add(i);
            }
            tasks t = new tasks();
            Console.WriteLine(t.CompareLists(a, b));
        }


    }
}

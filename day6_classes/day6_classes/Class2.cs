using System;
using System.Collections.Generic;
using System.Text;

namespace day6_classes
{
    class Class2
    {
        public static void piramida(int n)
        {

            String a = "";

            for (int i = 0; i < n; i++)
            {
                a = a + "*";
                Console.WriteLine(a);
            }

        }

    }
}



using System;
using System.Collections.Generic;
using System.Text;

namespace day6_classes
{
    class Class2
    {
        private static int X = 0;
        private static int Y = 0;




        public static void setA(int localX)
        {
            x = localX;
        }

        public static void setB(int localY)
        {
            y = localY;
        }






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



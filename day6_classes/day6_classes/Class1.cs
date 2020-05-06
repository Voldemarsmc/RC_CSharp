using System;
using System.Collections.Generic;
using System.Text;

namespace day6_classes
{
    public class Class1
    {

        private static int a = 0;
        private static int b = 0;

        public static void Test()
        {
            Console.WriteLine("šī ir testa metode");
            PrivateTest();
            a = 3;
            b = a + 8;
        }


        private static void PrivateTest()
        {
            Console.WriteLine("private tests");
        }
        


        public static int ReturnPublic()
        {
            return 3 + 2;
        }

        public static void ParammPublic(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a + Class1.a);


        }

    }


    
}

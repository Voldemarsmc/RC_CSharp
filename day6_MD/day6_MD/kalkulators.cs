using System;
using System.Collections.Generic;
using System.Text;

namespace day6_MD
{
    class kalkulators
    {

        public static int aprekini(int a, String darbiba, int b)
        {
            int result = 0;
            switch (darbiba)
            {
                case "+":
                    {
                        result = Addition(a, b);
                        break;
                    }
                case "-":
                    {
                        result = Subtraction(a, b);
                        break;
                    }
                case "*":
                    {
                        result = Multiplication(a, b);
                        break;
                    }
                case "/":
                    {
                        result = Division(a, b);
                        break;
                    }
                default:
                    Console.WriteLine("kaut kas nogāja greizi, mēģini vēlreiz!");
                    break;
            }
            Console.WriteLine("rezultāts ir  {0}", result);
            Console.ReadKey();
            return  result;

        }
        public static int Addition(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Subtraction(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public static int Multiplication(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public static int Division(int a, int b)
        {
            int result = a / b;
            return result;
        }









    }



    
}

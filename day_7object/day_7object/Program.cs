using System;
using System.Collections.Generic;

namespace day_7object
{
    class Program
    {
        static void Main(string[] args)
        {
            // trijsturis tr1 = new trijsturis(1, 2, 3);

            //tr1.print();

            //trijsturis tr2 = new trijsturis(4, 5, 6);

            // tr2.print();

            // Student st1 = new Student("janis", "berzins", 3);
            // Student st2 = new Student("liene", "kalnina", 2);
            // st1.print();
            // st2.print();

            //Student[] students = new Student[5];
            //students[0] = new Student("janis", "berzins", 3);

            //List<Student> st = new List<Student>();
            //st.Add(new Student("juris", "abele", 2));


            //for (int i = 0; i < st.Count; i++)
            // {
            //   st[i].print();
            //}



            //whileList();




            /* List<String> a = new List<String>();
             a.Add("aa");
             a.Add("bb");
             a.RemoveAt(0);

             for ( int i = 0; i < a.Count; i++)
             {

             }

             foreach(String b in a)
             {
                 Console.WriteLine(b);
             }

     */

            lists2();


           // taskList();


        }


        static void lists2()
        {
            Random random = new Random();
            List<int> nummbers = new List<int>();
            for(int i = 0; i < 0; i++)
            {
                nummbers.Add(random.Next(100));
            }
            String choise = "";
            while (choise != "0")
            {
                Console.WriteLine("1. izvadīt sarakstu");
                Console.WriteLine("2. dzest");
                Console.WriteLine("0. iziet");

                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        foreach(int a in nummbers)
                        {
                            Console.WriteLine(a);
                        }
                        break;
                    case "2":
                        Console.WriteLine("kuru dzēst");
                        int toDelete = Convert.ToInt32(Console.ReadLine());
                        nummbers.RemoveAt(toDelete);
                        break;
                    case "0":

                }
            }

        }





        /* static void taskList()
         {
             List<String> a = new <String> ();
             while (true)
             {
                 Console.WriteLine("ievadiet elementu");
                 a.Add(Console.ReadLine());
                 Console.WriteLine("vai turpināt?");
                 String choise = Console.ReadLine();

                 if(choise == "n")
                 {
                     break;
                 }


             }
             foreach (String str in a)
             {
                 Console.Write(str + " ")
             }
             Console.WriteLine();
         }*/

        /* static void whileList()
         {
             Console.WriteLine("ievadīt elementu");
             String input = Console.ReadLine();
             while (input != "n")
             {
                 Console.WriteLine("ievadīt elementu");
                 input = Console.ReadLine();
                 if(input == "n")
                 {
                     List<String> a = new List<String>();
                     a.Add(Console.ReadLine());

                     foreach(String b in a)
                     {
                         Console.WriteLine(b);
                     }
                 }
             }
         }*/






        /* static void sample()
         {
             shape piec1 = new shape(1, 2, 3, 4, 5);
             piec1.print();
             shape piec2 = new shape(4, 6, 2, 3, 9);
             piec2.perimeter();
         }*/
    }
}

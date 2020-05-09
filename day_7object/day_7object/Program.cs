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



            shape piec1 = new shape(1, 2, 3, 4, 5);
            piec1.print();
            shape piec2 = new shape(4, 6, 2, 3, 9);
            piec2.perimeter();
        }
    }
}

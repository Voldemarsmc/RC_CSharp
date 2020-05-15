using System;
using System.Collections.Generic;
namespace day9_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            example1();
        }
        static void example1()
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Janis", "Berzins", 1));
            listOfStudents.Add(new Student("Juris", "Abele", 2));
            listOfStudents.Add(new Student("Kristaps", "Kalejs", 3));


            for (int i = 0; i < listOfStudents.Count; i++)
            {

                listOfStudents[i].setCourse(1);
                listOfStudents[i].print();
            }

            foreach (Student st in listOfStudents)
            {
                st.print();
            }
        }
    }
}

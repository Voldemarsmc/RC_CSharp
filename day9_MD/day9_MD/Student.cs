using System;
using System.Collections.Generic;
using System.Text;

namespace day9_MD
{
    class Student
    {
        private List<String> listOfValues;
        public void Task1()
        {
            //Mes izvadam menu
            //un dodam cilvekam iespeju izveleties
            //1. Izvadit
            //2. Pievienot
            //3. Dzest
            //0. Iziet
            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("1. Izvadit");
                Console.WriteLine("2. Pievienot");
                Console.WriteLine("3. Dzest");
                Console.WriteLine("0. Iziet");

                Console.WriteLine("Izvelaties: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Print();
                        break;
                    case "2":
                        Add();
                        break;
                    case "0":
                        Console.WriteLine("Bye, bye...");
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }
        private void Print()
        {
            //1. izvadit

            
            if (listOfValues.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss");
            }
            else
            {
                foreach (String el in listOfValues)
                {
                    Console.WriteLine(el);
                }
            }

            Console.WriteLine("---------------");
        }






        public Student(String name, String surname, int course)
        {
            this.name = name;
            this.surname = surname;
            setCourse(course);
        }

        private String name;
        private String surname;
        private int course;

        public void setName(String name)
        {
            this.name = name;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setCourse(int course)
        {
            if (course > 3)
            {
                course = 3;
            }

            if (course < 1)
            {
                course = 1;
            }

            this.course = course;
        }

        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(course);
        }

        public String getName()
        {
            return name;
        }

        public String getSurname()
        {
            return surname;
        }

        public int getCourse()
        {
            return course;
        }
    }
}

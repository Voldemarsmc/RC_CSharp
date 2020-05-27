using System;
using System.Collections.Generic;
using System.Text;

namespace day11_MD
{
    class Programmer : Employee
    {
        public String favoriteLang;

        public Programmer(String name, int age, double monthlySalary, String favoriteLang)
        {
            this.name = name;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.favoriteLang = favoriteLang;
        }

        public override void Work()
        {
            Console.WriteLine("Programmer is managing.");
        }

        public override void Print()
        {
            Console.WriteLine(name + " " + favoriteLang);
        }
    }
}

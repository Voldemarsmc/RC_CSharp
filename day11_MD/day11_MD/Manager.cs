using System;
using System.Collections.Generic;
using System.Text;

namespace day11_MD
{
    class Manager : Employee
    {
        public int yearsOfExp;

        public Manager(String name, int age, double monthlySalary, int yearsOfExp)
        {
            this.name = name;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.yearsOfExp = yearsOfExp;
        }

        public override void Work()
        {
            Console.WriteLine("Manager is managing.");
        }

        public override void Print()
        {
            Console.WriteLine(name + " " + yearsOfExp);
        }
    }
}

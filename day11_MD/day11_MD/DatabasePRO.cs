using System;
using System.Collections.Generic;
using System.Text;

namespace day11_MD
{
    class DatabasePRO : Employee
    {
        public String databaseTool;

        public DatabasePRO(String name, int age, double monthlySalary, String databaseTool)
        {
            this.name = name;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.databaseTool = databaseTool;
        }

        public override void Work()
        {
            Console.WriteLine("Database admin is databasing...");
        }

        public override void Print()
        {
            Console.WriteLine(name + " " + databaseTool);
        }
    }
}

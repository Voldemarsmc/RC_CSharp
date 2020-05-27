using System;
using System.Collections.Generic;
using System.Text;

namespace day11_MD
{
    abstract class Employee
    {
        public String name;
        public int age;
        public double monthlySalary;

        public virtual void Work()
        {
            Console.WriteLine("Employee is working..");
        }

        public void Test()
        {
            Print();
            Console.WriteLine("test done");
        }
        public abstract void Print();
    }
}

using System;

namespace day_6MD2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadiet vardu!");
            student.setName(Console.ReadLine());

            Console.WriteLine("ievadiet uzvārdu!")
            student.setSurname(Console.ReadLine());

            Console.WriteLine("ievadiet kursu!");
            try
            {
                student.setcourse(Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("nepareiza ievade");
            }

            student
        }
    }
}

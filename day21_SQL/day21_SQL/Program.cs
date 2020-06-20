using System;

namespace day21_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection con = new DBConnection();
            con.Connect();
            con.GetStudents();
            //con.AddStudents();
            con.DelStudent();
        }
    }
}

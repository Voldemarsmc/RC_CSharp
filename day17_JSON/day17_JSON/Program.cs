using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace day17_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<Car> cars = new List<Car>();

            //Car c = new Car("bmw", "m3", 2);
            //cars.Add(c);
           // cars.Add(new Car("opel", "astra", 4));
           // cars.Add(new Car("audi", "a4", 4));
           // String json = JsonConvert.SerializeObject(cars, Formatting.Indented);     
            //Console.WriteLine(json);

            //List<Car> cars2 = JsonConvert.DeserializeObject<List<Car>>(json);
            //Console.WriteLine(cars2[0].brand + " " + cars2[0].model);


            List<Student> listOfStudents = new List<Student>();
            Student d = new Student("andrejs", "rudzīts", 2);
            listOfStudents.Add(d);
            listOfStudents.Add(new Student("raimonds", "kocins", 1));
            listOfStudents.Add(new Student("artis", "ozols", 2));
            listOfStudents.Add(new Student("arturs", "vētra", 3));
            String json = JsonConvert.SerializeObject(listOfStudents, Formatting.Indented);
            Console.WriteLine(json);


           // List<Student> listOfStudents2 = new List<Student>();
            //Console.WriteLine(listOfStudents2[0].getName +  "  " + listOfStudents2[0].getSurname + " " + listOfStudents2[0].getCourse);





        }

        public static void Write(String json)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\voldemars\\Desktop\\test2\\test.json");
                sw.Write(json);
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Failed");
            }
        }
    }
}

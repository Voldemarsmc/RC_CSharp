using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace day15_fileIO
{
    class Example
    {
        public static void Read()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\voldemars\\Desktop\\kodi.txt");

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine("neizdevas atrast failu");
            }
        }
        public static void write()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\voldemars\\Desktop\\bbb.txt");

                sw.WriteLine("hello");
            }
            catch
            {
                Console.WriteLine("neizdevas ierakstit faila");
            }
        }
    }
}

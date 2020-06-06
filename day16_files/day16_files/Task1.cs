using System;
using System.Collections.Generic;
using System.Text;

namespace day16_files
{
    class Task1
    {
        public static void Run()
        {
            String studentInfo = "Juris,Abolins,3";

            String[] elements = studentInfo.Split(',');
            //Ar String.Split parveidot uz 3 vērtībām
            //Un tad no šiem 3 stringiem uztasīt jaunu studenta klases objektu student1;

            //Student student1 = new Student( info no splitota stringa  );

            Student student1 = new Student(elements[0], elements[1], Convert.ToInt32(elements[2]));

            student1.print();
        }
    }
}

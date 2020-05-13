using System;
using System.Collections.Generic;
using System.Text;

namespace day_7object
{
    class shape
    {
        public int mala1;
        public int mala2;
        public int mala3;
        public int mala4;
        public int mala5;
         

        public shape(int mala1, int mala2, int mala3, int mala4, int mala5)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
            this.mala4 = mala4;
            this.mala5 = mala5;
        }
        public void print()
        {
            Console.WriteLine(mala1 + " " + mala2 + " " + mala3 + " " + mala4 + " " + mala5);
        }
        public double perimeter()
        {
            Console.WriteLine(mala1 + mala2 + mala3 + mala4 + mala5);
            return 0;
        }
        
    }
}

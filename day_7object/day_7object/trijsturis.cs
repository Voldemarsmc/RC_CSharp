using System;
using System.Collections.Generic;
using System.Text;

namespace day_7object
{
    public class trijsturis
    {
        public int mala1;
        public int mala2;
        public int mala3;
        public trijsturis(int mala1, int mala2, int mala3)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
        }

        public trijsturis(int mala1, int mala2)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
        }
        public void print()
        {
            Console.WriteLine(mala1 + " " + mala2 + " " + mala3);
        }
    }
}

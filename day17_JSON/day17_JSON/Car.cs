using System;
using System.Collections.Generic;
using System.Text;

namespace day17_JSON
{
    class Car
    {
        public String brand;
        public String model;
        public int doorCount;

        public Car(String brand, String model, int doorcount)
        {
            this.brand = brand;
            this.model = model;
            this.doorCount = doorcount;
        }
    }
}

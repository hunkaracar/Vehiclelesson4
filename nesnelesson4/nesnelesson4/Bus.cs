using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnelesson4
{
    public class Bus : Vehicle
    {





        public Bus() { }
        public Bus(double engine, string model, int numberofwheel, int price, string transmission)
        {
            Engine = engine;
            Model = model;
            NumberOfWheel = numberofwheel;
            Price = price;
            Transmission = transmission;

        }
    }

   
}

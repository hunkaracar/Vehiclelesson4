using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnelesson4
{
    public class Car : Vehicle
    {
        public override int NumberOfWheel => 4;

        public Car() { } //constructor
        public Car(double engine, string model, int numberofwheel, int price, string transmission)
        {
            Engine = engine;
            Model = model;
            NumberOfWheel = numberofwheel;
            Price = price;
            Transmission = transmission;

        }

        public override void Start()
        {
            base.Start();
        }
    }
}

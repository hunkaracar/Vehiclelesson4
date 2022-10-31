using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnelesson4
{
    public class Vehicle
    {
        private double _engine;
        public virtual double Engine { get => _engine;
                set
            {

                if (value>=1.0 && value <= 5.0)
                {
                    _engine = value;
                }
            
                 } }
        public virtual string? Model { get; set; }
        public virtual int NumberOfWheel { get; set; }  
        public virtual int Price { get; set; }  
        public virtual string? Transmission { get; set; }


        public virtual void Start()
        {
            Console.WriteLine("Engine start...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Engine stop...");
        }

        public override string? ToString()
        {
            return $"Engine:{Engine}\nModel:{Model}\nNumberOfWheel:{NumberOfWheel}\nPrice:{Price}\nTransmission:{Transmission}";
        }
    }
}

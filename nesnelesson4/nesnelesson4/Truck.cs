using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnelesson4
{
    public class Truck : Vehicle
    {
        private int _NumberOfWheel;

        public override int NumberOfWheel 
        {
            get { return base.NumberOfWheel; }
            set
            {
                if(value <= 12)
                {
                    _NumberOfWheel = 12; 
                }
                else
                {
                    throw new Exception("Invalid value");    
                }
            } 
        }

        public Truck() { }
        public Truck(double engine,string model,int numberofwheel,int price,string transmission)
        {
            Engine = engine;
            Model = model;  
            NumberOfWheel = numberofwheel;
            Price = price;
            Transmission = transmission;    
            
        }
      
    }
}

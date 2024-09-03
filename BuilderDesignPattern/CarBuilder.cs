/******************************************************************************
* Filename    = CarBuilder.cs
*
* Author      = Enajm Suma
*
* Product     = SoftwareDesignPatterns
* 
* Project     = BuilderPatternDemo
*
* Description = Contract for a listener that is notified when a node is visited.
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModule;

namespace BuilderDesignPattern
{
    public class CarBuilder : IBuilder
    {
        private Car _car;
        public CarBuilder() 
        {
            reset();
        }
        
        public void reset()
        {
            _car = new Car();
            
        }
        public void setSeats(int seats)
        {
            _car.seats=seats;
           
        }
        
        public void setEngine(string engine)
        {
            _car.engine=engine;
        }

        public void setColor(string color)
        {
            _car.color=color;
        }
        public void setGPS(bool gps)
        {
            _car.gps=gps;
        }

        public Car getProduct()
        {
            Car product = _car;
            reset();
            return product;

        }


    }
}

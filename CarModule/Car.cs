/******************************************************************************
* Filename    = Car.cs
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

namespace CarModule
{
    public class Car
    {
        public int seats;
        public string? engine;
        public string? color;
        public bool gps;
        public override string ToString()
        {
            return $"Car Details:\nSeats: {seats}\nEngine: {engine}\nColor: {color}\nGPS: {gps}";
        }
    }
}

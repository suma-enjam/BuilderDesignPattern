/******************************************************************************
* Filename    = Car.cs
*
* Author      = Enajm Suma
*
* Product     = SoftwareDesignPatterns
* 
* Project     = BuilderPatternDemo
*
* Description = All the features of a car are list here.
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

        //formatting all the above things into a string
        public override string ToString()
        {
            return $"Car Details:\nSeats: {seats}\nEngine: {engine}\nColor: {color}\nGPS: {gps}";
        }
    }
}

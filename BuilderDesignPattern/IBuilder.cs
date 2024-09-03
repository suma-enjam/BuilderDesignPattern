/******************************************************************************
* Filename    = IBuilder.cs
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

namespace BuilderDesignPattern
{
    public interface IBuilder
    {
        void reset();
        void setSeats(int  seats);
        void setEngine(string engine);
        void setColor(string color);
        void setGPS(bool gps);
    }
}

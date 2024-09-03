/******************************************************************************
* Filename    = Director.cs
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
using BuilderDesignPattern;

namespace DirectorModule
{
    public class Director
    {

        public void BuildSportsCar(IBuilder builder)
        {
            builder.reset();
            builder.setSeats(1);
            builder.setEngine("type1");
            builder.setColor("Red");
            builder.setGPS( true );
        }

        public void BuildSUV(IBuilder builder)
        {
            builder.reset();
            builder.setSeats(4);
            builder.setEngine("type2");
            builder.setColor("Black");
            builder.setGPS( true );
        }

        public void BuildConvertible( IBuilder builder )
        {
            builder.reset();
            builder.setSeats(2);
            builder.setEngine("type3");
            builder.setColor("White");
            builder.setGPS(true);
        }

    }
}

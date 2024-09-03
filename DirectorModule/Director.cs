/******************************************************************************
* Filename    = Director.cs
*
* Author      = Enajm Suma
*
* Product     = SoftwareDesignPatterns
* 
* Project     = BuilderPatternDemo
*
* Description = showing different apperances of the construction.
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
        //Setting values for sports car 
        public void BuildSportsCar(IBuilder builder)
        {
            builder.reset();
            builder.setSeats(1);
            builder.setEngine("type1");
            builder.setColor("Red");
            builder.setGPS( true );
        }
        //setting values for SUV
        public void BuildSUV(IBuilder builder)
        {
            builder.reset();
            builder.setSeats(4);
            builder.setEngine("type2");
            builder.setColor("Black");
            builder.setGPS( true );
        }
        //setting values for Convertible
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

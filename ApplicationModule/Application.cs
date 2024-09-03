/******************************************************************************
* Filename    = Application.cs
*
* Author      = Enajm Suma
*
* Product     = SoftwareDesignPatterns
* 
* Project     = BuilderPatternDemo
*
* Description = creating an instance of sports car and printing it.
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderDesignPattern;
using DirectorModule;
using CarModule;

namespace ApplicationModule
{
    public class Application
    {
        public static Car CreateSportsCar()
        {
            Director director = new();
            CarBuilder builder = new();

            // setting values of sports car to the created builder
            director.BuildSportsCar( builder );

            //return a product of type Car
            return builder.getProduct();
        }

        static void Main()
        {
            Car car = CreateSportsCar();
            Console.WriteLine( car );
        }
    }
}


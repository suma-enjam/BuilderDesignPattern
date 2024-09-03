/******************************************************************************
* Filename    = Application.cs
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
            director.BuildSportsCar( builder );
            return builder.getProduct();
        }

        static void Main()
        {
            Car car = CreateSportsCar();
            Console.WriteLine( car );
        }
    }
}


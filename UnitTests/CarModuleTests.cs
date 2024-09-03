/******************************************************************************
* Filename    = CarModuleTests.cs
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

namespace UnitTests
{
    [TestClass]
    public class CarModuleTests
    {
        [TestMethod]
        public void TestCarModule()
        {
            Car car = new()
            {
                seats = 2 ,
                engine = "type1" ,
                color= "Red" ,
                gps = true
            };

            string expected = "Car Details:\nSeats: 2\nEngine: type1\nColor: Red\nGPS: True";
            Assert.AreEqual(expected, car.ToString());
        }
    }
}

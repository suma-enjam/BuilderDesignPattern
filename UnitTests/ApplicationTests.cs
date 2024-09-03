/******************************************************************************
* Filename    = ApplicationTests.cs
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
using ApplicationModule;

namespace UnitTests
{
    public class ApplicationTests
    {
        [TestMethod]
        public void TestCreateSportsCar_ShouldConfigureCarCorrectly()
        {
            Car car = Application.CreateSportsCar();

            Assert.AreEqual( 1 , car.seats , "The number of seats for the sports car should be 1." );
            Assert.AreEqual( "type1" , car.engine , "The engine type for the sports car should be 'type1'." );
            Assert.AreEqual( "Red" , car.color , "The sports car should have color Red." );
            Assert.IsTrue( car.gps , "The sports car should have GPS." );
        }
    }
}



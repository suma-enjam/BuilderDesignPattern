/******************************************************************************
* Filename    = CarBuilderTests.cs
*
* Author      = Enajm Suma
*
* Product     = SoftwareDesignPatterns
* 
* Project     = BuilderPatternDemo
*
* Description = Contract for a listener that is notified when a node is visited.
*****************************************************************************/
using System.IO;
using BuilderDesignPattern;
using DirectorModule;
using CarModule;

namespace UnitTests
{
    [TestClass]
    public class CarBuilderTests
    {
        [TestMethod]
        public void Test_BuildSportsCar()
        {
            CarBuilder carBuilder = new();
            Director director = new ();

            director.BuildSportsCar(carBuilder);
            Car car = carBuilder.getProduct();

            Assert.AreEqual(1, car.seats);
            Assert.AreEqual("type1", car.engine);
            Assert.AreEqual("Red",car.color);
            Assert.IsTrue(car.gps);
        }

        [TestMethod]
        public void Test_BuildSUV()
        {
            CarBuilder carBuilder = new();
            Director director = new();

            director.BuildSUV(carBuilder);
            Car car = carBuilder.getProduct();

            Assert.AreEqual(2, car.seats);
            Assert.AreEqual("type2", car.engine);
            Assert.AreEqual("Black",car.color);
            Assert.IsTrue(car.gps);
        }

        [TestMethod]
        public void Test_BuildConvertible()
        {
            CarBuilder carBuilder = new();
            Director director = new();

            director.BuildConvertible( carBuilder );
            Car car = carBuilder.getProduct();

            Assert.AreEqual( 1 , car.seats );
            Assert.AreEqual( "type1" , car.engine );
            Assert.AreEqual( "White" , car.color );
            Assert.IsTrue( car.gps );
        }
    }
}

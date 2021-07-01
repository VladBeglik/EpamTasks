using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task3;
using Task3.Entites;

namespace Task3Tests
{
	[TestClass]
	public class EntitesTests
	{
		Transmission transsmit = new Transmission("1", 1, "apple");
		Engine eng = new Engine(1, 2, "qwe", "qeqw");
		Chassis chassis = new Chassis(1, 2, 3);
		Services service = new Services();

		[TestMethod]
		public void PositiveTestOfCar()
		{
			var car = new Car("Tesla", chassis, transsmit, eng);
			Assert.AreEqual(service.WriteToConsole(car), "CAR Model Tesla, Chassis CountOfWheels: 0,Size: 0,LiftingCapacity: 0, Transmission Type: 1,CountOfGears: 1,Мanufacturer: apple, EnginePower: 1,Volume: 2,SerialNumber: qwe,Type: qeqw");
		}

		[TestMethod]
		public void PositiveTestOfBus()
		{
			var bus = new Bus(111, chassis, transsmit, eng);
			Assert.AreEqual(service.WriteToConsole(bus), "BUS CountOfSeat 111, Chassis CountOfWheels: 0,Size: 0,LiftingCapacity: 0, Transmission Type: 1,CountOfGears: 1,Мanufacturer: apple, EnginePower: 1,Volume: 2,SerialNumber: qwe,Type: qeqw");
		}

		[TestMethod]
		public void PositiveTestOfScooter()
		{
			var scooter = new Scooter(100, chassis, transsmit, eng);
			Assert.AreEqual(service.WriteToConsole(scooter), "Scooter Speed 100, Chassis CountOfWheels: 0,Size: 0,LiftingCapacity: 0, Transmission Type: 1,CountOfGears: 1,Мanufacturer: apple, EnginePower: 1,Volume: 2,SerialNumber: qwe,Type: qeqw");
		}
		[TestMethod]
		public void PositiveTestOfTruck()
		{

			var truck = new Truck(2000, chassis, transsmit, eng);
			Assert.AreEqual(service.WriteToConsole(truck), "Truck Massa 2000, Chassis CountOfWheels: 0,Size: 0,LiftingCapacity: 0, Transmission Type: 1,CountOfGears: 1,Мanufacturer: apple, EnginePower: 1,Volume: 2,SerialNumber: qwe,Type: qeqw");
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow("", null, null, null)]
		//[DataRow(-1, -1, -1, -1)]
		public void NegativeTestOfCar(string model, Chassis chassis, Transmission transmission, Engine engine)
		{
			var car = new Car(model, chassis, transmission, engine);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, null, null, null)]
		[DataRow(-1, null, null, null)]
		public void NegativeTestOfBus(int countOfSeat, Chassis chassis, Transmission transmission, Engine engine)
		{
			var bus = new Bus(countOfSeat, chassis, transmission, engine);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, null, null, null)]
		public void NegativeTestOfScooter(int speed, Chassis chassis, Transmission transmission, Engine engine)
		{
			var scooter = new Scooter(speed, chassis, transmission, engine);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, null, null, null)]
		public void NegativeTestOfTruck(int massa, Chassis chassis, Transmission transmission, Engine engine)
		{
			var truck = new Truck(massa, chassis, transmission, engine);
		}


	}
}
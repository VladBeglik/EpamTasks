using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task5;
namespace Task5Tests
{
	[TestClass]
	public class ComponentsOfVehicleTests
	{
		[TestMethod]
		public void PositiveTestOfChassis()
		{
			var service = new Services();
			var chassis = new Chassis(1, 1, 1);
			Assert.AreEqual(service.WriteToConsole(chassis), "CountOfWheels: 1,Size: 1,LiftingCapacity: 1");
		}

		[TestMethod]
		public void PositiveTestOfEngine()
		{
			var service = new Services();
			var eng = new Engine(1, 2, "qwe", "qeqw");
			Assert.AreEqual(service.WriteToConsole(eng), "Power: 1,Volume: 2,SerialNumber: qwe,Type: qeqw");
		}

		[TestMethod]
		public void PositiveTestOfTransmission()
		{
			var service = new Services();
			var transsmit = new Transmission("1", 1, "apple");
			Assert.AreEqual(service.WriteToConsole(transsmit), "Type: 1,CountOfGears: 1,Мanufacturer: apple");
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, 0, 0)]
		[DataRow(-1, -1, -1)]
		public void NegativeTestOfChassis(int countOfWheels,int size, int liftingCapacity)
		{
			var chassis = new Chassis(countOfWheels, size, liftingCapacity);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, 0, "", "")]
		[DataRow(-1, 0, null, null)]
		public void NegativeTestOfEngine(int power, double volume, string serialNumber, string type)
		{
			var eng = new Engine(power, volume, serialNumber, type);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow("", 0, "")]
		[DataRow(null, -1, null)]
		public void NegativeTestOfTransmission(string type, int countOfGears, string мanufacturer)
		{
			var transsmit = new Transmission(type, countOfGears, мanufacturer);
		}
	}
}
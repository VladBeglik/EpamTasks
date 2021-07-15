using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task4.Entitis;
using Task4.Structures;


namespace TestTask4
{
	[TestClass]
	public class DronTest
	{

		[TestInitialize]
		public void DroneInitialize()
		{
			var dron = new Dron(new Coordinate(0, 0, 0), 1);
		}
		[TestMethod]
		[DataRow(1, 1, 1, 1, 1, 1, 10)]
		[DataRow(0, 0, 0, 5, 6, 7, 10)]
		public void PositiveTestOfFlyToByDrone(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ, double speed)
		{
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			Dron dron = new Dron(firstCoordinate, speed);
			dron.FlyTo(secondCoordinate);
			Assert.AreEqual(dron.CurrentPosition, secondCoordinate);
		}

		[TestMethod]
		[DataRow(0, 0, 0, 0, 0, 60, 1, 66)]
		[DataRow(0, 0, 0, 0, 0, 0, 100, 0)]
		public void PositiveTestOfGetFlyTimeByDrone(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ, double speed, double result)
		{
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			Dron dron = new Dron(firstCoordinate, speed);
			Assert.AreEqual(dron.GetFlyTime(secondCoordinate), result);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, 0, 0, 0, 1000, 0, 0)]
		public void NegativeTestOfFlyToByDrone(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ, double speed)
		{
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			var drone = new Dron(firstCoordinate, speed);
			drone.FlyTo(secondCoordinate);
			Assert.AreEqual(drone.CurrentPosition, secondCoordinate);
		}


	}
}
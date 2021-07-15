using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task4.Entitis;
using Task4.Structures;

namespace TestTask4
{
	[TestClass]
	public class PlaneTest
	{

		[TestInitialize]
		public void PlaneInitialize()
		{
			var plane = new Plane(new Coordinate(0, 0, 0));
		}

		[TestMethod]
		[DataRow(1, 1, 1, 1, 1, 1)]
		[DataRow(0, 0, 0, 5, 6, 7)]
		public void PositiveTestOfFlyToByPlane(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ)
		{
			var firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			var secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			var plane = new Plane(firstCoordinate);
			plane.FlyTo(secondCoordinate);
			Assert.AreEqual(plane.CurrentPosition, secondCoordinate);
		}

		[TestMethod]
		[DataRow(0, 0, 0, 10, 0, 0, 0.05)]
		[DataRow(0, 0, 0, 0, 0, 0, 0)]
		public void PositiveTestOfGetFlyTimeByPlane(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ, double result)
		{
			var firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			var secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			var plane = new Plane(firstCoordinate);
			Assert.AreEqual(plane.GetFlyTime(secondCoordinate), result);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, 0, 0, 0, 0, 7000, 0)]
		public void NegativeTestOfGetFlyTimeByPlane(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ, double result)
		{
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			var plane = new Plane(firstCoordinate);
			Assert.AreEqual(plane.GetFlyTime(secondCoordinate), result);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, 0, 0, 0, 0, 7000)]
		public void NegativeTestOfFlyToByPlane(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ)
		{
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			Plane plane = new Plane(firstCoordinate);
			plane.FlyTo(secondCoordinate);
			Assert.AreEqual(plane.CurrentPosition, secondCoordinate);
		}
	}
}
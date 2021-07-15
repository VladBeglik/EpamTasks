using System;
using System.Net.Http.Headers;
using System.Threading.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4.Structures;

namespace TestTask4
{
	[TestClass]
	public class TestCoordinate
	{
		[TestInitialize]
		public void TestInitializeCoordinates()
		{
			var firstCoordinate = new Coordinate(1, 1, 1);
		}

		[TestMethod]
		[DataRow(1, 1, 1)]
		[DataRow(1, 2, 3)]
		[DataRow(0, -1, 0)]
		public void PositiveTestCoordinates(int x, int y, int z)
		{
			var coordinate = new Coordinate(x, y, z);
			TestInitializeCoordinates();
			Assert.AreEqual($"{x}, {y}, {z}", coordinate.ToString());
		}

		[TestMethod]
		[DataRow(1, 1, 1, 1, 1, 1, 0)]
		[DataRow(-1, 0, 0, 0, 0, 0, 1)]
		public void PositiveTestOfCoordinateDifference(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ, double result)
		{
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			Assert.AreEqual(firstCoordinate.Distance(secondCoordinate), result);
		}

		[TestMethod]
		public void Distance_MaxAndMinValue_ReruenTrue()
		{
			Coordinate firstCoordinate = new Coordinate(int.MinValue, int.MinValue, int.MinValue);
			Coordinate secondCoordinate = new Coordinate(int.MaxValue, int.MaxValue, int.MaxValue);

			Assert.AreEqual(secondCoordinate.Distance(firstCoordinate), 7439101571.786667d);
		}
	}
}

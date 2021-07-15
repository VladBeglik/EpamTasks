using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task4.Entitis;
using Task4.Structures;

namespace TestTask4
{
	[TestClass]
	public class BirdTest
	{
		[TestInitialize]
		public void BirdInitialize()
		{
			var bird = new Bird(new Coordinate(0, 0, 0));
		}

		[TestMethod]
		[DataRow(1, 1, 1, 1, 1, 1)]
		[DataRow(0, 0, 0, 5, 6, 7)]
		public void PositiveTestOfFlyToByBird(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ)
		{
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			Bird bird = new Bird(firstCoordinate);
			bird.FlyTo(secondCoordinate);
			Assert.AreEqual(bird.CurrentPosition, secondCoordinate);
		}

		[TestMethod]
		[DataRow(0, 0, 0, 0, 0, 10)]
		public void PositiveTestOfGetFlyTimeByBird(double firstX, double firstY, double firstZ, double secondX,
			double secondY, double secondZ)
		{
			bool success = false;
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			Bird bird = new Bird(firstCoordinate);
			double result = firstCoordinate.Distance(secondCoordinate);
			double result1 = result / bird.Speed;
			Console.WriteLine(bird.GetFlyTime(secondCoordinate));
			Console.WriteLine(result1);
			if (bird.GetFlyTime(secondCoordinate) - result1 < double.Epsilon)
			{
				success = true;
			}

			Assert.IsTrue(success);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, 0, 0, 0, 0, 4001)]
		public void NegativeTestOfGetFlyTimeByBird(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ)
		{
			bool success = false;
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			Bird bird = new Bird(firstCoordinate);
			double result = firstCoordinate.Distance(secondCoordinate);
			double result1 = result / bird.Speed;
			if (bird.GetFlyTime(secondCoordinate) - result1 < double.Epsilon)
			{
				success = true;
			}
			Assert.IsTrue(success);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		[DataRow(0, 0, 0, 0, 0, 4000)]
		public void NegativeTestOfFlyToByBird(double firstX, double firstY, double firstZ, double secondX, double secondY, double secondZ)
		{
			Coordinate firstCoordinate = new Coordinate(firstX, firstY, firstZ);
			Coordinate secondCoordinate = new Coordinate(secondX, secondY, secondZ);
			Bird bird = new Bird(firstCoordinate);
			bird.FlyTo(secondCoordinate);
			Assert.AreEqual(bird.CurrentPosition, secondCoordinate);
		}
	}
}
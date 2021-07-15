using System;
using Task4.Interfaces;
using Task4.Structures;

namespace Task4.Entitis
{
	public class Dron : FlyingObject, IFlyable
	{
		public Dron(Coordinate currentPosition, double speed) : base(currentPosition)
		{
			Speed = speed;
		}

		public double GetFlyTime(Coordinate coordinate)
		{
			var l = CurrentPosition.Distance(coordinate);
			if (l >= 1000)
			{
				Console.WriteLine("The drone cannot fly more than 1000 km");
				return 0;
			}
			var time = l / Speed;
			time += ((time - time % 10) / 10);
			CurrentPosition = coordinate;
			return time;
		}

		public void FlyTo(Coordinate coordinate)
		{
			var l = CurrentPosition.Distance(coordinate);
			if (l >= 1000)
			{
				Console.WriteLine("The drone cannot fly more than 1000 km");
				throw new Exception("The drone cannot fly more than 1000 km");
			}
			else
			{
				CurrentPosition = coordinate;
			}
		}
	}
}

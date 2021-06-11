using System;
using System.Collections.Generic;
using System.Text;
using Task4.Interfaces;

namespace Task4.Entitis
{
	public class Dron : FlyingObject, IFlyable
	{
		public Dron(Coordinate currentPosition, double speed) : base(currentPosition)
		{
			Speed = speed;
		}

		public double FlyTime(Coordinate coordinate)
		{
			double L = CurrentPosition.Distanse(coordinate);
			if (L >= 1000)
			{
				Console.WriteLine("The drone cannot fly more than 1000 km");
				return 0;
			}
			double time = L / Speed;
			time = time + ((time - time % 10) / 10);
			CurrentPosition = coordinate;
			return time;
		}

		public void FlyTo(Coordinate coordinate)
		{
			double L = CurrentPosition.Distanse(coordinate);
			if (L >= 1000)
			{
				Console.WriteLine("The drone cannot fly more than 1000 km");
			}
			else
			{
				CurrentPosition = coordinate;
			}
		}
	}
}

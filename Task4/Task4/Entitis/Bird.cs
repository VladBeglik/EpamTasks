using System;
using System.Collections.Generic;
using System.Text;
using Task4.Interfaces;
using Task4.Structures;

namespace Task4.Entitis
{
	public class Bird : FlyingObject, IFlyable
	{
		public Bird(Coordinate coordinate) : base(coordinate)
		{

		}

		public double GetFlyTime(Coordinate coordinate)
		{
			var random = new Random();
			Speed = Convert.ToDouble(random.Next(0, 20));
			var L = CurrentPosition.Distance(coordinate);
			if (L >= 4000)
			{
				throw new System.Exception("Distance too far");
			}
			var time = L / Speed;
			return time;
		}

		public void FlyTo(Coordinate coordinate)
		{
			double l = CurrentPosition.Distance(coordinate);
			if (l >= 4000)
			{
				throw new System.Exception("Distance too far");
			}
			CurrentPosition = coordinate;
		}
	}
}

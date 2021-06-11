using System;
using System.Collections.Generic;
using System.Text;
using Task4.Interfaces;

namespace Task4.Entitis
{
	public class Bird : FlyingObject, IFlyable
	{
		public Bird(Coordinate coordinate) : base(coordinate)
		{

		}

		public double FlyTime(Coordinate coordinate)
		{
			var random = new Random();
			Speed = Convert.ToDouble(random.Next(0, 20));
			double L = CurrentPosition.Distanse(coordinate);
			double time = L / Speed;
			return time;
		}

		public void FlyTo(Coordinate coordinate)
		{
			CurrentPosition = coordinate;
		}


	}
}

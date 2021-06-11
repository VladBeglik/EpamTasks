using System;
using System.Collections.Generic;
using System.Text;
using Task4.Interfaces;

namespace Task4.Entitis
{
	public class Plane : FlyingObject, IFlyable
	{
		public Plane(Coordinate currentPosition) : base(currentPosition)
		{
			Speed = 200;
		}

		public double FlyTime(Coordinate coordinate)
		{
			double L = CurrentPosition.Distanse(coordinate);
			double time = 0.0;
			double index = 0;

			while (L > 0.0)
			{
				time += 10 / (Speed + 10 * index);
				L -= 10;
				index++;
			}
			return time;
		}

		public void FlyTo(Coordinate coordinate)
		{
			CurrentPosition = coordinate;
		}
	}
}

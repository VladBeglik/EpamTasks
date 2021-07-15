using System;
using System.Collections.Generic;
using System.Text;
using Task4.Interfaces;
using Task4.Structures;

namespace Task4.Entitis
{
	public class Plane : FlyingObject, IFlyable
	{
		public Plane(Coordinate currentPosition) : base(currentPosition)
		{
			Speed = 200;
		}

		public double GetFlyTime(Coordinate coordinate)
		{

			var l = CurrentPosition.Distance(coordinate);
			var time = 0.0;
			var index = 0;
			if (l >= 7000)
			{
				throw new System.Exception("Distance too far");
			}
			while (l > 0.0)
			{
				time += 10 / (Speed + 10 * index);
				l-= 10;
				index++;
			}
			return time;
		}

		public void FlyTo(Coordinate coordinate)
		{
			double l = CurrentPosition.Distance(coordinate);
			if (l >= 7000)
			{
				throw new System.Exception("Distance too far");
			}
			CurrentPosition = coordinate;
		}
	}
}

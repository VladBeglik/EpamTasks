using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Interfaces
{
	interface IFlyable
	{
		public void FlyTo(Coordinate coordinate);
		public double FlyTime(Coordinate coordinate);
	}
}

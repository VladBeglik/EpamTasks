using System;
using System.Collections.Generic;
using System.Text;
using Task4.Structures;

namespace Task4.Interfaces
{
	internal interface IFlyable
	{
		public void FlyTo(Coordinate coordinate);
		public double GetFlyTime(Coordinate coordinate);
	}
}

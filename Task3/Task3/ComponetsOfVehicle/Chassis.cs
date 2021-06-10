using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
	public class Chassis
	{
		public int CountOfWheels { get;private set; }
		public int Size { get; private set; }
		public int LiftingCapacity { get; private set; }

		public Chassis(int CountOfWheels, int Size, int LiftingCapacity)
		{
			this.CountOfWheels = CountOfWheels;
			this.Size = Size;
			this.LiftingCapacity = LiftingCapacity;
		}

		public override string ToString()
		{
			return $"CountOfWheels: {CountOfWheels},Size: {Size},LiftingCapacity: {LiftingCapacity}";
		}
	}
}

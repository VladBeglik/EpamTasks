using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	public class Chassis
	{
		public int CountOfWheels { get; set; }
		public int Size { get;  set; }
		public int LiftingCapacity { get;  set; }

		public Chassis(int countOfWheels, int size, int liftingCapacity)
		{
			if (countOfWheels <= 0 || size <= 0 || liftingCapacity <= 0)
			{
				throw new Exception("Null or wrong data");
			}
			this.CountOfWheels = CountOfWheels;
			this.Size = Size;
			this.LiftingCapacity = LiftingCapacity;
		}

		public Chassis()
		{
				
		}

		public override string ToString()
		{
			return $"CountOfWheels: {CountOfWheels},Size: {Size},LiftingCapacity: {LiftingCapacity}";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
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
			CountOfWheels = countOfWheels;
			Size = size;
			LiftingCapacity = liftingCapacity;
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

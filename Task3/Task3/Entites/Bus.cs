using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task3.Entites
{
	public class Bus : Vehicle
	{
		public int CountOfSeat { get; set; }
		public Bus(int countOfSeat,Chassis chassis, Transmission transmission, Engine engine):base(chassis, transmission, engine)
		{
			if(chassis is null)
			{
				throw new Exception("Not all input data or incorrect data");
			}
			if (transmission is null)
			{
				throw new Exception("Not all input data or incorrect data");
			}
			if (engine is null)
			{
				throw new Exception("Not all input data or incorrect data");
			}
			if (countOfSeat <= 0)
			{
				throw new Exception("Not all input data or incorrect data");
			}
			CountOfSeat = countOfSeat;
		}

		public override string ToString()
		{
			return $"BUS CountOfSeat {CountOfSeat}, Chassis {Chassis}, Transmission {Transmission}, Engine{Engine}";
		}
	}
}


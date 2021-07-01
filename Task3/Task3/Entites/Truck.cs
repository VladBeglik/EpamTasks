using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task3.Entites
{
	public class Truck : Vehicle
	{
		public int Massa { get;  set; }
		public Truck(int massa,Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
		{
			if (chassis is null)
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
			if(massa <= 0)
			{
				throw new Exception("Not all input data or incorrect data");
			}

			Massa = massa;
		}

		public override string ToString()
		{
			return $"Truck Massa {Massa}, Chassis {Chassis}, Transmission {Transmission}, Engine{Engine}";
		}
	}
}

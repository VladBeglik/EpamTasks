using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task3.Entites
{
	public class Scooter : Vehicle
	{
		public int Speed { get;  set; }
		public Scooter(int speed, Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
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
			if (speed < 0)
			{
				throw new Exception("Not all input data or incorrect data");
			}

			Speed = speed;
		}

		public override string ToString()
		{
			return $"Scooter Speed {Speed}, Chassis {Chassis}, Transmission {Transmission}, Engine{Engine}";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entites
{
	public class Scooter : Vehicle
	{
		public int Speed { get; private set; }
		public Scooter(int speed, Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
		{
			Speed = speed;
		}

		public override string ToString()
		{
			return $"BUS\nSpeed {Speed},\nChassis {Chassis},\nTransmission {Transmission},\nEngine{Engine}";
		}
	}
}

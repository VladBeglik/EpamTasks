using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entites
{
	public class Truck : Vehicle
	{
		public int Massa { get; private set; }
		public Truck(int massa,Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
		{
			Massa = massa;
		}

		public override string ToString()
		{
			return $"BUS\nCountOfSeat {Massa},\nChassis {Chassis},\nTransmission {Transmission},\nEngine{Engine}";
		}
	}
}

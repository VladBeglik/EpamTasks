using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entites
{
	public abstract class Vehicle
	{
		public Chassis Chassis { get; set; }
		public Engine Engine { get; set; }
		public Transmission Transmission { get; set; }

		public Vehicle(Chassis chassis, Transmission transmission, Engine engine)
		{
			Chassis = chassis;
			Transmission = transmission;
			Engine = engine;
		}

	}
}

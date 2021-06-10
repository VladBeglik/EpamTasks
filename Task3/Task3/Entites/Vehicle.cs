using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entites
{
	public abstract class Vehicle
	{
		public Chassis Chassis { get; private set; }
		public Engine Engine { get; private set; }
		public Transmission Transmission { get; private set; }

		public Vehicle(Chassis chassis, Transmission transmission, Engine engine)
		{
			Chassis = chassis;
			Transmission = transmission;
			Engine = engine;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Task5.Entites
{
	[XmlInclude(typeof(Car))]
	[XmlInclude(typeof(Bus))]
	[XmlInclude(typeof(Scooter))]
	[XmlInclude(typeof(Truck))]
	public abstract class Vehicle
	{
		public Chassis Chassis { get;  set; }
		public Engine Engine { get;  set; }
		public Transmission Transmission { get;  set; }

		public Vehicle(Chassis chassis, Transmission transmission, Engine engine)
		{
			Chassis = chassis;
			Transmission = transmission;
			Engine = engine;
		}

		public Vehicle()
		{

		}
	}
}

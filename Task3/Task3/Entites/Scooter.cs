using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entites
{
	public class Scooter : Vehicle
	{
		public int Speed { get; set; }
		public Scooter(int speed, Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
		{
			Speed = speed;
		}
	}
}

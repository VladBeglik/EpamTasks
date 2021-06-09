using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entites
{
	public class Truck : Vehicle
	{
		public int MyProperty { get; set; }
		public Truck(string countOfSeat, Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
		{
			
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entites
{
	public class Car : Vehicle
	{
		public string Model { get; set; }
		public Car(string model, Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
		{
			Model = model;
		}
	}
}

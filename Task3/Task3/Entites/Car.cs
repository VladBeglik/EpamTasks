using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task3.Entites
{
	public class Car : Vehicle
	{
		public string Model { get;  set; }
		public Car(string model, Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
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
			if(model == string.Empty)
			{
				throw new Exception("Not all input data or incorrect data");
			}
			Model = model;
		}

		public override string ToString()
		{
			return $"CAR Model {Model}, Chassis {Chassis}, Transmission {Transmission}, Engine{Engine}";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entites
{
	public class Bus : Vehicle
	{
		public string CountOfSeat { get; set; }
		public Bus(string countOfSeat,Chassis chassis, Transmission transmission, Engine engine):base(chassis, transmission, engine)
		{
			CountOfSeat = countOfSeat;
		}
	}
}

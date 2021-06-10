using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
	public class Engine
	{
		public int Power { get; private set; }
		public double Volume { get; private set; }
		public string serialNumber { get; private set; }
		public string Type { get; private set; }

		public Engine(int power, double volume, string serialNumber, string type)
		{
			Power = power;
			Volume = volume;
			this.serialNumber = serialNumber;
			Type = type;
		}

		public override string ToString()
		{
			return $"Power: {Power},Volume: {Volume},SerialNumber: {serialNumber},Type: {Type} ";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
	public class Engine
	{
		public int Power { get;  set; }
		public double Volume { get;  set; }
		public string SerialNumber { get;  set; }
		public string Type { get;  set; }

		public Engine(int power, double volume, string serialNumber, string type)
		{
			if (power <= 0 || volume <= 0 || serialNumber == string.Empty || type == string.Empty)
			{
				throw new Exception("Null or wrong data");
			}
			Power = power;
			Volume = volume;
			SerialNumber = serialNumber;
			Type = type;
		}

		public Engine()
		{
			
		}

		public override string ToString()
		{
			return $"Power: {Power},Volume: {Volume},SerialNumber: {SerialNumber},Type: {Type}";
		}
	}
}

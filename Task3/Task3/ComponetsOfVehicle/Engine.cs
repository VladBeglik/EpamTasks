using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	public class Engine
	{
		public int Power { get;  set; }
		public double Volume { get;  set; }
		public string serialNumber { get;  set; }
		public string Type { get;  set; }

		public Engine(int power, double volume, string serialNumber, string type)
		{
			if (power <= 0 || volume <= 0 || serialNumber == string.Empty || type == string.Empty)
			{
				throw new Exception("Null or wrong data");
			}
			Power = power;
			Volume = volume;
			this.serialNumber = serialNumber;
			Type = type;
		}


		public override string ToString()
		{
			return $"Power: {Power},Volume: {Volume},SerialNumber: {serialNumber},Type: {Type}";
		}
	}
}

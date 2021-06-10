using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
	public class Transmission
	{
		public string Type { get;private set; }

		public int CountOfGears { get; private set; }

		public string Мanufacturer { get; private set; }

		public Transmission(string type, int countOfGears, string мanufacturer)
		{
			Type = type;
			CountOfGears = countOfGears;
			Мanufacturer = мanufacturer;
		}

		public override string ToString()
		{
			return $"Type: {Type},CountOfGears: {CountOfGears},Мanufacturer: {Мanufacturer}";
		}
	}
}

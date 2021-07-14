using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
	public class Transmission
	{
		public string Type { get; set; }
		public int CountOfGears { get; set; }
		public string Мanufacturer { get; set; }

		public Transmission(string type, int countOfGears, string мanufacturer)
		{
			if (type == string.Empty || countOfGears < 0 || мanufacturer == string.Empty)
			{
				throw new Exception("Null or wrong data");
			}
			Type = type;
			CountOfGears = countOfGears;
			Мanufacturer = мanufacturer;
		}

		public Transmission()
		{
				
		}

		public override string ToString()
		{
			return $"Type: {Type},CountOfGears: {CountOfGears},Мanufacturer: {Мanufacturer}";
		}
	}
}

using System;

namespace Task5
{
	[Serializable]
	public class VehicleModel
	{
		public string Type { get; set; }
		public string SerialNumber { get; set; }
		public int Power { get; set; }


		public VehicleModel(string Type, string SerialNumber, int Power)
		{
			this.Type = Type;
			this.SerialNumber = SerialNumber;
			this.Power = Power;
		}
	}

	
}
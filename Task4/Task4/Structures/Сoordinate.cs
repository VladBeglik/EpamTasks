using System;

namespace Task4.Structures
{
	public struct Coordinate
	{
		public double X { get; private set; }
		public double Y { get; private set; }
		public double Z { get; private set; }

		public Coordinate(double x, double y, double z)
		{
			X = x;
			Y = y;	
			Z = z;
		}

		public double Distance(Coordinate coordinate)
		{
			return Math.Sqrt(Math.Pow((coordinate.X - X), 2) + Math.Pow((coordinate.Y - Y),2)  + Math.Pow((coordinate.Z - Z), 2));
		}

		public override string ToString()
		{
			return $"{X}, {Y}, {Z}";
		}
	}
}

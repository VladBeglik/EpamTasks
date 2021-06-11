﻿using System;

namespace Task4
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

		public double Distanse(Coordinate coordinate)
		{
			return Math.Sqrt(Math.Pow((X - coordinate.X), 2) + Math.Pow((Y - coordinate.Y),2)  + Math.Pow((Z - coordinate.Z), 2));
		}
	}
}

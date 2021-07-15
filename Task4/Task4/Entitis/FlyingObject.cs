using System;
using System.Collections.Generic;
using System.Text;
using Task4.Structures;

namespace Task4.Entitis
{
	public abstract class FlyingObject
	{
		public Coordinate CurrentPosition { get; set; }
		public double Speed { get; set; } 
		
		public FlyingObject(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }
    }
}

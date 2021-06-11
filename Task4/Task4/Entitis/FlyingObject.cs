using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Entitis
{
	public abstract class FlyingObject
	{
        protected Coordinate CurrentPosition { get; set; }
		protected double Speed { get; set; }

    public FlyingObject(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }
    }
}

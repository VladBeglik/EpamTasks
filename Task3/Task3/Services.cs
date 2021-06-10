using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
	public class Services
	{
		public void WriteToConsole<T>(T model)
		{
			Console.WriteLine(model.ToString());
		}
	}
}

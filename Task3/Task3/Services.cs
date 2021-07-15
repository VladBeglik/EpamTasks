using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Task3.Entites;

namespace Task3
{
	public class Services
	{
		/// <summary>
		/// Write to console data of objects
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="model"></param>
		public string WriteToConsole<T>(T model)
		{
			Console.WriteLine(model.ToString());
			return model.ToString();
		}
	}
}

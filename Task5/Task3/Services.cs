using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Task5.Entites;

namespace Task5
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
		
		/// <summary>
		/// Save data to xml file.
		/// </summary>
		/// <param name="filename"></param>
		/// <param name="vehicles"></param>
		public void Save(string filename, List<Vehicle> vehicles)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(List<Vehicle>), new Type[] { typeof(Car), typeof(Bus), typeof(Truck), typeof(Scooter) });

			using (FileStream fs = new FileStream($"{filename}.xml", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, vehicles);
			}
		}

		public List<Vehicle> allVehicles(List<Vehicle> vehicles)
		{
			var result = (from transport in vehicles
				where transport.Engine.Volume > 1.5
				select transport).ToList();
			return result;
		}

		public List<A> allV(List<Vehicle> vehicles)
		{
			var result = (from transport in vehicles
				where transport.GetType() == typeof(Bus)
				select new A(transport.Engine.Type, transport.Engine.SerialNumber, transport.Engine.Power)).ToList();
			return result;
		}

	}
}

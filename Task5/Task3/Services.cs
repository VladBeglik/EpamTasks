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
		/// Provides complete information about all vehicles with an engine capacity of more than engineVolume.
		/// </summary>
		/// <param name="vehicles"></param>
		/// <returns></returns>
		public List<Vehicle> GetAllVehiclesWithEngineVolumeMoreThan(List<Vehicle> vehicles)
		{
			var result = (from transport in vehicles
				where transport.Engine.Volume > 1.5
				select transport).ToList();
			return result;
		}

		/// <summary>
		/// Provides engine type, serial number and power rating for all buses and trucks.
		/// </summary>
		/// <param name="vehicles"></param>
		/// <returns></returns>
		public List<VehicleModel> GetBusAndTrucks(List<Vehicle> vehicles)
		{
			var result = (from transport in vehicles
				where (transport.GetType() == typeof(Bus) && transport.GetType() == typeof(Truck))
				select new VehicleModel(transport.Engine.Type, transport.Engine.SerialNumber, transport.Engine.Power)).ToList();
			return result;
		}

		/// <summary>
		/// Provides complete information about all vehicles, grouped by transmission type.
		/// </summary>
		/// <returns>List of vehicle.</returns>
		public List<Vehicle> GetGroupedByTransmission(List<Vehicle> vehicles)
		{
			return vehicles.GroupBy(v => v.Transmission.Type).SelectMany(g => g).ToList();
		}


	}
}

using System;
using System.Collections.Generic;
using Task3.Entites;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var service = new Services();
				var chassis = new Chassis(1, 2, 3);
				//service.WriteToConsole(chassis);
				var transsmit = new Transmission("1", 1, "apple");
				//ervice.WriteToConsole(transsmit);
				var eng = new Engine(1, 2, "qwe", "qeqw");
				//service.WriteToConsole(eng);
				var bus = new Bus(111, chassis, transsmit, eng);
				var car = new Car("Tesla", chassis, transsmit, eng);
				service.WriteToConsole(bus);
				service.WriteToConsole(car);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exeption: {ex.Message}");
			}
		}
	}
}


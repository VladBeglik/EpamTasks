using System;
using System.Collections.Generic;
using Task3.Entites;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			var service = new Services();
			var chassis = new Chassis(1, 2, 3);
			service.WriteToConsole(chassis);
			var transsmit = new Transmission("1", 1, "apple");
			service.WriteToConsole(transsmit);
			var eng = new Engine(1, 2, "qwe", "qeqw");
			service.WriteToConsole(eng);
			var bus = new Bus(111, chassis, transsmit, eng);
			var car = new Car("Tesla", chassis, transsmit, eng);
			var scotter = new Scooter(100, chassis, transsmit, eng);
			var truck = new Truck(2000, chassis, transsmit, eng);
			service.WriteToConsole(bus);
			service.WriteToConsole(car);
			service.WriteToConsole(scotter);
			service.WriteToConsole(truck);
			//var lst = new List<Vehicle>();
			//lst.Add(bus);
			//lst.Add(car);
		}
	}
}


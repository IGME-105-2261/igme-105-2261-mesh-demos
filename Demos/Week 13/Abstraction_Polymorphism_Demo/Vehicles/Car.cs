using System;

namespace Abstraction_Polymorphism_Demo.Vehicles
{
	class Car : Vehicle
	{
		/// <summary>
		/// Make a car, passing the info to the parent class
		/// </summary>
		/// <param name="name">The name of this car</param>
		public Car(String name) 
			: base(name)
		{
		}

		public override void Drive()
		{
			Console.WriteLine("CAR named " + name + " is driving!");
		}

		public void Sunroof()
		{
			Console.WriteLine("CAR named " + name + " is opening its sunroof");
		}

		public override string ToString()
		{
			return base.ToString() + " is definitely a car";
		}
	}
}

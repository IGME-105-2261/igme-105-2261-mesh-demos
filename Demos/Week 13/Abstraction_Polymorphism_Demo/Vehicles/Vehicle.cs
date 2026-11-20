using System;

namespace Abstraction_Polymorphism_Demo.Vehicles
{
	/// <summary>
	/// This is the parent class of all vehicles in our game
	/// </summary>
	class Vehicle
	{
		// Fields
		protected string name;

		/// <summary>
		/// This creates a vehicle with a name
		/// </summary>
		/// <param name="name">The make or model of the vehicle</param>
		public Vehicle(String name)
		{
			this.name = name;
		}

		/// <summary>
		/// This causes the vehicle to drive
		/// </summary>
		public virtual void Drive()
		{
			Console.WriteLine("VEHICLE called " + name + " is driving!");
		}

		/// <summary>
		/// This stops a vehicle
		/// </summary>
		public void Stop()
		{
			Console.WriteLine("VEHICLE called " + name + " has stopped");
		}

		/// <summary>
		/// Returns a string version of an object
		/// </summary>
		/// <returns>The string version of this thing</returns>
		public override string ToString()
		{
			return "This is a vehicle named " + name;
		}
	}
}

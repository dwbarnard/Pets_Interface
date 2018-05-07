using System;
using System.Collections.Generic;
using System.Text;

namespace PetsWithInterfaces
{
    class BirdFlyer : IFly
	{
		public void Fly()
		{
			Console.WriteLine();
			Console.WriteLine(" Flying, Soaring...");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PetsWithInterfaces
{
    class MammalFlyer : IFly
	{
		public void Fly()
		{
			Console.WriteLine();
			Console.WriteLine(" Nope, this mammal don't fly...");
		}
	}
}

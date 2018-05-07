using System;
using System.Collections.Generic;
using System.Text;

namespace PetsWithInterfaces
{
	class BirdHeatGenerator : IGenerateHeat
	{
		public void GenerateHeat()
		{
			Console.WriteLine();
			Console.WriteLine(" Generating Heat at 105 degrees...");
		}
	}
}

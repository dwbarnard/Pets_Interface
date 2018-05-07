using System;


namespace PetsWithInterfaces
{
	class BirdNoiseMaker : IMakeNoise
	{
		public void MakeNoise()
		{
			Console.WriteLine();
			Console.WriteLine(" Tweet Tweet");
		}
	}
}
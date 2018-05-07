using System;
using System.Collections.Generic;
using System.Text;

namespace PetsWithInterfaces
{
    class Bird : IMakeNoise, IGenerateHeat
	{
		public string Name { get; set; }
		public IMakeNoise noiseMaker { get; set; }
		public IGenerateHeat generator { get; set; }
		public IFly flyer { get; set; }


		public Bird(string Name, IMakeNoise noiseMaker, IGenerateHeat generator, IFly flyer)
		{
			this.Name = Name;
			this.noiseMaker = noiseMaker;
			this.generator = generator;
			this.flyer = flyer;
		}

		public void MakeNoise() { this.noiseMaker.MakeNoise(); }
		public void GenerateHeat() { this.generator.GenerateHeat(); }
		public void Fly() { this.flyer.Fly(); }
	}
}

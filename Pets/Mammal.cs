namespace PetsWithInterfaces
{
    class Animal : IMakeNoise, IGenerateHeat
    {
        public string Name { get; set; }
        public IMakeNoise noiseMaker { get; set; }
        public IGenerateHeat generator { get; set; }
		public IFly fly { get; set; }

        public Animal(string Name, IMakeNoise noiseMaker, IGenerateHeat generator, IFly fly)
        {
            this.Name = Name;
            this.noiseMaker = noiseMaker;
            this.generator = generator;
			this.fly = fly;
        }

        public void MakeNoise() { this.noiseMaker.MakeNoise(); }
        public void GenerateHeat() { this.generator.GenerateHeat(); }
		public void Fly() { this.fly.Fly(); }
	}
}
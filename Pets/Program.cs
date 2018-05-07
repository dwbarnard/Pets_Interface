namespace PetsWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var mammalHeatGenerator = new MammalHeatGenerator();
			var birdHeatGenerator = new BirdHeatGenerator();
			var mammalFlyer = new MammalFlyer();

			var dog = new Animal("Spot", new DogNoiseMaker(), mammalHeatGenerator, mammalFlyer);
            dog.GenerateHeat();
            dog.MakeNoise();
			dog.Fly();
			
            var cat = new Animal("Bill", new CatNoiseMaker(), mammalHeatGenerator, mammalFlyer);
            cat.GenerateHeat();
            cat.MakeNoise();
			cat.Fly();

			var bird = new Animal("Tweety", new BirdNoiseMaker(), birdHeatGenerator, new BirdFlyer());
			bird.GenerateHeat();
			bird.MakeNoise();
			bird.Fly();

			System.Threading.Thread.Sleep(5000);
        }
    }
}
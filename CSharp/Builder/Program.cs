namespace Builder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var Car = makeCar();
			Console.WriteLine(Car.Item1.GetEngine() + " " + Car.Item2.GetEngineManual());
			Console.WriteLine(Car.Item1.GetGPS() + " " + Car.Item2.GetGPSManual());
		}
		static (Car,CarManual) makeCar()
		{
			Director director = new Director();

			CarBuilder builder = new CarBuilder();
			director.ConstructSportCar(builder);
			Car car = builder.GetProduct();

			CarManualBuilder manualBuilder = new CarManualBuilder();
			director.ConstructSportCarManual(manualBuilder);
			CarManual carManual = manualBuilder.GetProduct();

			return (car, carManual);
		}
	}
}

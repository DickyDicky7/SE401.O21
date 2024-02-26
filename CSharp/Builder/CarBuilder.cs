using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	internal class CarBuilder:IBuilder
	{
		private Car car = null!;
		public CarBuilder()
		{
			this.Reset();
		}
		public void Reset()
		{
			this.car = new Car();
		}
		public void SetSeat(int seat)
		{
			car.SetSeat(seat);
		}
		public void SetEngine(string engine)
		{
			car.SetEngine(engine);
		}
		public void SetTripComputer(string tripComputer)
		{
			car.SetTripComputer(tripComputer);
		}
		public void SetGPS(string gps)
		{
			car.SetGPS(gps);
		}
		public Car GetProduct()
		{
			Car product = this.car;
			this.Reset();
			return product;
		}
	}
}

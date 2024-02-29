using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	internal class Director
	{
		private IBuilder builder = null!;
		public void SetBuilder(IBuilder builder)
		{
			this.builder = builder;
		}
		public void ConstructSportCar(IBuilder builder)
		{
			builder.Reset();
			builder.SetSeat(2);
			builder.SetEngine("SportEngine");
			builder.SetTripComputer("SportTC");
			builder.SetGPS("SportGPS");
		}
		public void ConstructSUV(IBuilder builder)
		{
			builder.Reset();
			builder.SetSeat(7);
			builder.SetEngine("SUVEngine");
			builder.SetTripComputer("SUVTC");
			builder.SetGPS("SUVGPS");
		}
		public void ConstructSportCarManual(IBuilder builder)
		{
			builder.Reset();
			builder.SetSeat(1);
			builder.SetEngine("Sport Engine");
			builder.SetTripComputer("Sport TC");
			builder.SetGPS("Sport GPS");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	internal class Car
	{
		private int seat;
		private string engine;
		private string tripComputer;
		private string gps;
		public Car()
		{
			this.seat = 1;
			this.engine = string.Empty;
			this.tripComputer = string.Empty;
			this.gps = string.Empty;
		}
		public void SetSeat(int seat)
		{
			this.seat = seat;
		}
		public void SetEngine(string engine)
		{
			this.engine = engine;
		}
		public void SetTripComputer(string tripComputer)
		{
			this.tripComputer = tripComputer;
		}
		public void SetGPS(string gps)
		{
			this.gps = gps;
		}
		public string GetEngine()
		{
			return this.engine;
		}
		public string GetGPS()
		{
			return this.gps;
		}
	}
}

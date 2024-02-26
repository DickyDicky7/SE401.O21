using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	internal class CarManual
	{
		private int seatManual;
		private string engineManual;
		private string tripComputerManual;
		private string gpsManual;
		public CarManual()
		{
			seatManual = 1;
			engineManual = string.Empty;
			tripComputerManual = string.Empty;
			gpsManual = string.Empty;
		}
		public void SetSeatManual(int seatManual)
		{
			this.seatManual = seatManual;
		}
		public void SetEngineManual(string engineManual)
		{
			this.engineManual = engineManual;
		}
		public void SetTripComputerManual(string tripComputerManual)
		{
			this.tripComputerManual = tripComputerManual;
		}
		public void SetGPSManual(string gpsManual)
		{
			this.gpsManual = gpsManual;
		}
		public string GetEngineManual()
		{
			return this.engineManual;
		}
		public string GetGPSManual()
		{
			return this.gpsManual;
		}
	}
}

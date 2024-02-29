using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	internal class CarManualBuilder:IBuilder
	{
		private CarManual carManual = null!;
		public CarManualBuilder()
		{
			this.Reset();
		}
		public void Reset()
		{
			this.carManual = new CarManual();
		}
		public void SetSeat(int seat)
		{
			carManual.SetSeatManual(seat);
		}
		public void SetEngine(string engine)
		{
			carManual.SetEngineManual("Instruction for " + engine + ".");
		}
		public void SetTripComputer(string tripComputer)
		{
			carManual.SetTripComputerManual("Instruction for " + tripComputer + ".");
		}
		public void SetGPS(string gps)
		{
			carManual.SetGPSManual("Instruction for " + gps + ".");
		}
		public CarManual GetProduct()
		{
			CarManual product = this.carManual;
			this.Reset();
			return product;
		}
	}
}

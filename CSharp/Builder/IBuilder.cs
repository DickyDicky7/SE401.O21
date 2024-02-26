namespace Builder
{
	internal interface IBuilder
	{
		public void Reset();
		public void SetSeat(int seat);
		public void SetEngine(string engine);
		public void SetTripComputer(string tripComputer);
		public void SetGPS(string gps);
	}
}

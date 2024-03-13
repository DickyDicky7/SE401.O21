using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	internal class Circle : Dot
	{
		protected int radius;
		public Circle(int x, int y, int radius) : base(x, y)
		{
			this.radius = radius;
		}
		public override void Draw()
		{
			Console.WriteLine($"Draw a circle with radius {radius} at ({x},{y})");
		}
	}
}

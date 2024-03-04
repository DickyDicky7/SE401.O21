using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	internal class Circle : Shape
	{
		private float radius;

		public Circle(float radius) : base()
		{
			this.radius = radius;
		}
		public Circle(Circle source) : base()
		{
			this.radius = source.radius;
		}
		public override Shape Clone()
		{
			return new Circle(this);
		}
		public override void Draw()
		{
			Console.WriteLine($"Drawing circle with radius {this.radius}");
		}
	}
}

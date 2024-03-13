using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	internal class Rectangle : Dot
	{
		private int width;
		private int height;
		private float angle;
		public Rectangle(int x, int y, int width, int height, float angle) : base(x, y)
		{
			this.width = width;
			this.height = height;
			this.angle = angle % 360;
		}
		public override void Draw()
		{
			Console.WriteLine($"Draw a rectangle with width {width}, height {height} at ({x},{y}) rotate {angle}");
		}
	}
}

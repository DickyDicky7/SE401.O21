using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	internal class Rectangle: Shape
	{
		private int width;
		private int height;

		public Rectangle(int width, int height) : base()
		{
			this.width = width;
			this.height = height;
		}
		public Rectangle(Rectangle source) : base()
		{
			this.width = source.width;
			this.height = source.height;
		}
		public override Shape Clone()
		{
			return new Rectangle(this);
		}
		public override void Draw()
		{
			Console.WriteLine($"Drawing rectangle with width {this.width} and height {this.height}");
		}
	}
}

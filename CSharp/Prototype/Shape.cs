using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	internal abstract class Shape
	{
		private int x;
		private int y;
		private string color;
		
		public Shape()
		{
			x = 0;
			y = 0;
			color = string.Empty;
		}
		public Shape(Shape source) : this()
		{
			this.x = source.x;
			this.y = source.y;
			this.color = source.color;
		}
		public abstract Shape Clone();
		public abstract void Draw();
	}
}

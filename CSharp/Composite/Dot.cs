﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	internal class Dot : Graphic
	{
		protected int x;
		protected int y;

		public Dot(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public void Move(int x, int y)
		{
			this.x += x;
			this.y += y;
		}
		public virtual void Draw()
		{
			Console.WriteLine($"Draw a dot at ({x},{y})");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	internal class CompoundGraphic : Graphic
	{
		private List<Graphic> children = new();

		public void Add(Graphic a)
		{
			children.Add(a);
		}
		public void Remove(Graphic a)
		{
			children.Remove(a);
		}
		public void Move(int x, int y)
		{
			foreach (Graphic child in children)
			{
				child.Move(x, y);
			}
		}
		public void Draw()
		{
			foreach (Graphic child in children)
			{
				child.Draw();
			}
		}
	}
}

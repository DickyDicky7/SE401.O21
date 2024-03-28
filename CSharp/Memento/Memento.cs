using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	internal class Memento
	{
		private int health;
		private int position;


		public Memento(int health, int position)
		{
			this.health = health;
			this.position = position;
		}
		public int GetHealth()
		{
			return this.health;
		}
		public int GetPosition()
		{
			return this.position;
		}
	}
}

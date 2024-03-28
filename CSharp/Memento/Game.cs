using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	internal class Game
	{
		private int health;
		private int position;

		public Game()
		{
			this.health = 100;
			this.position = 0;
		}
		public void SaveState()
		{
			Memento memento = new Memento(this.health, this.position);
			Caretaker.GetInstance().SaveMemento(memento);
		}
		public void LoadState()
		{
			Memento memento = Caretaker.GetInstance().GetMemento();
			this.health = memento.GetHealth();
			this.position = memento.GetPosition();
		}
		public void Set(int health, int position)
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

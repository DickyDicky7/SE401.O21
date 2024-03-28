using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	internal class Caretaker
	{
		private static Caretaker? instance ;
		private Memento? memento;

		private Caretaker()
		{

		}
		public static Caretaker GetInstance()
		{
			if (instance == null)
				instance = new Caretaker();
			return instance;
		}
		public void SaveMemento(Memento memento)
		{
			this.memento = memento;
		}
		public Memento GetMemento()
		{
			return this.memento!;
		}
	}
}

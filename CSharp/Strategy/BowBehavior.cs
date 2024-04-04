using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	//concrete strategy
	internal class BowBehavior : IWeaponBehavior
	{
		public void Attack()
		{
			Console.WriteLine("You just shot an arrow from your bow");
		}
	}
}

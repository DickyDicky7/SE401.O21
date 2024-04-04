using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	//concrete strategy
	internal class SwordBehavior : IWeaponBehavior
	{
		public void Attack()
		{
			Console.WriteLine("You just swung your sword");
		}
	}
}

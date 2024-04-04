using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	//context
	internal class Player
	{
		public IWeaponBehavior weaponBehavior { get; private set; }
		public Player()
		{
			//start with a sword
			weaponBehavior = new SwordBehavior();
		}
		public void Attack()
		{
			weaponBehavior.Attack();
		}
		public void ChangeWeapon(IWeaponBehavior weaponBehavior)
		{
			this.weaponBehavior = weaponBehavior;
		}
	}
}

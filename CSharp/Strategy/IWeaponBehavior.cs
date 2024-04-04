using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	//strategy interface
	internal interface IWeaponBehavior
	{
		public void Attack();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
	internal interface DamageHandler
	{
		public void ProcessDamage(DamageInfo damageInfo);
	}
}

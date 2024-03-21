using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
	internal class DamageInfo
	{
		public int baseDamage { get; set; }
		public int finalDamage { get; set; }
		public DamageInfo(int baseDamage)
		{
			this.baseDamage = baseDamage;
			this.finalDamage = baseDamage;
		}
	}
}

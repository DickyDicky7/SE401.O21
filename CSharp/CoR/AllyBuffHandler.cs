using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
	internal class AllyBuffHandler : DamageHandlerBase
	{
		private int value;
		public AllyBuffHandler(int value)
		{
			this.value = value;
		}
		public override void ProcessDamage(DamageInfo damageInfo)
		{
			damageInfo.finalDamage += damageInfo.baseDamage * value;
			Console.WriteLine($"Ally buff:" +
				$" baseDmg={damageInfo.baseDamage}," +
				$" finalDmg={damageInfo.finalDamage}");
			nextHandler?.ProcessDamage(damageInfo);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
	internal class EnemyDebuff : DamageHandlerBase
	{
		private int value;
		public EnemyDebuff(int value)
		{
			this.value = value;
		}
		public override void ProcessDamage(DamageInfo damageInfo)
		{
			damageInfo.finalDamage -= value;
			Console.WriteLine($"Enemy debuff: " +
				$"baseDmg={damageInfo.baseDamage}, " +
				$"finalDmg={damageInfo.finalDamage}");
			nextHandler?.ProcessDamage(damageInfo);
		}
	}
}

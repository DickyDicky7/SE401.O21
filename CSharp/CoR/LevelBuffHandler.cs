using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
	internal class LevelBuffHandler : DamageHandlerBase
	{
		private int level;
		private int value;
		public LevelBuffHandler (int level, int value)
		{
			this.level = level;
			this.value = value;
		}
		public override void ProcessDamage(DamageInfo damageInfo)
		{
			damageInfo.finalDamage += level * value ;
			Console.WriteLine($"Level buff: " +
				$"baseDmg={damageInfo.baseDamage}, " +
				$"finalDmg={damageInfo.finalDamage}");
			nextHandler?.ProcessDamage(damageInfo);
		}
	}
}

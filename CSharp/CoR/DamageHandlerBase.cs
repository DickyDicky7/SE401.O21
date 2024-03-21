using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
	internal abstract class DamageHandlerBase : DamageHandler
	{
		protected DamageHandler nextHandler = default!;
		public void SetNext(DamageHandler nextHandler)
		{
			this.nextHandler = nextHandler;
		}
		public abstract void ProcessDamage(DamageInfo damageInfo);
	}
}

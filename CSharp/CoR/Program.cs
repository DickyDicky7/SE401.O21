
namespace CoR
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DamageInfo damageInfo = new DamageInfo(10);

			DamageHandlerBase a = new LevelBuffHandler(10, 3);
			DamageHandlerBase b = new AllyBuffHandler(2);
			DamageHandlerBase c = new EnemyDebuff(25);
			a.SetNext(b);
			b.SetNext(c);

			a.ProcessDamage(damageInfo);
		}
	}
}
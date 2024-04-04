
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Strategy
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Player hero = new Player();
			SwordBehavior sword = new SwordBehavior();
			BowBehavior bow = new BowBehavior();
			while (true)
			{
				Console.Clear();
				Console.WriteLine("1. Attack 2.ChangeWeapon");
				string? choice = Console.ReadLine();
				if (choice == "1")
				{
					hero.Attack();
				}
				else if (choice == "2")
				{
					if (hero.weaponBehavior.GetType() == typeof(SwordBehavior))
					{
						hero.ChangeWeapon(bow);
						Console.WriteLine("You just switched to bow");
					}
					else
					{
						hero.ChangeWeapon(sword);
						Console.WriteLine("You just switched to sword");
					}
				}
				else
				{
					continue;
				}
				Console.WriteLine("Press any key to continue");
				Console.ReadLine();
			}
		}
	}
}
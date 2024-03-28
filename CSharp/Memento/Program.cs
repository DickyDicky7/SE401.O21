namespace Memento
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Game game = new Game();
			game.Set(80, 3);
			//u saved the game
			game.SaveState();
			game.Set(50, 10);
			game.Set(20, 20);
			game.Set(5, 30);
			Console.WriteLine($"Health: {game.GetHealth()} Position: {game.GetPosition()}");
			//u are about to lose, load the save game to play again more careful
			game.LoadState();
			Console.WriteLine($"Health: {game.GetHealth()} Position: {game.GetPosition()}");
		}
	}
}

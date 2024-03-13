
namespace Composite
{
	internal class Program()
	{
		static void Main(string[] args)
		{
			CompoundGraphic CG = new CompoundGraphic();
			CG.Add(new Dot(1, 2));
			CG.Add(new Circle(3, 4, 5));
			CG.Add(new Rectangle(4, 5, 6, 7, 8));
			CompoundGraphic CG1 = new CompoundGraphic();
			CG1.Add(new Dot(2, 3));
			CG1.Add(new Circle(4, 5, 6));
			CG1.Add(new Rectangle(5, 6, 7, 8, 9));
			CG.Add(CG1);

			CG.Draw();
		}
	}
}

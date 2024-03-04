namespace Prototype
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Shape rectangle = new Rectangle(4, 5);
			Shape circle = new Circle(3);

			Shape rectangleClone1 = rectangle.Clone();
			Shape circleClone1 = circle.Clone();

			rectangle.Draw();
			rectangleClone1.Draw();
			circle.Draw();
			circleClone1.Draw();
		}
	}
	internal class PrototypeRegistry
	{
		private List<(string, Shape) > listShape;
		public PrototypeRegistry()
		{
			listShape = new();
		}
		public void AddItem(string id, Shape item)
		{
			listShape.Add(new(id, item));
		}
		public Shape GetById(string id)
		{
			return listShape.Find(x => (x.Item1 == id)).Item2;
		}
	}
}

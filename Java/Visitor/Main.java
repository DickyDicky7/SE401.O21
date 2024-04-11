public class Main {
    public static void main(String[] args) {
        Shape circle = new Circle(5);
        Shape square = new Square(10);

        ShapeVisitor areaVisitor = new AreaVisitor();
        ShapeVisitor perimeterVisitor = new PerimeterVisitor();

        circle.accept(areaVisitor);
        circle.accept(perimeterVisitor);

        square.accept(areaVisitor);
        square.accept(perimeterVisitor);

        System.out.println("Circle area: " + ((AreaVisitor) areaVisitor).getTotalArea());
        System.out.println("Circle perimeter: " + ((PerimeterVisitor) perimeterVisitor).getTotalPerimeter());

        System.out.println("Square area: " + ((AreaVisitor) areaVisitor).getTotalArea());
        System.out.println("Square perimeter: " + ((PerimeterVisitor) perimeterVisitor).getTotalPerimeter());
    }
}
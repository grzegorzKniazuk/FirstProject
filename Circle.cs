using FirstProject.Interfaces;

namespace FirstProject;

public class Circle : Shape, IShape {

    private double Radius { get; set; }

    public Circle(double radius) {
        Radius = radius;
    }

    public static string? Color { get; set; } = "Red";

    public double CalculateArea() {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter() {
        return 2 * Math.PI * Radius;
    }

    public override void Draw() {
        Console.WriteLine("Drawing a shape at ({0}, {1})", X, Y);
    }
}
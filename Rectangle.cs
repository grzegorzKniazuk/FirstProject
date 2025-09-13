using FirstProject.Interfaces;

namespace FirstProject;

public class Rectangle: Shape, IShape {
    
    private double SideLength { get; set; }

    public Rectangle(double sideLength) {
        SideLength = sideLength;
    }

    public static string? Color { get; set; } = "Green";

    public double CalculateArea() {
        return SideLength * SideLength;
    }

    public double CalculatePerimeter() {
        return 4 * SideLength;
    }
    
    public override void Draw() {
        Console.WriteLine("Drawing a shape at ({0}, {1})", X, Y);
    }
}
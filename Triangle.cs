using FirstProject.Interfaces;

namespace FirstProject;

public class Triangle: Shape, IShape {
    
    private double SideLength { get; set; }

    public Triangle(double sideLength) {
        SideLength = sideLength;
    }

    public double CalculateArea() {
        return (Math.Sqrt(3) / 4) * SideLength * SideLength;
    }

    public double CalculatePerimeter() {
        return 3 * SideLength;
    }

    public override void Draw() {
        Console.WriteLine("Drawing a shape at ({0}, {1})", X, Y);
    }
}
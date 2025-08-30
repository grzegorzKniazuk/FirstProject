using FirstProject.Interfaces;

namespace FirstProject;

public class Circle: IShape {
    
    private double Radius { get; set; }

    public Circle(double radius) {
        Radius = radius;
    }
    
    public double CalculateArea() {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter() {
        return 2 * Math.PI * Radius;
    }
}
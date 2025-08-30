using FirstProject.Interfaces;

namespace FirstProject;

public class Square: IShape {
    
    private double SideLength { get; set; }

    public Square(double sideLength) {
        SideLength = sideLength;
    }
    
    public double CalculateArea() {
        return SideLength * SideLength;
    }

    public double CalculatePerimeter() {
        return 4 * SideLength;
    }
}
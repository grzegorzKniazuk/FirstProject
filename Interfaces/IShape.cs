namespace FirstProject.Interfaces;

public interface IShape {
    
    public static abstract string? Color { get; set; }
    
    public static virtual bool operator >(IShape shape1, IShape shape2) {
        return shape1.CalculateArea() > shape2.CalculateArea();
    }
    
    public static virtual bool operator <(IShape shape1, IShape shape2) {
        return shape1.CalculateArea() < shape2.CalculateArea();
    }
    
    public double CalculateArea();
    public double CalculatePerimeter();
}
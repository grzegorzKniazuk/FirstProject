namespace FirstProject;

public class Shape {
    
    public int X { get; set; }
    public int Y { get; set; }
    
    // virtual method to be overridden in derived classes
    public virtual void Draw() {
        Console.WriteLine("Drawing a shape at ({0}, {1})", X, Y);
    }
}
namespace FirstProject;

public class WordFileObj : FileObj {
    
    public void Print() {
        Console.WriteLine($"Printing Word file: {FileName}");
    }
    
    public override void Compress() {
        Console.WriteLine($"Compressing Word file: {FileName}");
    }
}
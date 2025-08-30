namespace FirstProject;

public class PowerPointFile: File {
    
    public void Present() {
        Console.WriteLine($"Presenting PowerPoint file: {FileName}");
    }
    
    public override void Compress() {
        Console.WriteLine($"Compressing PowerPoint file: {FileName}");
    }
}
namespace FirstProject;

public class PowerPointFileObj: FileObj {
    
    public void Present() {
        Console.WriteLine($"Presenting PowerPoint file: {FileName}");
    }
    
    public override void Compress() {
        Console.WriteLine($"Compressing PowerPoint file: {FileName}");
    }
}
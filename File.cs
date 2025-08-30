using FirstProject.Interfaces;

namespace FirstProject;

public abstract class File: IFile {
    
    public required string FileName { get; init; }
    public required int Size { get; set; }
    public required DateTime CreatedAt { get; set; }
    
    public abstract void Compress();
}
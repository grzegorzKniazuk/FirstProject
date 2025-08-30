namespace FirstProject.Interfaces;

public interface IFile {
    
    string FileName { get; init; }
    int Size { get; set; }
    DateTime CreatedAt { get; set; }
    
    void Compress();
}
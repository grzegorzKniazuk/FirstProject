namespace FirstProject;

public class DisposableClass: IDisposable {
    
    // Dispose method to release resources
    public void Dispose() {
        // Cleanup code here
        Console.WriteLine("Resources cleaned up.");
    }
}
namespace FirstProject;

public class ExelFile: File {
    
    public void GenerateReport() {
        Console.WriteLine($"Generating report for Excel file: {FileName}");
    }
}
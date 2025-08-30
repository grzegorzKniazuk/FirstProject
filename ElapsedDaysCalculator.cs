namespace FirstProject;

public class ElapsedDaysCalculator {
    
    public static void GetElapsedDays() {
        Console.WriteLine("Enter your date of birth (yyyy-MM-dd):");
        
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth)) {
            DateTime currentDate = DateTime.Now;
            TimeSpan elapsed = currentDate - dateOfBirth;
            int elapsedDays = (int)elapsed.TotalDays;
            
            Console.WriteLine($"You have lived for {elapsedDays} days.");
        } else {
            Console.WriteLine("Invalid date format. Please use yyyy-MM-dd.");
        }
    }
}
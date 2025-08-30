namespace FirstProject;

public class BmiCalculator {
    public static void CalculateBmi() {
        Console.WriteLine("Kalkulator BMI");
        Console.Write("Podaj swoją masę ciała (w kg): ");

        string massString = Console.ReadLine();
        double mass = double.Parse(massString);

        Console.WriteLine("Podaj swój wzrost (w metrach): ");
        string heightString = Console.ReadLine();
        double height = double.Parse(heightString);

        double bmi = mass / (height * height);

        Console.WriteLine("Twoje BMI wynosi: " + bmi);

        if (bmi < 18.5) {
            Console.WriteLine("Niedowaga");
        }
        else if (bmi >= 18.5 && bmi < 24.9) {
            Console.WriteLine("Waga prawidłowa");
        }
        else if (bmi >= 25 && bmi < 29.9) {
            Console.WriteLine("Nadwaga");
        }
        else {
            Console.WriteLine("Otyłość");
        }
    }
}
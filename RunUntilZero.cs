namespace FirstProject;

public class RunUntilZero {

    public static void Play() {
        int input;
        int sum = 0;

        do {
            Console.WriteLine("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out input)) {
                sum += input;
                Console.WriteLine($"Current sum: {sum}");
            }
            else {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        } while (input != 0);
    }
}
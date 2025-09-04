using System.Text;

namespace FirstProject;

public class StringManipulation {
    public static void Substring(string userInput) {
        if (userInput.Length >= 5) {
            string substring = userInput.Substring(0, 5);
            Console.WriteLine("The first 5 characters of your input are: " + substring);
        }
        else {
            Console.WriteLine("Your input is less than 5 characters long.");
        }
    }

    public static void Replace(string userInput) {
        string replacedString = userInput.Replace("a", "@").Replace("e", "3").Replace("i", "1").Replace("o", "0");
        Console.WriteLine("Your input with replacements: " + replacedString);
    }

    public static void Modify(string userInput) {
        string modifiedString = userInput.Remove(0, 2).Trim().ToUpper();
        modifiedString = userInput.Insert(5, "INSERTED_TEXT");
        Console.WriteLine("Your modified input: " + modifiedString);
    }
    
    public static void AlterTextCase(string userInput) {
        string alteredString = userInput.ToLower();
        Console.WriteLine("Your input in lowercase: " + alteredString);
        
        alteredString = userInput.ToUpper();
        Console.WriteLine("Your input in uppercase: " + alteredString);
    }

    public static void Split(string userInput) {
        string[] splitArray = userInput.Split(' ');
        
        Console.WriteLine("Your input split into words:");
        
        foreach (string word in splitArray) {
            Console.WriteLine(word);
        }
    }
    
    public static void IsTxtFile(string userInput) {
        if (userInput.EndsWith(".txt")) {
            Console.WriteLine("The input ends with .txt");
        } else {
            Console.WriteLine("The input does not end with .txt");
        }
    }
    
    public static string CamelCaseToKebabCase(string input) {
        if (string.IsNullOrEmpty(input)) {
            return input;
        }

        var result = new StringBuilder();
        
        foreach (char c in input) {
            if (char.IsUpper(c) && result.Length > 0) {
                result.Append('-');
            }
            result.Append(char.ToLower(c));
        }
        return result.ToString();
    }

    public static string KebabCaseToCamelCase(string input) {
        if (string.IsNullOrEmpty(input)) {
            return input;
        }
        
        var result = new StringBuilder();

        foreach (char c in input) {
            if (c == '-') {
                result.Append(char.ToUpper(c));
            } else {
                result.Append(c);
            }
        }
        
        return result.ToString();
    }
}
using System.Text;
using System.Text.RegularExpressions;
using FirstProject.Enums;

namespace FirstProject {
    
    #region ProgramClassRegion
    class Program {
        /// <summary>
        ///    The main entry point for the application.
        /// </summary>
        /// <param name="args">args description</param>
        static void Main(string[] args) {
            Console.WriteLine("Type in your name:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! Welcome to the First Project.");

            string someText = "This is a sample text.";
            Console.WriteLine(someText);

            char firstChar = someText[0];
            Console.WriteLine("The first character of the text is: " + firstChar);

            bool isSample = someText.Contains("sample");
            Console.WriteLine("Does the text contain the word 'sample'? " + isSample);

            // dates
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDate);

            DateTime dateOfBirth = new DateTime(1991, 2, 25);
            Console.WriteLine("Date of birth: " + dateOfBirth);

            byte numberAsByte = 255;
            Console.WriteLine("A byte value: " + numberAsByte);

            // numbers
            float numberAsFloat = 25.4f;
            Console.WriteLine("A float value: " + numberAsFloat);

            decimal numberAsDecimal = 25.4M;
            Console.WriteLine("A decimal value: " + numberAsDecimal);

            double numberAsDouble = 25.4;
            Console.WriteLine("A double value: " + numberAsDouble);

            // strings
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full name: " + fullName);

            // concatenation
            string text = $"My name is {fullName} and I was born on {dateOfBirth.ToShortDateString()}";
            Console.WriteLine(text);

            // verbatim string
            string windowsPath = @"C:\Users\JohnDoe\Documents";
            Console.WriteLine("Windows path: " + windowsPath);

            // string builder
            StringBuilder stringBuilder = new StringBuilder("This is a string built with StringBuilder.");
            stringBuilder.Append(" It allows efficient string manipulation.");
            Console.WriteLine(stringBuilder.ToString());

            // conditional statements
            Console.WriteLine("Year of birth:");
            string userInput = Console.ReadLine();
            int yearOfBirth;

            // safe type conversion
            if (int.TryParse(userInput, out yearOfBirth)) {
                bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18;

                if (isUserOver18) {
                    Console.WriteLine("You are over 18 years old.");
                }
                else {
                    Console.WriteLine("You are not over 18 years old.");
                }

                int age = DateTime.Now.Year - yearOfBirth;

                Console.WriteLine("Your age is: " + age);
            }
            else {
                Console.WriteLine("You didn't enter a valid year.");
            }

            // switch statement
            switch (DateTime.Now.DayOfWeek) {
                case DayOfWeek.Monday: {
                    Console.WriteLine("It's Monday!");
                    break;
                }
                case DayOfWeek.Friday: {
                    Console.WriteLine("It's Friday!");
                    break;
                }
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday: {
                    Console.WriteLine("It's Saturday!");
                    break;
                }
                default: {
                    Console.WriteLine("The middle of the week.");
                    break;
                }
            }

            // type cast
            byte valueAsByte = 10;
            int valueAsInt = (int)valueAsByte;
            Console.WriteLine("Value as int: " + valueAsInt);

            double valueAsDouble = 9.78;
            int valueAsIntFromDouble = (int)valueAsDouble; // Explicit cast from double
            Console.WriteLine("Value as int from double: " + valueAsIntFromDouble);

            string valueAsString = "123";
            int valueAsIntFromString = int.Parse(valueAsString); // Convert string to int
            Console.WriteLine("Value as int from string: " + valueAsIntFromString);

            // arrays
            // arrays have fixed size!
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int numberOfCars = cars.Length;

            Console.WriteLine("First car: " + cars[0]);
            Console.WriteLine("Number of cars: " + numberOfCars);

            cars[2] = "Toyota";
            Console.WriteLine("Updated third car: " + cars[2]);

            // loops
            // while
            int i = 0;
            while (i < numberOfCars) {
                Console.WriteLine("Car " + (i + 1) + ": " + cars[i]);
                i++;
            }

            // do while
            int j = 0;
            do {
                Console.WriteLine("Car (do while) " + (j + 1) + ": " + cars[j]);
                j++;
            } while (j < numberOfCars);

            // for
            for (int k = 0; k < numberOfCars; k++) {
                Console.WriteLine("Car (for) " + (k + 1) + ": " + cars[k]);
            }

            // foreach
            foreach (string car in cars) {
                Console.WriteLine("Car (foreach): " + car);
            }

            // enum
            Console.WriteLine("What is your gender? 1 - Male, 2 - Female");

            string genderInput = Console.ReadLine();

            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderInput);

            if (gender == Gender.Male) {
                Console.WriteLine("Only woman are allowed.");
            }
            else {
                Console.WriteLine("Welcome, ma'am!");
            }

            // nullable types
            int? nullableInt = null;

            if (nullableInt.HasValue) {
                Console.WriteLine("Nullable int has value: " + nullableInt.Value);
            }

            // try catch finally
            try {
                cars[5] = "Chevrolet"; // This will throw an exception
            }
            catch (IndexOutOfRangeException) {
                Console.WriteLine("Handling IndexOutOfRangeException");
            }
            catch (Exception) {
                Console.WriteLine("Handling any exception.");
            }
            finally {
                Console.WriteLine("Execution of try-catch block is finished.");
            }

            ElapsedDaysCalculator.GetElapsedDays();

            // regex
            Regex regex = new Regex(@"^([a-z0-9]+)\.?([a-z0-9]+)@([a-z]+)\.[a-z]{2,3}$");
            Console.WriteLine("Type in your email address:");
            string emailInput = Console.ReadLine();

            if (regex.IsMatch(emailInput)) {
                Console.WriteLine("The email address is valid.");
            }
            else {
                Console.WriteLine("The email address is not valid.");
            }

            // classes
            Person bill = new Person("Bill", "Gates");
            bill.SetDateOfBirth(new DateTime(1992, 5, 15));
            bill.SayHello();

            Person steve = new Person(new DateTime(1991, 2, 25), "Steve", "Jobs");
            steve.SayHello();

            Console.WriteLine("Number of people created: " + Person.Count);

            // inheritance
            ExelFile exelFile = new ExelFile {
                FileName = "FinancialReport.xlsx",
                Size = 2048,
                CreatedAt = DateTime.Now.AddDays(-10)
            };
            exelFile.GenerateReport();

            WordFile wordFile = new WordFile {
                FileName = "ProjectProposal.docx",
                Size = 1024,
                CreatedAt = DateTime.Now.AddDays(-5)
            };
            wordFile.Print();

            PowerPointFile powerPointFile = new PowerPointFile {
                FileName = "SalesPresentation.pptx",
                Size = 3072,
                CreatedAt = DateTime.Now.AddDays(-2)
            };
            powerPointFile.Present();

            // lists
            List<Person> people = new List<Person> { bill, steve };
            people.Add(new Person("Elon", "Musk"));
            
            Console.WriteLine("People in the list:");
            foreach (var person in people) {
                person.SayHello();
            }
            
            // linq
            List<Person> employees = new List<Person>() {
                new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
                new Person(new DateTime(1995, 6, 3), "John", "Wick"),
                new Person(new DateTime(1996, 4, 3), "Bob", "Wick"),
                new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
                new Person(new DateTime(2000, 2, 2), "John", "Smith"),
                new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
                new Person(new DateTime(2003, 2, 2), "Ed", "Smith"),
            };
            
            List<Person> youngEmployees = employees.Where(e => e.GetAge() < 30).OrderBy(e => e.LastName).ThenBy(e => e.FirstName).ToList();
            
            Console.WriteLine("Young employees (under 30):");
            foreach (var emp in youngEmployees) {
                emp.SayHello();
            }

            // dictionaries
            Dictionary<string, string> countryCapitals = new Dictionary<string, string> {
                { "USA", "Washington, D.C." },
                { "UK", "London" },
                { "France", "Paris" }
            };

            Console.WriteLine("Country capitals:");
            foreach (var kvp in countryCapitals) {
                Console.WriteLine($"The capital of {kvp.Key} is {kvp.Value}");
            }
            
            countryCapitals.TryAdd("Germany", "Berlin"); // Add new entry
            Console.WriteLine("The capital of Germany is " + countryCapitals["Germany"]);

            if (countryCapitals.TryGetValue("Spain", out string capitalOfSpain)) {
                Console.WriteLine("The capital of Spain is " + capitalOfSpain);
            }
            else {
                Console.WriteLine("Spain is not in the dictionary.");
            }
            
            countryCapitals.Remove("France");
            Console.WriteLine("Removed France from the dictionary.");
            
            // yield return
            Console.WriteLine("Yielded data:");
            foreach (var number in GetYieldedData()) {
                Console.WriteLine(number);
            }
        }
        
        private static IEnumerable<int> GetYieldedData() {
            for (int i = 0; i < 10; i++) {
                yield return i;

                if (i % 2 == 0) {
                    yield return i * 10;
                }

                if (i % 8 == 0) {
                    yield break;
                    
                }
            }
        }
    }
    #endregion
}
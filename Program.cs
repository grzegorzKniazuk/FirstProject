using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using CsvHelper;
using FirstProject.Enums;
using Newtonsoft.Json;

namespace FirstProject {
    #region ProgramClassRegion

    public delegate void Display(string value);
    
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
            ExelFileObj exelFileObj = new ExelFileObj {
                FileName = "FinancialReport.xlsx",
                Size = 2048,
                CreatedAt = DateTime.Now.AddDays(-10)
            };
            exelFileObj.GenerateReport();

            WordFileObj wordFileObj = new WordFileObj {
                FileName = "ProjectProposal.docx",
                Size = 1024,
                CreatedAt = DateTime.Now.AddDays(-5)
            };
            wordFileObj.Print();

            PowerPointFileObj powerPointFileObj = new PowerPointFileObj {
                FileName = "SalesPresentation.pptx",
                Size = 3072,
                CreatedAt = DateTime.Now.AddDays(-2)
            };
            powerPointFileObj.Present();

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

            // ref and out
            int originalValue = 10;
            Console.WriteLine("Original value before method call: " + originalValue);
            Double(ref originalValue);
            Console.WriteLine("Original value after method call: " + originalValue);

            int value = 5;
            int factor = 2;
            int remainder;

            if (IsDivisible(value, factor, out remainder)) {
                Console.WriteLine($"{value} is divisible by {factor}.");
            }
            else {
                Console.WriteLine($"{value} is not divisible by {factor}. Remainder: {remainder}");
            }

            Console.WriteLine("Type in a number:");
            string? input = Console.ReadLine();

            if (IsBelowZero(input, out int parsedNumber)) {
                if (parsedNumber < 0) {
                    Console.WriteLine("The number is below zero.");
                }
            }

            // reference type equality
            Person person1 = new Person("Alice", "Johnson");
            Person person2 = new Person("Alice", "Johnson");
            Person person3 = person1;

            Console.WriteLine("person1 == person2: " + (person1 == person2)); // True, different reference but overloaded ==
            Console.WriteLine("person1 == person3: " + (person1 == person3)); // True, same reference
            Console.WriteLine("person1.Equals(person2): " + person1.Equals(person2)); // False, unless Equals is overridden
            Console.WriteLine("person1.Equals(person3): " + person1.Equals(person3)); // True

            // files and directories
            // read from file
            var document1 = File.ReadAllText(@"C:\Projekty - dotnet\FirstProject\sample.txt");
            var document2 = File.ReadAllLines(@"C:\Projekty - dotnet\FirstProject\sample.txt");

            Console.WriteLine("Content of sample.txt:");
            Console.WriteLine(document1);

            Console.WriteLine("Content of sample.txt:");
            foreach (var line in document2) {
                Console.WriteLine(line);
            }

            // write to file
            var template = File.ReadAllText(@"C:\Projekty - dotnet\FirstProject\template.txt");
            var output = template.Replace("{name}", "John Doe").Replace("{orderNumber}", "12345").Replace("{dateTime}", DateTime.Now.ToString());

            File.WriteAllText(@"C:\Projekty - dotnet\FirstProject\output.txt", output);

            // json serialization
            var player = new Player {
                Name = "Mario",
                Level = 1,
                HealthPoints = 100,
                Statistics = [
                    new Statistic {
                        Name = "Strength",
                        Points = 10
                    },

                    new Statistic {
                        Name = "Intelligence",
                        Points = 10
                    }
                ]
            };

            var serializedPlayer = JsonConvert.SerializeObject(player);
            File.WriteAllText(@"C:\Projekty - dotnet\FirstProject\player.json", serializedPlayer);
            
            // json deserialization
            var jsonFromFile = File.ReadAllText(@"C:\Projekty - dotnet\FirstProject\player.json");
            var deserializedPlayer = JsonConvert.DeserializeObject<Player>(jsonFromFile);
            Console.WriteLine("Deserialized player name: " + deserializedPlayer?.Name);
            
            // using statement
            // automatically calls Dispose() method on the object
            // typically used for file and network operations
            using var reader = new StreamReader(@"C:\Projekty - dotnet\FirstProject\sample.txt");
            var content = reader.ReadToEnd();
            Console.WriteLine("Content read using StreamReader:");
            Console.WriteLine(content);
            
            // linq
            string csvPath = @"C:\Projekty - dotnet\FirstProject\googleplaystore.csv";
            var googleApps = LoadGoogleAps(csvPath);

            // Display(googleApps);
            // GetData(googleApps);
            // DisplayData(googleApps);
            // OrderData(googleApps);
            // DataSetOperations(googleApps);
            // VerifyData(googleApps);
            // GroupData(googleApps);
            
            // generic types
            // generic list
            List<int> numbers = [1, 2, 3, 4, 5];
            
            var restaurants = new List<Restaurant>();
            var results = new PaginatedResult<Restaurant>();
            results.Results = restaurants;
            
            var filmTitlesRepository = new Repository<User>();
            filmTitlesRepository.Add(new User(){ Id = 1 });
            filmTitlesRepository.Add(new User(){ Id = 2 });
            var firstUser = filmTitlesRepository.GetByIndex(0);
            Console.WriteLine("First user ID from repository: " + firstUser?.Id);
            
            var userRepository = new Repository<string, Person>();
            userRepository.Add("user1", new Person("Alice", "Johnson"));
            userRepository.Add("user2", new Person("Bob", "Smith"));
            
            int[] arrayOfInts = [1, 2, 3];
            Utils.Swap(ref  arrayOfInts[0], ref arrayOfInts[1]);
            Console.WriteLine("After swap: " + string.Join(", ", arrayOfInts));
            
            // delegate
            Display displayMethod = Console.WriteLine;
            DisplayNumbers(numbers, displayMethod);
        }

        public static void DisplayNumbers(IEnumerable<int> numbers, Display displayMethod) {
            foreach (var number in numbers) {
                displayMethod(number.ToString());
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

        private static void Double(ref int value) {
            value *= 2;
            Console.WriteLine("Doubled value (inside method): " + value);
        }

        private static bool IsDivisible(int value, int factor, out int remainder) {
            remainder = value % factor;

            return remainder == 0;
        }

        private static bool IsBelowZero(string input, out int result) {
            if (int.TryParse(input, out result)) {
                return result < 0;
            }

            return false;
        }

        // file system
        private static void ScanAndAppend() {
            Directory.GetFiles(@"C:\Projekty - dotnet\FirstProject", "*.txt").ToList().ForEach(filename => { File.AppendAllText(@"C:\Projekty - dotnet\FirstProject\all.txt", "All rights reserved."); });
        }
        
        private static void GetData(IEnumerable<GoogleApp> googleApps) {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating >= 4.6).Where(app => app.Category == Category.BEAUTY);
            // first - zwraca pierwszy element lub domyślną wartość, jeśli kolekcja jest pusta
            var firstHighRatedBeautyApp = highRatedBeautyApps.FirstOrDefault(app => app.Reviews < 300);

            // last - zwraca ostatni element lub domyślną wartość, jeśli kolekcja jest pusta
            var lastHighRatedBeautyApp = highRatedBeautyApps.LastOrDefault(app => app.Reviews < 300);

            // single - zwraca jeden element lub domyślną wartość, jeśli nie ma dokładnie jednego elementu
            var singleHighRatedBeautyApp = highRatedBeautyApps.SingleOrDefault(app => app.Reviews < 300);

            Display(firstHighRatedBeautyApp);
            Display(lastHighRatedBeautyApp);
            Display(singleHighRatedBeautyApp);
        }

        private static void DisplayData(IEnumerable<GoogleApp> googleApps) {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating >= 4.6).Where(app => app.Category == Category.BEAUTY);
            // Projekcja - wybieranie określonych właściwości z obiektów
            // Wybieranie jednej właściwości
            var highRatedBeautyAppsNames = highRatedBeautyApps.Select(app => app.Name);

            // Projekcja do innego typu
            // DTO - Data Transfer Object
            var dtos = highRatedBeautyApps.Select(app => new GoogleAppDto { Name = app.Name, Reviews = app.Reviews });
            // Anonimowe typy
            var anonymousDtos = highRatedBeautyApps.Select(app => new { app.Name, app.Reviews });

            // SelectMany - spłaszcza kolekcję kolekcji do jednej kolekcji
            var genres = highRatedBeautyApps.SelectMany(app => app.Genres);
            
            Console.WriteLine(string.Join(", ", highRatedBeautyAppsNames));
        }
        
        private static void DivideData(IEnumerable<GoogleApp> googleApps) {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating >= 4.6).Where(app => app.Category == Category.BEAUTY);
            
            var first5HighRatedBeautyApps = highRatedBeautyApps.Take(5);
            var skip5HighRatedBeautyApps = highRatedBeautyApps.Skip(5);
            // TakeWhile - pobiera elementy z kolekcji dopóki warunek jest spełniony
            var firstHighRatedBeautyApp = highRatedBeautyApps.TakeWhile(app => app.Reviews > 1000);
        }

        private static void OrderData(IEnumerable<GoogleApp> googleApps) {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating >= 4.6).Where(app => app.Category == Category.BEAUTY);
            // OrderBy - sortuje rosnąco
            // OrderByDescending - sortuje malejąco
            // ThenBy - sortuje rosnąco po drugim kryterium
            // ThenByDescending - sortuje malejąco po drugim kryterium
            var orderedByName = highRatedBeautyApps.OrderBy(app => app.Name);
            var orderedByReviewsDesc = highRatedBeautyApps.OrderByDescending(app => app.Reviews);
            var orderedByRatingThenByReviews = highRatedBeautyApps.OrderByDescending(app => app.Rating).ThenByDescending(app => app.Reviews);
            
            Display(orderedByName);
            Display(orderedByReviewsDesc);
            Display(orderedByRatingThenByReviews);
        }
        
        private static void DataSetOperations(IEnumerable<GoogleApp> googleApps) {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating >= 4.6).Where(app => app.Category == Category.BEAUTY);
            var highRatedGamesApps = googleApps.Where(app => app.Rating >= 4.6).Where(app => app.Category == Category.GAME);
            
            // Distinct - usuwa duplikaty
            var distinctCategories = googleApps.Select(app => app.Category).Distinct();
            // Union - łączy dwie kolekcje i usuwa duplikaty
            var union = highRatedBeautyApps.Union(highRatedGamesApps);
            // Intersect - zwraca wspólne elementy dwóch kolekcji
            var intersect = highRatedBeautyApps.Intersect(highRatedGamesApps);
            // Except - zwraca elementy z pierwszej kolekcji, które nie występują w drugiej kolekcji
            var except = highRatedBeautyApps.Except(highRatedGamesApps);

            foreach (var distinctCategory in distinctCategories) {
               Console.WriteLine("Category: " + distinctCategory);
            }
            Display(union);
            Display(intersect);
            Display(except);
        }
        
        private static void VerifyData(IEnumerable<GoogleApp> googleApps) {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating >= 4.6).Where(app => app.Category == Category.BEAUTY);
            // All - sprawdza, czy wszystkie elementy spełniają warunek
            var allHighRatedBeautyAppsHaveMoreThan100Reviews = highRatedBeautyApps.All(app => app.Reviews > 100);
            // Any - sprawdza, czy przynajmniej jeden element spełnia warunek
            var anyHighRatedBeautyAppHasMoreThan10000Reviews = highRatedBeautyApps.Any(app => app.Reviews > 10000);
            // Contains - sprawdza, czy kolekcja zawiera dany element
            var containsApp = highRatedBeautyApps.Contains(new GoogleApp { Name = "My App" }); // Wymaga nadpisania Equals i GetHashCode w klasie GoogleApp

            Console.WriteLine("All high rated beauty apps have more than 100 reviews: " + allHighRatedBeautyAppsHaveMoreThan100Reviews);
            Console.WriteLine("Any high rated beauty app has more than 10000 reviews: " + anyHighRatedBeautyAppHasMoreThan10000Reviews);
            Console.WriteLine("Contains app: " + containsApp);
        }

        private static void GroupData(IEnumerable<GoogleApp> googleApps) {
            // GroupBy - grupuje elementy według klucza
            var groupedByCategory = googleApps.GroupBy(app => app.Category);
            // Grupowanie według wielu kluczy
            var groupedByCategoryAndType = googleApps.GroupBy(app => new { app.Category, app.Type });
            
            // Pobieranie konkretnej grupy
            var artAndDesignApps = groupedByCategory.First(group => group.Key == Category.ART_AND_DESIGN).ToList();
            
            foreach (var group in groupedByCategory) {
                Console.WriteLine("Category: " + group.Key);
                
                // czy wszystkie aplikacje w danej kategorii mają ocenę powyżej 4.0
                var allHighRated = group.All(app => app.Rating > 4.0);
                Console.WriteLine("\tAll high rated: " + allHighRated);
                
                // srednia liczba recenzji w danej kategorii
                var averageReviews = group.Average(app => app.Reviews);
                Console.WriteLine("\tAverage reviews: " + averageReviews);
                
                // liczba aplikacji w danej kategorii
                var count = group.Count();
                Console.WriteLine("\tCount: " + count);
                
                // maksymalna liczba recenzji w danej kategorii
                var maxReviews = group.Max(app => app.Reviews);
                Console.WriteLine("\tMax reviews: " + maxReviews);
                
                // minimalna liczba recenzji w danej kategorii
                var minReviews = group.Min(app => app.Reviews);
                Console.WriteLine("\tMin reviews: " + minReviews);
                
                // suma recenzji w danej kategorii
                var sumReviews = group.Sum(app => app.Reviews);
                Console.WriteLine("\tSum reviews: " + sumReviews);
                
                // wyświetlanie aplikacji w danej kategorii
                foreach (var app in group) {
                    Console.WriteLine("\t" + app);
                }
            }
        }
        
        static void Display(IEnumerable<GoogleApp> googleApps) {
            foreach (var googleApp in googleApps) {
                Console.WriteLine(googleApp);
            }
        }

        static void Display(GoogleApp googleApp) {
            Console.WriteLine(googleApp);
        }

        static List<GoogleApp> LoadGoogleAps(string csvPath) {
            using var reader = new StreamReader(csvPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<GoogleAppMap>();
            var records = csv.GetRecords<GoogleApp>().ToList();

            return records;
        }
    }

    #endregion
}
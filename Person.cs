namespace FirstProject;

public class Person {

    public static int Count = 0;
    
    // reflection attribute
    [DisplayProperty("First Name")]
    public readonly string FirstName;
    
    // reflection attribute
    [DisplayProperty("Last Name")]
    public readonly string LastName;
    
    private DateTime _dateOfBirth;
    
    /*
    // property
    private string _contactNumber;
    public string ContactNumber {
        get { return _contactNumber; }
        set {
            if (value.Length < 9) {
               Console.WriteLine("The contact number is too short.");
            }
            else {
                _contactNumber = value;
            }
        }
    }
    public string ContactNumber { get; set; } // auto-implemented property
    */
    
    // constructor
    public Person(string firstName, string lastName) {
        FirstName = firstName;
        LastName = lastName;
        Count++;
    }

    // constructor overloading
    public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName) {
        SetDateOfBirth(dateOfBirth);
    }

    public void SayHello() {
        Console.WriteLine($"Hello, my name is {FirstName} {LastName} and I was born on {_dateOfBirth.ToShortDateString()}.");
    }

    public void SetDateOfBirth(DateTime date) {
        if (date > DateTime.Now) {
            Console.WriteLine("The date is greater than the future.");
        }
        else {
            _dateOfBirth = date;
        }
    }

    public int GetAge() {
        var today = DateTime.Today;
        var age = today.Year - _dateOfBirth.Year;

        if (_dateOfBirth.Date > today.AddYears(-age)) {
            age--;
        }
        
        return age;
    }

    public DateTime GetDateOfBirth() => _dateOfBirth;

    // override Equals method
    public override bool Equals(object? obj) {
        if (obj == null) {
            return false;
        }

        if (GetType() != obj.GetType()) {
            return false;
        }
        
        Person other = (Person)obj;
        
        return FirstName == other.FirstName && LastName == other.LastName && _dateOfBirth == other._dateOfBirth;
    }

    // override operator
    public static bool operator ==(Person a, Person b) {
        return Equals(a, b);
    }

    public static bool operator !=(Person a, Person b) {
        return !(a == b);
    }
    
    // override GetHashCode method
    public override int GetHashCode() {
        return HashCode.Combine(FirstName, LastName);
    }

    public int CalculateSalary() {
        return Calculator.Add(1000, 2000);
    }
}

file abstract class Calculator {
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static double Divide(int a, int b) => (double)a / b;
}
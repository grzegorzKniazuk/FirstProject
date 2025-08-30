namespace FirstProject;

public class Person {

    public static int Count = 0;
    
    public string FirstName;
    public string LastName;
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

    public DateTime GetDateOfBirth() => _dateOfBirth;
}
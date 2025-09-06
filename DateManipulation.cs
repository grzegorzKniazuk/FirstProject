using System.Diagnostics;

namespace FirstProject;

public class DateManipulation {

    public static void DateTimeModification() {
        DateTime now = DateTime.Now;
        DateTime birthday = new DateTime(1991, 2, 25);
        
        TimeSpan result = now - birthday;
        
        Console.WriteLine(result.Days);
        Console.WriteLine(result.TotalDays);
        
        Console.WriteLine(now.AddDays(10));
        Console.WriteLine(now.AddHours(5));
        Console.WriteLine(now.AddMonths(3));
        Console.WriteLine(now.AddYears(2));
        
        DateTime expiresAt = now.AddDays(7);
        DateTime expiresAt2 = now.Add(new TimeSpan(7,0,0,0));
        
        Console.WriteLine(expiresAt);
        Console.WriteLine(expiresAt2);
        
        bool expiresAtTheSameDay = expiresAt.Date == expiresAt2.Date;
        
        Console.WriteLine(expiresAtTheSameDay); // true
    }

    public static void DateTimeFormatting() {
        Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
    }
    
    public static void TimeMeasurement() {
        // by TimeSpan
        DateTime start = DateTime.Now;
        
        // Code to be measured
        for (int i = 0; i < 1000000; i++) {
            var x = Math.Sqrt(i);
        }
        
        DateTime end = DateTime.Now;
        
        TimeSpan duration = end - start;
        
        Console.WriteLine($"Duration: {duration.TotalMilliseconds} ms");
        
        // by Stopwatch
        Stopwatch stopwatch = Stopwatch.StartNew();
        // Code to be measured
        
        for (int i = 0; i < 1000000; i++) {
            var x = Math.Sqrt(i);
        }
        
        stopwatch.Stop();
        Console.WriteLine($"Duration with Stopwatch: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
    
    public static void DateTimeHelpers() {
        DateTime now = DateTime.Now;
        
        Console.WriteLine(now.DayOfWeek); // Day of the week
        Console.WriteLine(now.DayOfYear); // Day of the year
        
        DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
        Console.WriteLine(firstDayOfMonth);
        
        DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
        Console.WriteLine(lastDayOfMonth);
        
        int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
        Console.WriteLine(daysInMonth);
        
        bool isLeapYear = DateTime.IsLeapYear(now.Year);
        Console.WriteLine(isLeapYear);
    }
    
    public static bool IsDateBetween(DateTime date, DateTime from, DateTime to) {
        return date >= from && date <= to;
    }
}
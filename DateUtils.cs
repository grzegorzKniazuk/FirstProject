namespace FirstProject;

public static class DateUtils {
    
    // extension method
    public static bool IsBetween(this DateTime date, DateTime from, DateTime to) {
        return date >= from && date <= to;
    }
}
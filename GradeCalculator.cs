namespace FirstProject;

public class GradeCalculator {
    public static string CalculateGrade(double percentage) {
        if (percentage > 90) {
            return "A";
        }
        else if (percentage > 80) {
            return "B";
        }
        else if (percentage > 70) {
            return "C";
        }
        else if (percentage > 60) {
            return "D";
        }
        else {
            return "F";
        }
    }
}
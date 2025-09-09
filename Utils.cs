namespace FirstProject;

public abstract class Utils {
    
    public static void Swap<T>(ref T a, ref T b) where T : notnull {
        (a, b) = (b, a);
    }
}
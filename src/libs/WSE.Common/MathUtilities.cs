namespace WSE.Common;

public static class MathUtilities
{
    // A placeholder for future math logic
    public static double SolveLinear(double a, double b)
    {
        // Solves ax + b = 0 -> x = -b/a
        if (a == 0) throw new ArgumentException(" 'a' cannot be zero.");
        return -b / a;
    }
}

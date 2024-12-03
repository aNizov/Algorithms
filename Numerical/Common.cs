namespace Numerical;

public class Common
{
    /// <summary>
    /// Greatest common divider
    /// </summary>
    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            var remainder = a % b;

            a = b;

            b = remainder;
        }
        return a;
    }
}

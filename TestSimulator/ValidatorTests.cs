using Simulator;
using Xunit;

public static class Validator
{
    public static int Limiter(int value, int min, int max)
    {
        return Math.Clamp(value, min, max);
    }

    public static string Shortener(string value, int min, int max, char placeholder)
    {
        value = value.Trim(); // Usu? nadmiarowe spacje
        if (value.Length < min)
        {
            value = value.PadRight(min, placeholder); // Uzupe?nij brakuj?ce znaki
        }
        else if (value.Length > max)
        {
            value = value.Substring(0, max - 1); // Skr�? do maksymalnej d?ugo?ci
        }
        return value;
    }
}
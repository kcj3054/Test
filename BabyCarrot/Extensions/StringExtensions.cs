namespace BabyCarrot.Extensions;

public static class StringExtensions
{
    public static bool IsNumeric(this string s)
    {
        return long.TryParse(s, out var result);
    }

    public static bool IsDateTime(this string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return false;
        }
        else
        {
            return DateTime.TryParse(s, out var result);
        }
    }
}
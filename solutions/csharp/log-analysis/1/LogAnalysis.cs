public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string stringDelimiter)
    {
        return str.Substring(str.IndexOf(stringDelimiter) + stringDelimiter.Length);
    }

    public static string SubstringBetween(this string str, string firstDelimiter, string secondDelimiter)
    {
        string substring = str.SubstringAfter(firstDelimiter);
        substring = substring.Substring(0, substring.IndexOf(secondDelimiter));
        return substring;
    }
    
    public static string Message(this string str) => str.SubstringAfter(": ");

    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}
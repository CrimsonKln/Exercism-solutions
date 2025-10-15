static class LogLine
{
    public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(':') + 1).Trim();

    public static string LogLevel(string logLine) => logLine.Remove(logLine.IndexOf(':') - 1).Substring(1).ToLower();

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}

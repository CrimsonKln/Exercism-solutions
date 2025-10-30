public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim(); 
        if (statement.EndsWith('?') && IsAllUpper(statement))
        {
            return "Calm down, I know what I'm doing!";
        }
        if (statement.EndsWith('?'))
        {
            return "Sure.";
        }
        if (IsAllUpper(statement))
        {
            return "Whoa, chill out!";
        }
        if (String.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }
            return "Whatever.";
    }

    public static bool IsAllUpper(this string statement)
    {
        return statement.ToUpperInvariant() == statement && statement.Any(char.IsLetter);
    }
}
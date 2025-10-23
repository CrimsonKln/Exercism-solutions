public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim(); 
        if (statement.EndsWith('?') && IsAllUpper(statement))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (statement.EndsWith('?'))
        {
            return "Sure.";
        }
        else if (IsAllUpper(statement))
        {
            return "Whoa, chill out!";
        }
        else if (String.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }
        else
        {
            return "Whatever.";
        }
    }

    public static bool IsAllUpper(this string statement)
    {
        bool result = true;
        bool atLeastOneLetter = false;
        foreach (char c in statement)
        {
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    result = false;
                }
                atLeastOneLetter = true;
            }
        }
        return result && atLeastOneLetter;
    }
}
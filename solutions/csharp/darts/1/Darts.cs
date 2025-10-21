public static class Darts
{
    public static int Score(double x, double y)
    {
        double dartRadius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        int score = 0;
        if (dartRadius <= 1.0)
        {
            score = 10;
        }
        else if (dartRadius <= 5.0)
        {
            score = 5;
        }
        else if (dartRadius <= 10.0)
        {
            score = 1;
        }
        return score;
    }
}

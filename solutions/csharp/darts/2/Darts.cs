public static class Darts
{
    public static int Score(double x, double y)
    {
        double dartRadius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        if (dartRadius <= 1.0)
            return 10;
        else if (dartRadius <= 5.0)
            return 5;
        else if (dartRadius <= 10.0)
            return 1;
        return 0;
    }
}

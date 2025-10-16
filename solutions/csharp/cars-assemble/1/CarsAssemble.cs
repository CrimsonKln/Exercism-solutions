static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double successRate = 0.0;
        if (0 < speed && speed < 5)
        {
            successRate = 1.0;
        }
        else if (4 < speed && speed < 9)
        {
            successRate = 0.9;
        }
        else if (speed == 9)
        {
            successRate = 0.8;
        }
        else if (speed == 10)
        {
            successRate = 0.77;
        }
        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double production = speed * 221;
        return production * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int productionPerMinutes = (int)ProductionRatePerHour(speed);
        return productionPerMinutes / 60;
    }
}

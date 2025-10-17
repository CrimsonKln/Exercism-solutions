static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float rate = 2.475f;
        switch (balance)
        {
            case < 0.0m:
                rate = 3.213f;
                break;
            case < 1000.0m:
                rate = 0.5f;
                break;
            case < 5000.0m:
                rate = 1.621f;
                break;
            default:
                break;
        }
        return rate;
    }

    public static decimal Interest(decimal balance) => (decimal)InterestRate(balance) * 0.01m * balance;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
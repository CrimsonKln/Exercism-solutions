class WeighingMachine
{
    public int Precision { get; }

    private double _weight;
    public double Weight
    {
        get { return _weight; }
        set
        {
            if (value < 0.0)
                throw new ArgumentOutOfRangeException("A weight cannot be negative.");
            _weight = value;
        }
    }

    public string DisplayWeight
    {
        get { return (Weight - TareAdjustment).ToString("F" + Precision) + " kg"; }
    }

    public double TareAdjustment { private get; set; } = 5.0;

    public WeighingMachine(int precision)
    {
        this.Precision = precision;
    }
}

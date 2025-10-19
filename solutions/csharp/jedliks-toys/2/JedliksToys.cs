class RemoteControlCar
{

    private int _meters = 0;
    private int _percentage = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_meters} meters";

    public string BatteryDisplay() => _percentage != 0 ? $"Battery at {_percentage}%" : "Battery empty";

    public void Drive()
    {
        if (_percentage != 0)
        {
            _meters += 20;
            _percentage -= 1; 
        }
    }
}
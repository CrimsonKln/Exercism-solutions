class RemoteControlCar
{
    private int speed;
    private int battery;
    private int batteryDrain;
    private int distanceDriven;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
    }

    public bool BatteryDrained() => this.battery < this.batteryDrain;

    public int DistanceDriven() => this.distanceDriven;

    public void Drive()
    {
        if (!this.BatteryDrained())
        {
            this.distanceDriven += this.speed;
            this.battery -= this.batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;
    
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        return car.DistanceDriven() >= this.distance;
    }
}

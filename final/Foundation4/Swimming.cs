public class Swimming : Activity
{
    private double _laps;


    public Swimming(string date, double laps, double minutes) : base(date, minutes)
    {
        _laps = laps;
    }
    public double GetLaps()
    {
        return _laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
     public override string GetActivityType()
    {
        return "Swimming";
    }
}
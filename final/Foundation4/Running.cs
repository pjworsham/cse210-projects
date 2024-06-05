public class Running : Activity
{
    private double _distance;

    public Running(string date, double distance, double minutes) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / GetMinutes() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetActivityType()
    {
        return "Running";
    }
}
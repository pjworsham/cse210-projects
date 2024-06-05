public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double speed, double minutes) : base(date, minutes)
    {
        _speed = speed;
       
    }
     public override double GetDistance()
    {
        return GetMinutes() / GetPace();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
     public override string GetActivityType()
    {
        return "Cycling";
    }
}
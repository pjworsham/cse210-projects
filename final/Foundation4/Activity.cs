public class Activity
{
    private string _date;
    private double _minutes;
    

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0; 
    }
    public virtual string GetActivityType()
    {
        return "";
    }
   public string GetSummary()
   {
        return $"{_date} {GetActivityType()} ({GetMinutes()} min)- Distance {GetDistance():f2} miles, Speed {GetSpeed():f2} mph, Pace: {GetPace():f2} min per mile";
   }
}
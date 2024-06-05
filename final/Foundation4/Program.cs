using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("04 June 2024", 3.0, 30);
        Cycling cycling = new Cycling("09 June 2024", 6.0, 25);
        Swimming swimming = new Swimming("11 June 2024", 10, 60);

        List<Activity> _activities = new List<Activity>();

        _activities.Add(running);
        _activities.Add(cycling);
        _activities.Add(swimming);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
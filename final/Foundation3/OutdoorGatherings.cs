public class OutdoorGatherings : Event
{
    private string _weatherForcast;

    public OutdoorGatherings(string title, string description, string eventDate, string eventTime, Address eventAddress, string weatherForcast) : base(title, description, eventDate, eventTime, eventAddress)
    {
        _weatherForcast = weatherForcast;
    }
    public string GetFullDetails()
    {
        return $"Standard Detail: \n{GetStandardDetails()}\n\nFull Details: \n{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forcast: {_weatherForcast}";
    }
    public string GetShortDescription()
    {
        return $"Short Description: \nEvent: Lecture\nTitle: {GetTitle()}\n Date: {GetEventDate()}";
    }

}
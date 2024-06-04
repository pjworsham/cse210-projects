public class Event
{
    private string _title;
    private string _description;
    private string _eventDate;
    private string _eventTime;
    private Address _eventAddress;

    public Event(string title, string description, string eventDate, string eventTime, Address eventAddress)
    {
        _title = title;
        _description = description;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetEventDate()
    {
        return _eventDate;
    }
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_eventDate}\nTime: {_eventTime}\nAddress: {_eventAddress.Display()}";
    }
}
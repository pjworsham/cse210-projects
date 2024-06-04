public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string eventDate, string eventTime, Address eventAddress, string speaker, int capacity) : base(title, description, eventDate, eventTime, eventAddress)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
   
    public string GetFullDetails()
    {
        return $"Standard Detail: \n{GetStandardDetails()}\n\nFull Details: \n{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public string GetShortDescription()
    {
        return $"Short Description: \nEvent: Lecture\nTitle: {GetTitle()}\nDate: {GetEventDate()}";
    }

}
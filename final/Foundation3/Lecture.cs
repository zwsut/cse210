public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        string title = GetTitle();
        string description = GetDescription();
        string date = GetDate();
        string time = GetTime();
        Address address = GetAddress();
        string eventAddress = address.GetFormattedAddress();
        return $"            Event type - Lecture\n            {title}\n            Speaker: {_speaker}\n            Maximum capacity: {_capacity}\n\n{description}\n\n{date}\n{time}\n\n{eventAddress}\n\n";
    }

    public override string ShowShortDescription()
    {
        string title = GetTitle();    
        string date = GetDate();  
        return $"Event Type - Lecture\n{title}\n{date}\n\n";
    }
}
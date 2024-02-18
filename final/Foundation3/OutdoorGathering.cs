public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        string title = GetTitle();
        string description = GetDescription();
        string date = GetDate();
        string time = GetTime();
        Address address = GetAddress();
        string eventAddress = address.GetFormattedAddress();
        return $"            Event type - Outdoor Gathering\n            {title}\n\n{description}\n\n{date}\n{time}\n\n{eventAddress}\n\nWeather outlook: {_weather}\n\n";
    }

    public override string ShowShortDescription()
    {
        string title = GetTitle();    
        string date = GetDate();  
        return $"Event Type - Outdoor Gathering\n{title}\n{date}\n\n";
    }
}

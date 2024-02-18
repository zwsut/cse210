public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        string title = GetTitle();
        string description = GetDescription();
        string date = GetDate();
        string time = GetTime();
        Address address = GetAddress();
        string eventAddress = address.GetFormattedAddress();
        return $"            Event type - Reception\n            {title}\n\n{description}\n\n{date}\n{time}\n\n{eventAddress}\n\nRSVP E-Mail: {_email}\n\n";
    }

    public override string ShowShortDescription()
    {
        string title = GetTitle();    
        string date = GetDate();  
        return $"Event Type - Reception\n{title}\n{date}\n\n";
    }
}
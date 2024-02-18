public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string ShowStandardDetails()
    {
        string eventAddress = _address.GetFormattedAddress();
        return $"            {_title}\n\n{_description}\n\n{_date}\n{_time}\n\n{eventAddress}\n\n";
    }

    public abstract string GetFullDetails();

    public abstract string ShowShortDescription();

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }    

    public string GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }
}
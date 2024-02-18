public abstract class Activity
{
    private string _date;
    private int _length;
    private string _type;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();
        return $"{_date} {_type} ({_length} min): Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }

    // Abstract methods are implicitly virtual methods, I did not see a need here for a body
    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public int GetLength()
    {
        return _length;
    }

    public void SetType(string type)
    {
        _type = type;
    }
}
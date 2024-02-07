public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string shortName, string description, int points, bool isComplete)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }



    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}
public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {}

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!");
        _isComplete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string type = "simple";
        string name = GetName();
        string description = GetDescription();
        string points = GetPoints().ToString();
        string comp = "false";
        if (IsComplete())
        {
            comp = "true";
        }
        return $"{type}||{name}||{description}||{points}||{comp}";
    }

    public override string GetDetailsString()
    {
        string name = GetName();
        string desc = GetDescription();
        return $"{name} ({desc})";
    }
}
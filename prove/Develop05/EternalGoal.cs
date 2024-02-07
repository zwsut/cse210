public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {}

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!");
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string type = "eternal";
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
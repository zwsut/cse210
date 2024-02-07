public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private bool _isComplete = false;

    public ChecklistGoal(string name, string description, int points, bool isComplete, int target, int bonus) : base(name, description, points, isComplete)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, bool isComplete, int amountCompleted, int target, int bonus) : base(name, description, points, isComplete)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!");
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"You've also earned {_bonus} bonus points for completing the goal!");
            _isComplete = true;
            return _bonus + GetPoints();
        }
        return GetPoints();
    }

    public override bool IsComplete()
    {
            return _isComplete;
    }

    public override string GetDetailsString()
    {
        string name = GetName();
        string desc = GetDescription();
        return $"{name} ({desc}) --Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        string type = "checklist";
        string name = GetName();
        string description = GetDescription();
        string points = GetPoints().ToString();
        string comp = "false";
        if (IsComplete())
        {
            comp = "true";
        }
        string amountdone = _amountCompleted.ToString();
        string bonuspoints = _bonus.ToString();
        string amounttarget = _target.ToString();
        return $"{type}||{name}||{description}||{points}||{comp}||{amountdone}||{bonuspoints}||{amounttarget}";
    }
}
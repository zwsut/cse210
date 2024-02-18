public class Running : Activity
{
    private float _distance;

    public Running(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
        SetType("Running");
    }

    public override float GetDistance()
    {
        return (float)Math.Round(_distance, 2);
    }

    public override float GetSpeed()
    {
        int time = GetLength();
        float speed = _distance / time * 60;
        return (float)Math.Round(speed, 2);
    }

    public override float GetPace()
    {
        float speed = GetSpeed();
        float pace = 60 / speed;
        return (float)Math.Round(pace , 2);
    }
}
public class StationaryBicycle : Activity
{
    private float _speed;

    public StationaryBicycle(string date, int length, float speed) : base(date, length)
    {
        _speed = speed;
        SetType("Stationary Bicycle");
    }

    public override float GetDistance()
    {
        int time = GetLength();
        return (float)(_speed * time / 60);
    }

    public override float GetSpeed()
    {
        return (float)Math.Round(_speed, 2);
    }

    public override float GetPace()
    {
        float speed = GetSpeed();
        float pace = 60 / speed;
        return (float)Math.Round(pace, 2);
    }
}
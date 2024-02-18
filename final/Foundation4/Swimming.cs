using System.Runtime.CompilerServices;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
        SetType("Swimming");
    }

    public override float GetDistance()
    {
        float distance = (float)(_laps * 50 / 1000 * 0.62);
        return (float)Math.Round(distance, 2);
    }

    public override float GetSpeed()
    {
        int time = GetLength();
        float distance = GetDistance();
        float speed = distance / time * 60;
        return (float)Math.Round(speed, 2);
    }

    public override float GetPace()
    {
        float speed = GetSpeed();
        float pace = 60 / speed;
        return (float)Math.Round(pace, 2);     
    }
}
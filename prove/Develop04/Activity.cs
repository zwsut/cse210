// ZachSutherland CSE210 2-1-24
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n{_description}\n");
    }

    public void SetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for your activity?");
        Console.Write(">");
        string num = Console.ReadLine();
        _duration = Convert.ToInt32(num);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {this.GetDuration()} seconds of the {_name}!");
    }

    public void ShowSpinner(int seconds)
    {
        int x = 0;
        while (x < seconds)
        {
            Console.Write("\r{0}       ", "|o     |");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "| o    |");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "|  o   |");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "|   o  |");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "|    o |");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "|     o|");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "|    o |");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "|   o  |");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "|  o   |");
            Thread.Sleep(500);
            Console.Write("\r{0}       ", "| o    |");
            Thread.Sleep(500);
            
            x += 1;
        }
        Console.Write("\r        \n");
    }

    public void ShowCountdown(int seconds)
    {

    }

    public int GetDuration()
    {
        return _duration; 
    }
}
public class BreathingActivity : Activity
{
    // Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {}

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this.GetDuration());
        DateTime currentTime = DateTime.Now;   

        while (currentTime < futureTime)
        {
            Console.Write("            Breathe in... ");
            Console.Write("3");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1500);
            Console.Write("\b \b");

            Console.WriteLine("\n");

            Console.Write("    Breathe out... ");
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.WriteLine("\n");

            currentTime = DateTime.Now;   
        }
        Console.WriteLine("Good job!");
    }
}
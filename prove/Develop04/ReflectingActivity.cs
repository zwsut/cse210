public class ReflectingActivity : Activity
{
    // Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this.GetDuration());
        DateTime currentTime = DateTime.Now;   

        while (currentTime < futureTime)
        {
            Console.WriteLine("\nConsider the following prompt:");
            DisplayPrompt();
            Console.WriteLine("When you have something in mind, press enter to continue.\n");
            Console.ReadLine();
            Console.WriteLine("Now ponder each of the following questions in regard to this experience.\n");

            Console.Write("You may begin in: ");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Clear();
            while (currentTime < futureTime)
            {
                Console.WriteLine("");
                DisplayQuestion();
                currentTime = DateTime.Now;
            } 
            Console.WriteLine("\nWell done!");
        }
    }

    public string GetRandomPrompt()
    {
        int length = _prompts.Count;
        Random rnd = new Random();
        int num = rnd.Next(0, length);
        return _prompts[num];
    }

    public string GetRandomQuestion()
    {
        int length = _questions.Count;
        Random rnd = new Random();
        int num = rnd.Next(0, length);
        return _questions[num];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"\n --- {this.GetRandomPrompt()} --- \n");
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {this.GetRandomQuestion()}   \n");
        this.ShowSpinner(2);
        Console.Write("\n");
    }
}
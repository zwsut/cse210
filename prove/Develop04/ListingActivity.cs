// ZachSutherland CSE210 2-1-24
public class ListingActivity : Activity
{
    // Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.

    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this.GetDuration());
        DateTime currentTime = DateTime.Now;   

        while (currentTime < futureTime)
        {
            Console.WriteLine("List as many responses as you can to the following prompt:\n");
            GetRandomPrompt();
            Console.Write("You may begin in... ");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("");
            while (currentTime < futureTime)
            {    
                Console.Write(">");
                Console.ReadLine();
                _count += 1;
                currentTime = DateTime.Now;
            }
            Console.WriteLine($"\nWell done!\nYou listed {_count} items!");
        }
    }

    public void GetRandomPrompt()
    {
        int length = _prompts.Count;
        Random rnd = new Random();
        int num = rnd.Next(0, length);
        Console.WriteLine($" --- {_prompts[num]} --- \n");

    }

    public List<string> GetListFromUser()
    {
        return null;
    } 
}
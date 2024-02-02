// ZachSutherland CSE210 2-1-24
public class GratitudeActivity : Activity
{
    private List<string> _answers = new List<string>();
    public GratitudeActivity(string name, string description, int duration) : base(name, description, duration)
    {}

        public void Run()
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(this.GetDuration());
            DateTime currentTime = DateTime.Now;   

            while (currentTime < futureTime)
            {
                Console.WriteLine("Take a few seconds to think back on your day and enter as many things you are grateful for in this moment.");
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
                Console.WriteLine("");
                while (currentTime < futureTime)
                {
                    Console.Write("> ");
                    string newAnswer = Console.ReadLine();
                    AddAnswer(newAnswer);
                    currentTime = DateTime.Now;
                }
                string formattedAnswers = "";
                bool isFirst = true;
                foreach (string x in _answers)
                {
                    if (isFirst)
                    {
                        formattedAnswers += x;
                        isFirst = false;
                    }
                    else
                    {
                        formattedAnswers += ", " + x;
                    }    
                }

                Console.WriteLine($"\nWell done! \nKeep in mind these positive things in your life: {formattedAnswers}.\n");
            } 
        }

        public void AddAnswer(string response)
        {
            _answers.Add(response);
        }

        public List<string> GetAnswers()
        {
            return _answers;
        }
}
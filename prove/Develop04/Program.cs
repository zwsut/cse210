using System;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Begin breathing activity");
            Console.WriteLine("    3. Begin reflection activity");
            Console.WriteLine("    3. Begin listing activity");
            Console.WriteLine("    4. Begin gratitude activity");
            Console.WriteLine("    5. Quit");
            Console.Write("    >");
            int userChoice = int.Parse(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 60);
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.SetDuration();
                    Console.WriteLine("Get ready...");
                    breathingActivity.ShowSpinner(2);
                    breathingActivity.Run();
                    breathingActivity.ShowSpinner(2);
                    Console.WriteLine("");
                    breathingActivity.DisplayEndingMessage();
                    breathingActivity.ShowSpinner(2);
                    break;

                case 2:
                    List<string> promptList = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
                    List<string> questionList = new List<string>(){"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?"," What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
                    ReflectingActivity reflectionActivity = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60, promptList, questionList);
                    reflectionActivity.DisplayStartingMessage();
                    reflectionActivity.SetDuration();
                    Console.WriteLine("Get ready...");
                    reflectionActivity.ShowSpinner(2);
                    reflectionActivity.Run();
                    reflectionActivity.ShowSpinner(2);
                    Console.WriteLine("");
                    reflectionActivity.DisplayEndingMessage();
                    reflectionActivity.ShowSpinner(2);
                    break;

                case 3:
                    List<string> listPromptList = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60, 0, listPromptList);
                    listingActivity.DisplayStartingMessage();
                    listingActivity.SetDuration();
                    Console.WriteLine("Get ready...");
                    listingActivity.ShowSpinner(2);
                    listingActivity.Run();
                    listingActivity.ShowSpinner(2);
                    Console.WriteLine("");
                    listingActivity.DisplayEndingMessage();
                    listingActivity.ShowSpinner(2);
                    break;

                case 4:
                    GratitudeActivity gratitudeActivity = new GratitudeActivity("Gratitude Activity", "This activity will bring your attention to what you are grateful for today, reminding you of the blessings in your life.", 0);
                    gratitudeActivity.DisplayStartingMessage();
                    gratitudeActivity.SetDuration();
                    Console.WriteLine("Get ready...");
                    gratitudeActivity.ShowSpinner(2);
                    gratitudeActivity.Run();
                    gratitudeActivity.ShowSpinner(2);
                    Console.WriteLine("");
                    gratitudeActivity.DisplayEndingMessage();
                    gratitudeActivity.ShowSpinner(2);
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> emptyList = new List<Goal>();
        Console.WriteLine("     Welcome to Eternal Quest!");
        Console.WriteLine("     If you will be loading a saved file please hit enter.");
        Console.WriteLine("     If you are starting a new game, choose your class.");
        Console.WriteLine("     ---Ascii art from www.asciiart.eu and www.ascii.co.uk---");
        Console.WriteLine("1. Wizard\n2. Knight\n3. King\n4. Alchemist");
        Console.Write("> ");
        string userClass = Console.ReadLine();
        string job = "";
        if (userClass == "1")
        {
            job = "wizard";
        }
        if (userClass == "2")
        {
            job = "knight";
        }
        if (userClass == "3")
        {
            job = "king";
        }
        if (userClass == "4")
        {
            job = "alchemist";
        }
        GoalManager currentManager = new GoalManager(emptyList, 0, job);

        while (true)
        {
            currentManager.DisplayPlayerInfo();
            int menuChoice = int.Parse(currentManager.Start());

            switch(menuChoice)
            {
                case 1:
                    currentManager.CreateGoal();
                    break;
                case 2:
                    currentManager.ListGoalDetails();
                    break;
                case 3:
                    currentManager.SaveGoals();
                    break;
                case 4:
                    currentManager = currentManager.LoadGoals();
                    break;
                case 5:
                    currentManager.RecordEvent();
                    break;
                case 6:
                    System.Environment.Exit(0);
                    break;
            }
        }

    }
}
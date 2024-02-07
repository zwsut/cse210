using System.IO.Enumeration;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Tracing;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    private string _class;

    public GoalManager(List<Goal> goals, int score, string userClass)
    {
        _goals = goals;
        _score = score;
        _class = userClass;
    }

    public void SetClass(string userClass)
    {
        _class = userClass;
    }

    public string Start()
    {
       Console.WriteLine($"\nMenu options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit"); 
       Console.Write("Select a choice from the menu: ");
       return Console.ReadLine();
    }

    public void DisplayPlayerInfo()
    {
        double level = _score / 1000;
        int userLevel = (int)level;
        Console.WriteLine($"\nYou have {_score} points and are a level {userLevel} {_class}.");
        if (_class == "wizard")
        {
            Console.WriteLine("                  .");
            Console.WriteLine("");
            Console.WriteLine("                   .");
            Console.WriteLine("         /^\\     .");
            Console.WriteLine("    /\\   \"V\"");
            Console.WriteLine("   /__\\   I      O  o");
            Console.WriteLine("  //..\\\\  I     .");
            Console.WriteLine("  \\].`[/  I");
            Console.WriteLine("  /l\\/j\\  (]    .  O");
            Console.WriteLine(" /. ~~ ,\\/I          .");
            Console.WriteLine(" \\\\L__j^\\/I       o");
            Console.WriteLine("  \\/--v}  I     o   .");
            Console.WriteLine("  |    |  I   _________");
            Console.WriteLine("  |    |  I c(`       ')o");
            Console.WriteLine("  |    l  I   \\.     ,/");
            Console.WriteLine("_/j  L l\\_!  _//^---^\\\\_    -Row");
            Console.WriteLine("");
        }
        if (_class == "knight")
        {
            Console.WriteLine("  ,^.");
            Console.WriteLine("  |||");
            Console.WriteLine("  |||       _T_");
            Console.WriteLine("  |||   .-.[:|:].-.");
            Console.WriteLine("  ===_ /\\|  \"'\"  |/");
            Console.WriteLine("   E]_|\\/ \\--|-|''''|");
            Console.WriteLine("   O  `'  '=[:]| A  |");
            Console.WriteLine("          /\"\"\"\"|  P |");
            Console.WriteLine("         /\"\"\"\"\"`.__.'");
            Console.WriteLine("        []\"/\"\"\"\\\"[]");
            Console.WriteLine("        | \\     / |");
            Console.WriteLine("        | |     | |");
            Console.WriteLine("      <\\\\\\)     (///>");
        }
        if (_class == "king")
        {
            Console.WriteLine("      _.+._");
            Console.WriteLine("    (^\\/^\\/^)");
            Console.WriteLine("     \\@*@*@/");
            Console.WriteLine("     {_____}");
            Console.WriteLine("    ///\"\"\"\\\\\\");
            Console.WriteLine("    (/6   6\\)");
            Console.WriteLine("     ||=^=||");
            Console.WriteLine("     \\\\\\\\///");
            Console.WriteLine("      \\\\///");
            Console.WriteLine("jgs    `)/");
        }
        if (_class == "alchemist")
        {
            Console.WriteLine("       -''--.");
            Console.WriteLine("       _`>   `\\.-'<");
            Console.WriteLine("    _.'     _     '._");
            Console.WriteLine("  .'   _.='   '=._   '.");
            Console.WriteLine("  >_   / /_\\ /_\\ \\   _<");
            Console.WriteLine("    / (  \\o/\\o/  ) \\");
            Console.WriteLine("    >._\\ .-,_)-. /_.<");
            Console.WriteLine("jgs     /__/ \\__\\ ");
            Console.WriteLine("          '---'");
        }
    }

    public void ListGoalNames()
    {
        int count = 1;
        foreach (Goal x in _goals)
        {
            Console.WriteLine($"{count}. {x.GetName()}");
            count +=1;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour goals are:");
        int count = 1;
        foreach (Goal x in _goals)
        {
            if (x.IsComplete())
            {
                string details = x.GetDetailsString();
                Console.WriteLine($"{count}. [X] {details}");
                count += 1;
            }
            else
            {
                string details = x.GetDetailsString();
                Console.WriteLine($"{count}. [ ] {details}");
                count += 1;
            }
        }
    }

    public void CreateGoal()
    {
        Console.Write("\nThe types of goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\n");
        Console.Write("\nWhich type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());
        switch(type)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("Enter a short description of the goal: ");
                string description = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points = int.Parse(Console.ReadLine());
                SimpleGoal newSimple = new SimpleGoal(name, description, points, false);
                _goals.Add(newSimple);
                Console.WriteLine($"\n{name} added to your goal list as a simple goal.");
                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                string name2 = Console.ReadLine();
                Console.Write("Enter a short description of the goal: ");
                string description2 = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points2 = int.Parse(Console.ReadLine());
                EternalGoal newEternal = new EternalGoal(name2, description2, points2, false);
                _goals.Add(newEternal);
                Console.WriteLine($"\n{name2} added to your goal list as an eternal goal.");
                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                string name3 = Console.ReadLine();
                Console.Write("Enter a short description of the goal: ");
                string description3 = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points3 = int.Parse(Console.ReadLine());
                Console.Write("How many times must this be completed to earn bonus points? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points will this earn? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal newChecklist = new ChecklistGoal(name3, description3, points3, false, target, bonus);
                _goals.Add(newChecklist);
                Console.WriteLine($"\n{name3} added to your goal list as an checklist goal.");
                break;
        } 
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:\n");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        _score += _goals[goalIndex].RecordEvent();
        Console.WriteLine($"You now have {_score} points!");
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for your file? (.txt will be added automatically) ");
        string fileName = $"{Console.ReadLine()}.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score.ToString()}||{_class}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public GoalManager LoadGoals()
    {
        List<Goal> emptyList = new List<Goal>();

        Console.Write("\nWhat is the name of the file you'd like to load? (.txt will be added automatically) ");
        string fileName = $"{Console.ReadLine()}.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);
    
        foreach (string line in lines)
        {
            string[] parts = line.Split("||");
            
            if (parts[0] == "simple")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completed = Convert.ToBoolean(parts[4]);
                SimpleGoal newSimple = new SimpleGoal(name, description, points, false);    
                emptyList.Add(newSimple);               
            }
            else if (parts[0] == "eternal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completed = Convert.ToBoolean(parts[4]);
                EternalGoal newEternal = new EternalGoal(name, description, points, false);    
                emptyList.Add(newEternal);     
            }
            else if (parts[0] == "checklist")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completed = Convert.ToBoolean(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                int target = int.Parse(parts[7]);
                ChecklistGoal newChecklist = new ChecklistGoal(name, description, points, completed, amountCompleted, target, bonus);
                emptyList.Add(newChecklist);     
            }

            else
            {
                int score = int.Parse(parts[0]);
                string userClass = parts[1];
                _score = score;
                _class = userClass;
            }
            
        }
        GoalManager currentManager = new GoalManager(emptyList, _score, _class);
        return currentManager;
    }   

    public void SetScore(int score)
    {
        _score = score;
    }
}
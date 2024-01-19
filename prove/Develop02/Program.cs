using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Program p = new Program();
        string userChoice = DisplayMenu();
        Journal journal = new Journal();
        p.ProcessInput(userChoice, journal);
    }

    static string DisplayMenu()
    {
        Console.WriteLine("\nHello Journal World!");
        Console.WriteLine("Please select from the options below:");
        Console.WriteLine("1. Write a new entry.");
        Console.WriteLine("2. Display journal entries.");
        Console.WriteLine("3. Save this journal entry to file.");
        Console.WriteLine("4. Load a journal from file.");
        Console.WriteLine("0. Exit the program.");    
        Console.Write("> ");   
        string userChoice = Console.ReadLine();
        return userChoice;
    }

    public void ProcessInput(string userChoice, Journal journal)
    {
        if (userChoice == "1")
        {
            PromptGenerator gen = new PromptGenerator();
            Entry entry = new Entry();

            Console.WriteLine("");
            Console.WriteLine("What is the date and time?");
            Console.Write(">");
            string responseDate = Console.ReadLine();
            
            entry._date = responseDate;
            entry._prompt = gen.GeneratePrompt();

            Console.WriteLine("");
            Console.WriteLine(entry._prompt);
            Console.Write(">");
            string response = Console.ReadLine();

            entry._response = response;
            
            journal.AddEntry(entry);
            RestartMenu(journal);
        }

        else if (userChoice == "2")
        {
            journal.DisplayAll();
            RestartMenu(journal);
        }

        else if (userChoice == "3")
        {
            Console.WriteLine("\nWhat yould you like to call your file? (.csv will be added automatically)");
            string name = Console.ReadLine();
            string fileName = $"{name}.txt";
            journal.SaveToFile(fileName, journal);
            Console.WriteLine($"\nJournal saved as {fileName}\n");
            RestartMenu(journal);

        }

        else if (userChoice == "4")
        {
            Console.WriteLine("\nWhat file would you like to load? (.csv will be added automatically)");  
            string name = Console.ReadLine();  
            string fileName = $"{name}.txt";
            journal = journal.LoadFromFile(fileName);     
            Console.WriteLine($"\nLoading journal {fileName}\n");  
            RestartMenu(journal);
        }

        else if (userChoice == "0")
        {
            System.Environment.Exit(0);
        }

        else
        {
            Console.WriteLine("\n\nPlease enter a valid choice.\n");
            RestartMenu(journal);
        }
    }

    public void RestartMenu(Journal journal)
    {
        string choice = DisplayMenu();
        ProcessInput(choice, journal);       
    }
}


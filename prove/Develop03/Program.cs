using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Scripture Memorizer World!");
        Console.WriteLine("Enter 1 for default scripture or 2 to enter your own.");
        Console.Write(">");
        string choice = Console.ReadLine();

        Scripture scripture = new Scripture("John", 3, 16, 0, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        Scripture userScripture = new Scripture();
        var inputScripture = true;

        while (true)
        {
            Console.Clear();

            if (choice == "1")
            {               
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Type 'quit' to exit or press 'enter' to hide some words and continue.");
                Console.Write(">");
                string x = Console.ReadLine();
                if (x.ToLower() == "quit")
                {
                    System.Environment.Exit(0);
                }
                scripture.HideRandomWords();
                if (scripture.isCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations, you memorized the scripture!");
                    System.Environment.Exit(0);
                }
            }

            else if (choice == "2")
            {
                if (inputScripture == true)
                {
                    Console.WriteLine("Please enter the book.");
                    Console.Write(">");
                    string inputBook = Console.ReadLine();

                    Console.WriteLine("Please enter the chapter.");
                    Console.Write(">");
                    string inputChapter = Console.ReadLine();
                    int inputChapterInt = Int32.Parse(inputChapter);

                    Console.WriteLine("Please enter the starting verse.");
                    Console.Write(">");
                    string inputVerse = Console.ReadLine();
                    int inputVerseInt = Int32.Parse(inputVerse);

                    Console.WriteLine("Please enter the ending verse, enter '0' if only one verse.");
                    Console.Write(">");
                    string inputEndVerse = Console.ReadLine();
                    int inputEndVerseInt = Int32.Parse(inputEndVerse);

                    Console.WriteLine("Please paste the text in.");
                    Console.Write(">");
                    string inputText = Console.ReadLine();

                    userScripture.SetScripture(inputBook, inputChapterInt, inputVerseInt, inputEndVerseInt, inputText);
                    inputScripture = false;
                    
                }
                else
                {
                    Console.WriteLine(userScripture.GetDisplayText());
                    Console.WriteLine("Type 'quit' to exit or press 'enter' to hide some words and continue.");
                    Console.Write(">");
                    string x = Console.ReadLine();
                    if (x.ToLower() == "quit")
                    {
                        System.Environment.Exit(0);
                    }
                    userScripture.HideRandomWords();
                    if (userScripture.isCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine("Congratulations, you memorized the scripture!");
                        System.Environment.Exit(0);
                    }         
                }
            }
        }
    }
}

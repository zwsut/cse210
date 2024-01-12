using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage as a whole number: ");
        string gpa = Console.ReadLine();
        int gpaInt = int.Parse(gpa);
        string letter;

        if (gpaInt >= 90)
        {
            letter = "A";
        }
        else if (gpaInt >= 80)
        {
            letter = "B";
        }
        else if (gpaInt >= 70)
        {
            letter = "C";
        }
        else if (gpaInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You have received a grade of {letter}.");
        
        if (gpaInt >= 70)
        {
            Console.WriteLine("Congratulations on passing the course!");
        }
        else
        {
            Console.WriteLine("You have failed the course.");
        }
    }
}
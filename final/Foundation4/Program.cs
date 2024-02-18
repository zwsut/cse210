using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating objects
        Running running = new Running("03 Nov 2022", 27, 3);
        StationaryBicycle biking = new StationaryBicycle("28 Feb 2023", 90, 12);
        Swimming swimming = new Swimming("01 Jan 2024", 45, 55);

        // Creating a list of the three activities
        List<Activity> list = new List<Activity>(){running, biking, swimming};

        // Iterating through the list to print summaries
        Console.WriteLine("");
        foreach (Activity x in list)
        {
            Console.WriteLine(x.GetSummary());
        }
        Console.WriteLine("");
    }
}
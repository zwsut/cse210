using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int i = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (i != 0)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            if (num != "0")
            {
                numbers.Add(int.Parse(num));
            }
            i = int.Parse(num);
        }
        
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}\nThe average is: {average}\nThe largest number is: {max}");
    }
}
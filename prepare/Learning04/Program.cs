using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Inheritance World!");

        Console.WriteLine("");

        Assignment ass1 = new Assignment("Zach Beans", "Math");
        Console.WriteLine(ass1.GetSummary());

        Console.WriteLine("");

        MathAssignment ass2 = new MathAssignment("Zech", "moth", "chapter 11", "all problems");
        Console.WriteLine(ass2.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment ass3 = new WritingAssignment("Zichbob", "Ingles", "History of Cheerios, 1832-1880");
        Console.WriteLine(ass3.GetWritingInformation());
    }
}
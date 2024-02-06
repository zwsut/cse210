using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();
        Square sq = new Square("orange", 4);
        Rectangle re = new Rectangle("green", 3, 5);
        Circle ci = new Circle("Yellow", 6);
        list.Add(sq);
        list.Add(re);
        list.Add(ci);
    
    foreach (Shape shape in list)
    {
        Console.WriteLine(shape.GetColor());
        Console.WriteLine(shape.GetArea());
    }
    }
}
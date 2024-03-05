using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("Blue", 5);

        Console.WriteLine(mySquare.Color);
        Console.WriteLine(mySquare.GetArea());
    }
}
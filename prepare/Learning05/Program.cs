using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("Blue", 5);

        Console.WriteLine(mySquare.Color);
        Console.WriteLine(mySquare.GetArea());

        Triangle myTri = new Triangle("Red", 5, 6);

        Console.WriteLine(myTri.Color);
        Console.WriteLine(myTri.GetArea());

        Rectangle myRec = new Rectangle("Green", 7, 6);

        Console.WriteLine(myRec.Color);
        Console.WriteLine(myRec.GetArea());
    }
}
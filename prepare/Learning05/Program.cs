using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square mySquare = new Square("Blue", 5);
        shapes.Add(mySquare);


        // Console.WriteLine(mySquare.Color);
        // Console.WriteLine(mySquare.GetArea());

        Triangle myTri = new Triangle("Red", 5, 6);
        shapes.Add(myTri);

        // Console.WriteLine(myTri.Color);
        // Console.WriteLine(myTri.GetArea());

        Rectangle myRec = new Rectangle("Green", 7, 6);
        shapes.Add(myRec);

        // Console.WriteLine(myRec.Color);
        // Console.WriteLine(myRec.GetArea());

        Circle myCir = new Circle("Purple", 5);
        shapes.Add(myCir);

        // Console.WriteLine(myCir.Color);
        // Console.WriteLine(myCir.GetArea());

        foreach (Shape s in shapes)
        {
            string color = s.Color;

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");

        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment samBen = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(samBen.GetSummary());

        MathAssignment robRod = new MathAssignment("Robert Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(robRod.GetSummary());
        Console.WriteLine(robRod.GetHomeworkList());

        WritingAssignment marWat = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(marWat.GetSummary());
        Console.WriteLine(marWat.GetWritingInformation());

    }
}
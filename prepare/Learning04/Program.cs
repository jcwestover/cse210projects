using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Johnny", "Math");
    
        Console.WriteLine(test.GetSummary());
    }
}
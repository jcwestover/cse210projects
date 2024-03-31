using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user input
        // TODO: create activity level legend
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Weight: ");
        float weight = float.Parse(Console.ReadLine());

        Console.Write("Height (inches): ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("ActivityLevel: ");
        int ActivityLevel = int.Parse(Console.ReadLine());
    }
}
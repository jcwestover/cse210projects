using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int newNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        // Finding sum
        int sum = 0;
        foreach (int value in numbers)
        {
            sum += value;
        }

        // Finding Average
        float average = ((float)sum) / numbers.Count;

        // Finding max
        int largestNum = 0;
        foreach (int value in numbers)
        {
            if (value > largestNum)
            {
                largestNum = value;
            }
        }

        // Displaying the stats
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}
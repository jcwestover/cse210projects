using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int magicNumber = rand.Next(0, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the number!");
            }
        }
    }
}
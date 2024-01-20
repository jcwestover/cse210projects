using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling the functions
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numSqr = SquareNumber(number);
        DisplayResult(name, numSqr);

        // Declaring the functions
        static void DisplayWelcome()
        {
            // Displays a generic welcome message
            // Parameters: None
            // Returns: None

            Console.WriteLine("Welcome to the program!");
        }


        static string PromptUserName()
        {
            // Returns user input for name variable
            // Parameters: None
            // Returns: name

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }


        static int PromptUserNumber()
        {
            // Returns user input for number variable
            // Parameters: None
            // Returns: number
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }


        static int SquareNumber(int number)
        {
            // Returns the square root of the number passed in the parameter
            // Parameters
            // Number: a number you would like to square
            // Returns
            // numSqr: the value of the number squared
            int numSqr = number * number;

            return numSqr;
        }


        static void DisplayResult(string name, int numSqr)
        {
            // Displays the user's name and the squared number
            // Parameters
            // name: the user's name
            // numSqr: the user's favorite number squared
            // Returns
            // None
            Console.WriteLine($"{name}, the square of your number is {numSqr}");
        }


    }
}
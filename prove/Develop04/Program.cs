using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "0";

        while (userChoice != "4")
        {
            Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        // breathing exercise

                        break;
                    case "2":
                        // reflection activity
                        Console.Write("How long, in seconds, would you like for your session?");
                        int length = Convert.ToInt32(Console.ReadLine());
                        
                        ReflectionActivity reflectionActivity = new ReflectionActivity(length, "Reflection Activity");

                        reflectionActivity.BeginningMessage();
                        reflectionActivity.PromptGenerator();
                        reflectionActivity.Spinner();
                        reflectionActivity.GetReady();
                        reflectionActivity.Spinner();
                        reflectionActivity.QuestionIterator();

                        break;
                    case "3":
                        // listing activity

                        break;
                    case "4":
                        // quit

                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
        }


    }
}
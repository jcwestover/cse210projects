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
                        int refLength = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        ReflectionActivity reflectionActivity = new ReflectionActivity(refLength, "Reflection Activity");

                        reflectionActivity.BeginningMessage();
                        reflectionActivity.DisplayDesc();
                        reflectionActivity.Spinner();
                        reflectionActivity.GetReady();
                        reflectionActivity.PromptGenerator();
                        
                        reflectionActivity.QuestionIterator();
                        reflectionActivity.EndingMessage();

                        break;
                    case "3":
                        // listing activity
                        Console.Write("How long, in seconds, would you like for your session?");
                        int listLength = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        ListingActivity listingActivity = new ListingActivity(listLength, "Listing Activity");

                        listingActivity.BeginningMessage();
                        listingActivity.DisplayDesc();
                        listingActivity.Spinner();
                        listingActivity.GetReady();
                        listingActivity.ListingPromptGenerator();
                        listingActivity.List();
                        listingActivity.EndingMessage();

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
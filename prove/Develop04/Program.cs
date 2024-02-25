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
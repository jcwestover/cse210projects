using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userChoice = "0";

        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the journal program");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "1":
                            PromptGenerator promptGenerator = new PromptGenerator();
                            string prompt = promptGenerator.GeneratePrompt();
                            Console.WriteLine(prompt);
                            string response = Console.ReadLine();

                            // Entry
                            Entry entry = new Entry();
                            entry._prompts = prompt;
                            entry._response = response;
                            entry._entryDate = DateTime.Now;
                            
                            // Journal
                            journal._entries.Add(entry);
                            
                            break;
                        case "2":
                            journal.Display();
                            break;
                        case "3":
                            journal.Load();
                            break;
                        case "4":
                            Console.WriteLine("Saving file...");
                            journal.Save();
                            break;
                        case "5":
                            Console.WriteLine("Quit");
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
        }
    }
}
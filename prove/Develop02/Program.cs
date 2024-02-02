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
                            foreach (Entry singleEntry in journal._entries)
                            {
                                Console.WriteLine(singleEntry._entryDate);
                                Console.WriteLine(singleEntry._prompts);
                                Console.WriteLine(singleEntry._response);
                            }
                            break;
                        case "3":
                            Console.WriteLine("Load");
                            break;
                        case "4":
                            Console.WriteLine("Save");
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
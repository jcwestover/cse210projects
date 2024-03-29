using System;
using System.Collections.Generic; 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter some information about the Scripture you would like to memorize.");
        Console.Write("Name of Book: ");
        string book = Console.ReadLine();
        Console.Write("Chapter number: ");
        string chapter = Console.ReadLine();
        Console.Write("Starting verse number: ");
        string startVerse = Console.ReadLine();
        Console.Write("Ending verse number (if only one verse enter 0): ");
        string endingVerse = Console.ReadLine();
        Console.Write("Text of the scripture: ");
        string scripture_text = Console.ReadLine();

        Scripture scripture = new Scripture(book, chapter, startVerse, endingVerse, scripture_text);
        
        Console.Clear();

        scripture.Display();

        Console.WriteLine("\nPress Enter to hide words.\nType 'quit' to exit the program.");

        while(true)
        {
            string userSelection = Console.ReadLine();

            if (userSelection == "quit")
            {
                break;
            }

            if (!scripture.HideWords())
            {
                Console.WriteLine("All words have been hidden.");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue hiding words.\nType 'quit' to exit the program.");
        }

        
    }
}
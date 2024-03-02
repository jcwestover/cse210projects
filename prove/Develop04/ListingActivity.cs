using System;
public class ListingActivity : Activity

{
    private string _listingDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private string[] _listPrompts = new string []
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected string[] _listList = new string []
    {

    };

    public ListingActivity(int length, string name) : base (length, name)
    {

    }

    public void DisplayDesc()
    {
        Console.WriteLine(_listingDesc + "\n");
    }


    public void ListingPromptGenerator()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Random random = new Random();
        int index = random.Next(_listPrompts.Length);
        Console.WriteLine("\n---" + _listPrompts[index] + "---\n");
        Console.Write($"You may begin in: ");

        for(int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    public void List()
    {   
        Console.WriteLine("Begin Listing as many items as you can: ");

        int i = 0;

        System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
        s.Start();

        for (; s.Elapsed < TimeSpan.FromSeconds(_length); i++)
        {
            Console.Write($"{i + 1}. ");
            Console.ReadLine();
        }

        Console.WriteLine($"\nYou Listed {i} items!\n");
    }
}
using System;
public class ReflectionActivity : Activity
{
    private string _refectionDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string[] _prompts = new string []
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _reflectQs = new string []
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int length, string name) : base(length, name)
    {

    }

    public void PromptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        Console.WriteLine(_prompts[index]);
    }

    public void QuestionIterator()
    {
        System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
        s.Start();

        for (int i = 0; i < _reflectQs.Length && s.Elapsed < TimeSpan.FromSeconds(_length); i++)
        {
            Console.WriteLine(_reflectQs[i]);
            Spinner();
        }
    }
    

}
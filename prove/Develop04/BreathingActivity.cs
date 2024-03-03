using System;
public class BreathingActivity : Activity
{
    private string _breathingDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(int length, string name) : base (length, name)
    {

    }

    public void DisplayDesc()
    {
        Console.WriteLine(_breathingDesc + "\n");
    }

    public void Pacer()
    {
        Console.Write("\nPress enter when ready to begin");
        Console.ReadLine();
        Console.Clear();

        System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
        s.Start();

        for (int i = 0; s.Elapsed < TimeSpan.FromSeconds(_length); i++)
        {
            Console.Write("Breathe in...");
            for(int j = 4; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }

            Console.Clear();
            
            Console.Write("Now breathe out...");
            for(int k = 6; k > 0; k--)
            {
                Console.Write(k);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }

            Console.Clear();
        }

    }

}
using System;
public class BreathingActivity : Activity
{
    private string _breathingDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(int length, string name) : base (length, name)
    {

    }

    public void Pacer()
    {
        System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
        s.Start();

        for (int i = 0; i < _reflectQs.Length && s.Elapsed < TimeSpan.FromSeconds(_length); i++)
        {
            Console.Write("Breathe in...");
            for(int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }

            Console.Write("Now breathe out...");
            for(int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
        }

    }

}
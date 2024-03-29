using System;
public class Activity
{
    protected int _length;
    private string _name;
    private string[] _spinnerList = new string []
    {
        "\\", "|", "/", "-"
    };

    public Activity(int length, string name)
    {
        _length = length;
        _name = name;
    }

    public int GetLength()
    {
        return _length;
    }

    public string GetName()
    {
        return _name;
    }

    public void BeginningMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
    }

    public void Spinner()
    {   
        int i = 0;

        System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
        s.Start();
        while (s.Elapsed < TimeSpan.FromSeconds(5)) 
        {            
            string line = _spinnerList[i];
            Console.Write(line);
            Thread.Sleep(375);
            Console.Write("\b \b");

            i++;

            if (i >= _spinnerList.Length)
            {
                i = 0;
            }

        }

        s.Stop();
    }

    public void GetReady()
    {
        Console.WriteLine("Get Ready...");
    }

    public void EndingMessage()
    {
       Console.WriteLine($"Well done!\n");
       Spinner();
       Console.WriteLine($"You have completed {_length} seconds of The {_name}");
       Spinner();
    }

    public static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.BufferWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }
    





}
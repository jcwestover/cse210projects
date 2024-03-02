public class Activity
{
    private int _length;
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

    public string BeginningMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
    }

    public string Spinner()
    {   
        int i = 0;

        System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
        s.Start();
        while (s.Elapsed < TimeSpan.FromSeconds(2)) 
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

    public string GetReady()
    {
        Console.WriteLine("Get Ready...")
    }

    public string EndingMessage()
    {
       Console.WriteLine($"Well done!");
       Spinner();
       Console.WriteLine($"You have completed {_length} of The {_name}");
    }






}
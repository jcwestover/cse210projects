using System;
System.Diagnostics.Stopwatch StopWatch = new System.Diagnostics.Stopwatch();

int _length = 10;
string[] _spinnerList = new string []
    {
        "\\", "|", "/","-"
    };

Console.WriteLine("Get ready...");
        
        int i = 0;


        System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
        s.Start();
        while (s.Elapsed < TimeSpan.FromSeconds(_length)) 
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
            
            // Console.Write("+");

            // Thread.Sleep(500);

            // Console.Write("\b \b"); // Erase the + character
            // Console.Write("-"); // Replace it with the - character
        }

        s.Stop();
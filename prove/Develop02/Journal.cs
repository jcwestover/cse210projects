using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Load()
    {
        Console.WriteLine("Enter filename you would like to load: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(" - ");
            Entry entry = new Entry();
            entry._entryDate = DateTime.Parse(parts[0]);
            entry._prompts = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);
        }
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._entryDate} - {entry._prompts} - {entry._response}\n");
        }
    }

    public void Save()
    {
        Console.WriteLine("Enter filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._entryDate} - {entry._prompts} - {entry._response}");
            }
        }
    }
}



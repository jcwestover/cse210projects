using System;
using System.Collections.Generic;
using System.IO;

public class DataStorage
{
    private const string FileName = "user_info.csv";
    private string _filePath;

    public DataStorage()
    {
        string currentDirectory = Environment.CurrentDirectory;
        _filePath = Path.Combine(currentDirectory, FileName);
    }

    public void Save(List<double> tdeeList, List<double> proteinList, List<double> fatList, List<double> carbsList, List<double> weightList)
    {
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            writer.WriteLine("TDEE,Protein,Fat,Carbs,Weight");
            for (int i = 0; i < tdeeList.Count; i++)
            {
                writer.WriteLine($"{tdeeList[i]},{proteinList[i]},{fatList[i]},{carbsList[i]},{weightList[i]}");
            }
        }
        Console.WriteLine("Data saved successfully.");
    }

    public void Load(out List<double> tdeeList, out List<double> proteinList, out List<double> fatList, out List<double> carbsList, out List<double> weightList)
    {
        tdeeList = new List<double>();
        proteinList = new List<double>();
        fatList = new List<double>();
        carbsList = new List<double>();
        weightList = new List<double>();

        using (StreamReader reader = new StreamReader(_filePath))
        {
            reader.ReadLine();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                tdeeList.Add(double.Parse(values[0]));
                proteinList.Add(double.Parse(values[1]));
                fatList.Add(double.Parse(values[2]));
                carbsList.Add(double.Parse(values[3]));
                weightList.Add(double.Parse(values[4]));
            }
        }
        Console.WriteLine("Data loaded successfully.");
    }
}
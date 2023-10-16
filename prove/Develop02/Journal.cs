using System;
using System.Collections.Generic;
using System.IO;
public class Journal{

public List<Entry> list_of_entries = new List<Entry>();

public void Save(string filePath)
    {
        using (StreamWriter sw = File.CreateText(filePath))
        {
            foreach (Entry entry in list_of_entries)
            {
                sw.WriteLine($"{entry._date},{entry._name},{entry._prompt},{entry._response}");
            }
        }
        Console.WriteLine("Journal entries have been saved to the file.");
    }

   
public void Load(string filePath)
{
    if (File.Exists(filePath))
    {
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._name = parts[1];
            entry._prompt = parts[2];
            entry._response = parts[3];
            list_of_entries.Add(entry);
        }
        Console.WriteLine("Journal entries have been loaded from the file.");
    }
    else
    {
        Console.WriteLine("The specified file does not exist.");
    }
}

public void Display(){

     foreach (Entry entry in list_of_entries)
        {
            Console.WriteLine($"Date: {entry._date}, Name: {entry._name}, Prompt: {entry._prompt}, Response: {entry._response}");
        }


}



}
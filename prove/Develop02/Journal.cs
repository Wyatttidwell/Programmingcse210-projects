using System;
using System.IO;
using System.Collections.Generic;
using PGen;

class Journal 
{ 
    List<Entry> entries = new List<Entry>();
    PromptClass give = new PromptClass();

    public void NewEntry() 
    {
        string prompt = give.Promptmethod(); 
        Console.WriteLine($"{prompt}?");
        string userInput = Console.ReadLine();        
        
        DateTime Time = DateTime.Now;
        string dateText = Time.ToShortDateString();
        
        Entry entry = new Entry(dateText, prompt, userInput);

        entries.Add(entry);
    }

    public void DisplayEntries() 
    {
        Console.WriteLine("Previous Entries:");
        foreach (Entry entry in entries) 
        {
            entry.Display();
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.date},{entry.prompt},{entry.userInput}");
            }
        }
    }

    public string Load()
    {
        Console.WriteLine("What file would you like to load?");

        string savedEntry = Console.ReadLine();

        string content = File.ReadAllText(savedEntry);

        Console.WriteLine($"{savedEntry} contains the following:");

        Console.WriteLine(content);

        return content;
    }
}
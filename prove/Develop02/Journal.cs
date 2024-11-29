using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"The file {filename} does not exist.");
            return;
        }

        entries.Clear();
        foreach (var line in File.ReadLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                var entry = new JournalEntry(parts[0], parts[1], parts[2]);
                entries.Add(entry);
            }
        }
        Console.WriteLine($"Journal loaded from {filename}.");
    }
}

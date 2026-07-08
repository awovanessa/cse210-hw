using System;
using System.Collections.Generic;
using System.IO;

// The Journal class is responsible for keeping track of a collection of
// Entry objects, and for displaying, saving, and loading that collection.
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Adds a new entry to the journal.
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Displays every entry currently stored in the journal.
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves all entries in the journal to the given file path.
    // Each entry is written as a single line using Entry.ToFileString().
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine($"Journal saved to {filename}.");
    }

    // Loads entries from the given file path, replacing any entries
    // currently stored in the journal.
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' was not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                _entries.Add(Entry.FromFileString(line));
            }
        }

        Console.WriteLine($"Journal loaded from {filename}.");
    }

    // Creativity feature: returns the total word count across every
    // entry currently stored in the journal. This encourages users to
    // see their writing add up over time, which can be a motivating
    // factor to keep journaling consistently.
    public int GetTotalWordCount()
    {
        int total = 0;
        foreach (Entry entry in _entries)
        {
            total += entry.GetWordCount();
        }
        return total;
    }
}
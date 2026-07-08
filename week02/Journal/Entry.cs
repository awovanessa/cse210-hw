using System;

// The Entry class is responsible for holding the details of a single
// journal entry: the date it was written, the prompt that was answered,
// and the response the user gave. It also knows how to display itself
// and how many words it contains.
public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    // Displays this single entry in a readable format.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }

    // Returns the number of words in this entry's response.
    // Used to support the journal's total word count feature.
    public int GetWordCount()
    {
        if (string.IsNullOrWhiteSpace(_entryText))
        {
            return 0;
        }

        string[] words = _entryText.Split(
            new char[] { ' ', '\t', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries
        );
        return words.Length;
    }

    // Converts this entry into a single line suitable for saving to a file.
    // Uses "~|~" as a separator, chosen because it is unlikely to appear
    // naturally in a user's journal response.
    public string ToFileString()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }

    // Builds an Entry object from a single line that was read from a file.
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);

        Entry entry = new Entry();
        entry._date = parts[0];
        entry._promptText = parts[1];
        entry._entryText = parts[2];
        return entry;
    }
}
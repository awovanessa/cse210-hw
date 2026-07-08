using System;

// Program.cs — Entry point for the Journal application.
//
// Creativity / Exceeds Requirements:
// This program tracks the total word count across all journal entries.
// Each time the journal is displayed, the total number of words the user
// has written is shown at the bottom. This gives the user a sense of
// progress and can serve as motivation to keep writing consistently,
// addressing the challenge of feeling unmotivated to journal.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayAll();
                    Console.WriteLine($"Total words written: {journal.GetTotalWordCount()}");
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("That is not a valid option. Please try again.");
                    break;
            }
        }
    }

    // Handles the process of asking a prompt, getting the user's response,
    // recording today's date, and adding the new entry to the journal.
    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = prompt;
        entry._entryText = response;

        journal.AddEntry(entry);
        Console.WriteLine("Entry added to the journal.");
    }
}
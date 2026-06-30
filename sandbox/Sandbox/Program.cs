using System;

class Program
{
    static void Main(string[] args)
    {
        // ask the user for their name.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"{last}, {first} {last}");
    }
}
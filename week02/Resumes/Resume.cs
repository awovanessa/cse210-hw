using System;
using System.Collections.Generic;

// The Resume class is responsible for keeping track of a person's name
// and their list of jobs.
public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Displays the resume: the person's name first, followed by each
    // job's details.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
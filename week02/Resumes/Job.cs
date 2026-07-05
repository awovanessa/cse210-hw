using System;

// The Job class is responsible for keeping track of the company, job title,
// start year, and end year for a single job in a person's resume.
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // Displays the job information in the format:
    // "Job Title (Company) StartYear-EndYear"
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
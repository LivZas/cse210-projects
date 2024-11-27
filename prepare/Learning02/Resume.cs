using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
    }

    public void Display()
    {
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}

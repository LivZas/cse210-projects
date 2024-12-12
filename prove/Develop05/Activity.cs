using System;
using System.Threading;

abstract class Activity
{
    private string name;
    private string description;
    protected int duration;
    protected static Random random = new Random();

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name} Activity.\n");
        Console.WriteLine(description);
        Console.Write("How long, in seconds, would you like your session? ");
        duration = int.Parse(Console.ReadLine());

        PrepareActivity();
        PerformActivity();
        EndActivity();
    }

    protected void PrepareActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    protected void PerformActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            PerformTask();
            Thread.Sleep(1000);
        }
    }

    protected void EndActivity()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine("\nYou have completed another " + duration + " seconds of the " + name + " Activity.");
        ShowSpinner(5);
    }

    protected void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] spinner = { "/", "-", "\\", "|" };
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
    }

    protected abstract void PerformTask();
}

using System;
using System.Threading;
using System.Collections.Generic;

class Listing : Activity
{
    private string[] prompts = {
        "When have you felt the Holy Ghost this month?",
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n")
    {
    }

    protected override void PerformTask()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine($"List as many responses as you can to the following prompt:\n--- {prompt} ---");

        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"You listed {responses.Count} items!");
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"You may begin in: {i} ");
            Thread.Sleep(1000);
        }

        Console.SetCursorPosition(0, Console.CursorTop);
        Console.WriteLine();
        Console.WriteLine("Start listing your responses now!");
    }
}

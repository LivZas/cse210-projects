using System;
using System.Threading;

class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n")
    {
    }

    protected override void PerformTask()
    {
        Console.Clear();
        int cycles = duration / 5;

        for (int i = 0; i < cycles; i++)
        {
            ShowTimer("Breathe in...", 5);
            Console.WriteLine();
            ShowTimer("Now breathe out...", 5);
            Console.WriteLine();
        }
    }

    private void ShowTimer(string message, int seconds)
    {
        int topPosition = Console.CursorTop;

        for (int i = seconds; i > 0; i--)
        {
            Console.SetCursorPosition(0, topPosition);
            Console.Write(message + " " + i);
            Thread.Sleep(1000);
        }

        Console.SetCursorPosition(0, topPosition); 
        Console.Write(message + "    ");  
        Thread.Sleep(1000);

        if (message.Contains("Now breathe out..."))
        {
            Console.WriteLine();
        }
    }
}

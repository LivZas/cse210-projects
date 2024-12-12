using System;
using System.Linq;
using System.Threading;

class Reflecting : Activity
{
    private string[] prompts = {
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you stood up for someone else."
    };
    private string[] questions = {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?"
    };

    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n")
    {
    }

    protected override void PerformTask()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine($"Consider the following prompt:\n--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        ShowCountdown(5);

        int numQuestions = questions.Length;
        int timePerQuestion = 5;
        int questionsToAsk = duration / timePerQuestion;

        int initialTop = Console.CursorTop;

        for (int i = 0; i < questionsToAsk && i < questions.Length; i++)
        {
            Console.SetCursorPosition(0, initialTop + i); 
            Console.WriteLine(questions[i]);

            int spaceAfterQuestion = questions[i].Length + 1;
            ShowTimerSpinner(timePerQuestion, initialTop + i, spaceAfterQuestion);
        }
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
        Console.Clear();
    }

    private void ShowTimerSpinner(int seconds, int linePosition, int spaceAfterQuestion)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] spinner = { "/", "-", "\\", "|" };
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.SetCursorPosition(spaceAfterQuestion, linePosition);
            Console.Write($"{spinner[i]} ");
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }

        Console.SetCursorPosition(spaceAfterQuestion, linePosition);
        Console.Write("   ");
        Console.WriteLine();
    }
}

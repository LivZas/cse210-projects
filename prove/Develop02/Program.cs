using System;

public class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Random rand = new Random();
                    string prompt = prompts[rand.Next(prompts.Length)];
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("MM/dd/yyyy");
                    JournalEntry newEntry = new JournalEntry(date, prompt, response);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}

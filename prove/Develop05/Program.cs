using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            int choice = int.Parse(Console.ReadLine());

            Activity activity;

            switch (choice)
            {
                case 1:
                    activity = new Breathing();
                    activity.StartActivity();
                    break;
                case 2:
                    activity = new Reflecting();
                    activity.StartActivity();
                    break;
                case 3:
                    activity = new Listing();
                    activity.StartActivity();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}

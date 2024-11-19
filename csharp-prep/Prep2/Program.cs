using System;
using System.Net.Mime;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();



        int x = int.Parse(valueFromUser);
        int y = 2;
        int z = 5;

        if (!(x < y || x < z) && y < z )
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
       else
       {
        Console.WriteLine("Equal");
       }
    }
}
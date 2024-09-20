using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

        Console.Write("What is your last namw?");
                string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}
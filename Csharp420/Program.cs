#nullable disable
using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Select the prep file to run (1-5) or type 0 to quit:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Prep1 prep1 = new Prep1();
                    prep1.Run();
                    break;
                case "2":
                    Prep2 prep2 = new Prep2();
                    prep2.Run();
                    break;
                case "3":
                    Prep3 prep3 = new Prep3();
                    prep3.Run();
                    break;
                case "4":
                    Prep4 prep4 = new Prep4();
                    prep4.Run();
                    break;
                case "5":
                    Prep5 prep5 = new Prep5();
                    prep5.Run();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5 or 0 to quit.");
                    break;
            }
        }
    }
}
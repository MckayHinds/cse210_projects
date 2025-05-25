using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Mindfulness Activity");
            Console.WriteLine("Please select a number below.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit Program");
            string choice = Console.ReadLine();
        }
        switch (choice)
        {
            case "1":
                BreathingActivity b = new BreathingActivity
        }
    }

}
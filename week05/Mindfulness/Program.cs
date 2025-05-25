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
            Console.Write("Enter your choice:");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var b = new BreathingActivity("This Activity will help you calm yourself through Breathing");
                    b.Run();
                case "2":
                    var r = new ReflectionActivity("This Activity will help you calm yourself through Reflection");
                    r.Run();
                case "3":
                    var l = new ListingActivity("This Activity will help you calm yourself through Listing");
                    l.Run();
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Choice");
                    break;
            }
        }

        Console.WriteLine("Thank you for trying the Mindful Activity!");
    }
}
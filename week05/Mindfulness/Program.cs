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
                    var b = new BreathingActivity("Breathing", "This activity will help you relax by guiding you through slow breathing.");
                    b.Run();
                    break;
                case "2":
                    var r = new ReflectionActivity("Reflection", "This activity will help you reflect on the good things in your life.");
                    r.Run();
                    break;
                case "3":
                    var l = new ListingActivity("Listing", "This activity will help you focus by listing items.");
                    l.Run();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }
        }

        Console.WriteLine("Thank you for trying the Mindful Activity!");
    }
}
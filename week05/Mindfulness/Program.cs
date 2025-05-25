using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfullness Project");
        Console.WriteLine("Please Pick One: 1. Breathing Exersizes 2. Reflection 3. Ponder and List");
        string choice = Console.ReadLine();
        if (choice == "1") ;
        {
            Console.WriteLine("Lets begin our breathing session.");
            Console.WriteLine("Take a deep breath in.");
            Console.WriteLine("Hold...");
            Thread.Sleep(15000);
            Console.WriteLine("Breathe out.");

        }
    }

}
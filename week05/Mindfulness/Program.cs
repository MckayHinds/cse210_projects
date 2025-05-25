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
        else if (choice == "2") ;
        {
            Console.WriteLine("Lets begin our reflection session");
            Console.WriteLine("Think of a situation this past week that you could have handled differently.");
        }
        else
        {
            Console.WriteLine("Lets begin our Ponder and list session.");
            
        }
    }

}
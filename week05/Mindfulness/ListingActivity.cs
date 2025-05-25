using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
   //Pulled from previous code
    {
        "What are your favorite things to do?",
        "Who do you appreciate in life?",
        "Who have you helped this week?",
        "What have you accomplished this week?"
    };
    public ListingActivity(string name, string description) : base(name, description) { }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        GetRandomFromList(_prompts);
        Console.WriteLine("Take some time to consider the prompts");
        Console.WriteLine("Start writing in: ");
        ShowCountdown(10);

        //Date & time stuff
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items");
        DisplayEndingMessage();
    }
    private void GetRandomFromList(List<string> list)
    {
        Random rand = new Random();
        int index = rand.Next(list.Count);
        Console.WriteLine(list[index]);
    }
}
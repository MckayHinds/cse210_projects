using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
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
        GetRandomIntList(_prompts);
        Console.WriteLine("Take some time to consider the prompt.");
        Console.WriteLine("Writing in: ");
        ShowCoundown(20);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }

    }
}
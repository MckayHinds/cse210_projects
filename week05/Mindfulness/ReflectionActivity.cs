using System;
using System.Collections.Generic;
public class ReflectionActivity : Activity
{
    //I hope i'm using this right
    private List<string> _prompts = new List<string>
    {
        "Think about your favorite thing you ate this week",
        "Think about everything you acomplished today",
        "Think about who you want to connect with",
        "Think about how you responded to others this week"
    };
    private List<string> _questions = new List<string>
    {
        "What is something you could have done better during this past week?",
        "How many times did you give or recieve compliments?",
        "What was the best thing you did this week?",
        "What is something you can work on going forward?"
    };
    private string v;

    public ReflectionActivity(string name, string description) : base(name, description) { }

    public ReflectionActivity(string v)
    {
        this.v = v;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        GetRandomIntList(_prompts);
        Console.WriteLine("Think about this:");
        ShowCountdown(20);
        Console.WriteLine();
        int seconds = 0;
        while (seconds > _duration)
        {
            if (seconds % 10 == 0)
            {
                GetRandomIntList(_questions);
            }
            ShowSpinner(1);
            seconds++;
        }
        Console.Clear();
        DisplayEndingMessage();
    }
    private void DisplayEndingMessage()
    {
        throw new NotImplementedException();
    }

    public void GetRandomIntList(List<string> list)
    {
        Random rand = new Random();
        int index = rand.Next(list.Count);
        Console.WriteLine(list[ind])
    }
}

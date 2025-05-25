using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    // Added from Previous Code
    private List<string> _prompts = new List<string>
    {
        "Think about your favorite thing you ate this week.",
        "Think about everything you accomplished today.",
        "Think about who you want to connect with.",
        "Think about how you responded to others this week."
    };
    private List<string> _questions = new List<string>
    {
        "What is something you could have done better this week?",
        "How many times did you give or receive compliments?",
        "What was the best thing you did this week?",
        "What is something you can work on going forward?"
    };

    public ReflectionActivity(string name, string description) : base(name, description) { }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        GetRandomFromList(_prompts);
        
    }
}

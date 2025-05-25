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
    public ReflectionActivity(string name, string description) : base(name, description) {}
}
using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_name}: {_description}");
        Console.Write("Enter your desired Duration in Seconds");
        string input = Console.ReadLine();
        try
        {
            _duration = int.Parse(input);
        }
        catch
        {
            Console.WriteLine("Invalid input, Please try again. Defaulting in 30 seconds");
            _duration = 30;
        }
    }
}
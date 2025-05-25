using System;
using System.Threading;
public class Activity;
{
    private string _name;
    private string _description;
    protected interface _duration;

    public Activity(string name, string _description);
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
    Console.Clear();
    Console.WriteLine($"{_name}: {_description}");
    Console.WriteLine("Enter desired activity duration in seconds: ");
    string duration = Console.ReadLine();
    try
    {

    }
    }
}
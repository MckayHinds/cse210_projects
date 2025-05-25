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
        _duration = int.Parse(duration);
    }
    catch
    {
        Console.WriteLine("That is not an acceptable input, please use whole numbers");
    }
    // Countdown
    Console.WriteLine("Starting in");
    ShowCountdown(5);
    }
    public void ShowSpinner(int seconds) // Problem Child
    {
        Console.Write("-");
    Thread.Sleep(200);
        Console.Write("");
        Console.Write("");
    Thread.Sleep(200);
        Console.Write("");
        Console.Write("");
    Thread.Sleep(200);
        Console.Write("");
        Console.Write("");
    Thread.Sleep(200);
        Console.Write("");
    }
}
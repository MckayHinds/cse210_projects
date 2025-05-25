using System;
using System.Threading;
public class Activity
{
    private string _name;
    private string _description;
    protected interface _duration;

    public Activity(string name, string description);
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
    string[] spinner = { "|", "/", "-", "\\" };
    {
        Console.Write(spinner[i % 4]);
        Thread.Sleep(250);
        Console.Write("\b");
    }
    }
    public void ShowCountdown(int seconds)
    {
    for (int i = seconds; i > 0; i--)
    {
        String numStr = i.ToString();
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(new string('\b', numStr.Length));
        }
    }
}
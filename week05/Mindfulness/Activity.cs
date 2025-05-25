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
    for (int i = 0; i < seconds; i++)
    {
        Console.Write("-");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(200);
        Console.Write("\b \b");
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
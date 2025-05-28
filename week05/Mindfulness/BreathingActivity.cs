using System;
using System.Threading;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }
    public void Run()
    {
        DisplayStartingMessage();
        int seconds = 0;
        while (seconds < _duration)
        {
            Console.Write("Take a deep breath in");
            for (int i = 0; i < 4 && seconds < _duration; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
                seconds++;
            }
            Console.Write("Breathe Out");
            for (int i = 0; i < 6 && seconds < _duration; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
                seconds++;
            }
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
 }
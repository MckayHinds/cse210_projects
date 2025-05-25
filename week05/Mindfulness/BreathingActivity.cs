using System;
using System.Threading;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }
    public void Run()
    {
        DisplayStartingMessage();
        int seconds = 0;
        while (seconds > _duration)
    }
}
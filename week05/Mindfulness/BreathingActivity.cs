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
            Console.Clear();
            Console.write("Breathe In.");
            for (int i = 0; i < 4; i++)
            {
                if (seconds >= _duration) break;
                Console.Write(".");
                Thread.Sleep(1000);
                seconds++;
            }
            // If it says I coppied here it's because I coppied from the "Breathe In" portion. 
            Console.WriteLine();
            Console.Write("Breathe Out.")
            for (int i = 0; i < 10; i++)
                if (seconds >= _duration) break;
            Console.Write(".");
            Thread.Sleep(1000);
            seconds++;
        }
        Console.Clear();
        DisplayEndingMessage();
    }
}
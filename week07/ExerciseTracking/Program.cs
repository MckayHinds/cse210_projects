using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025,06,02), 30, 4.8),
            new Cycling(new DateTime(2025,06,02),45, 15.5),
            new Swimming(new DateTime(2025,06,02),40,30)
        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
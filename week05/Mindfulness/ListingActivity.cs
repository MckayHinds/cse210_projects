using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
   //Pulled from previous code
    {
        "What are your favorite things to do?",
        "Who do you appreciate in life?",
        "Who have you helped this week?",
        "What have you accomplished this week?"
    };
    public ListingActivity(string name, string description) : base(name, description) { }
    public void Run()
    {
        
    }
}
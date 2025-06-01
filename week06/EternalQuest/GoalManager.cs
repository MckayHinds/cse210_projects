using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public void Start()
    {
        string input = "";
        while (input != "7")
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goals.");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Prayer Info");
            Console.WriteLine("7. Quit");
            Console.Write("Select a Choice");
            input = Console.ReadLine();

            if (input == "1") CreateGoal();
            else if (input == "2") ListGoalDetails();
            else if (input == "3") SaveGoals();
            else if (input == "4") LoadGoals();
            else if (input == "5") RecordEvent();
            else if (input == "6") DisplayPlayerInfo();
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            //this part is a bit confusing but I think this is right
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Goal Types: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type do you want to work on?");
    }
}
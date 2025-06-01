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
        //Goal Types
        Console.WriteLine("Goal Types: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type do you want to work on?");
        string Choice = Console.ReadLine();

        //Name,Description,Points
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        //Choices
        if (Choice == "1") _goals.Add(new SimpleGoal(name, description, points));
        else if (Choice == "2") _goals.Add(new EternalGoal(name, description, points));
        else if (Choice == "3")
        {
            Console.Write("Target times: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("What goal were you able to accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        int points = _goals[index].RecordEvent();
        _score += points;
        Console.WriteLine($"You earned {points} points!");
    }
    public void SaveGoals()
    {
        Console.Write("Enter File Name: ");
        string filename = Console.ReadLine();
        //StreamWriter! trying out some different functions rather than what I am used to. - Scrap if doesn't work*
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }

        }
    }
    //This one is rediculously long.
    public void LoadGoals()
    {
        Console.Write("Enter File Name: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();
    }
}
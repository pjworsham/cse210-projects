
using System.IO;
using System.Linq.Expressions;
using System.Net;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager() 
    {
        _goals = new List<Goal>(); 
        _score = 0;

    }
  
    public void Start()
    {
        int response = 0;
        while (response < 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a Choice from the menu: ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                CreateGoal();    
            }
            else if (response == 2)
            {
                ListGoalDetails();
            }
            else if (response == 3)
            {
                SaveGoals();
            }
            else if (response == 4)
            {
                LoadGoals();
            }
            else if (response == 5)
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points." );
    }
    public void ListGoalNames()
    {
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int userInput = int.Parse(Console.ReadLine());


        if (userInput == 1)
        {

            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with the goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(simpleGoal);

        }
        else if (userInput == 2)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with the goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternalGoal);

        }
        else if (userInput == 3)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with the goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTimes = int.Parse(Console.ReadLine());
            
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTimes, goalBonus);
            _goals.Add(checklistGoal);
            
        }
                    
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine());

        int earnedPoints = _goals[userInput - 1].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        _score = _score + earnedPoints;
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();

        
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
             string[] parts = lines[i].Split(":");
             string goalType = parts[0];
             string goalDetails = parts[1];
             if(goalType == "SimpleGoal")
             {
                string[] goalParts = goalDetails.Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                string IsComplete = goalParts[3];
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                if (IsComplete == "True")
                {
                    simpleGoal.RecordEvent();
                }
                _goals.Add(simpleGoal);
             }
             else if(goalType == "EternalGoal")
             {
                string[] goalParts = goalDetails.Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
             }
             else if(goalType == "ChecklistGoal")
             {
                string[] goalParts = goalDetails.Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                int bonus = int.Parse(goalParts[3]);
                int target = int.Parse(goalParts[4]);
                int amountCompleted = int.Parse(goalParts[5]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                checklistGoal.SetAmountCompleted(amountCompleted);
                _goals.Add(checklistGoal);
             }
        }
    }
}
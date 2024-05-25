

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
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

    }
    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal()
    {
        ListGoalNames();
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

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
}
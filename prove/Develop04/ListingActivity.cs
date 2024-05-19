

using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
         _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = 
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        List<string> userInput = GetListFromUser();
        _count = userInput.Count;
        Console.WriteLine($"You listed {_count} items! ");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }

    public List<string> GetListFromUser()
    {
        List<string> userInput = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);   

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userInput.Add(Console.ReadLine());
   
        }
        return userInput;

    }
}
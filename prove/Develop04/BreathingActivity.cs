

public class BreathingActivity : Activity
{


    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through your breathing in and out slowly. Clear your mind and focus on your breathing.";
       
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowCountDown(5);
            Console.WriteLine(); 
        } 
        Console.WriteLine();
        DisplayEndingMessage();
        

    }

}


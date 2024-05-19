using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        Activity activity = new Activity();

        int response = 0;
        while (response != 4)
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                breathingActivity.Run(); 
            }
            else if (response == 2)
            {
                reflectingActivity.Run();
            }
            else if (response == 3)
            {
                listingActivity.Run();
            }

        }







    //     //Breathing message

    //     Console.WriteLine("Welcome to the Breathing Activity.");
    //     Console.WriteLine();
    //     Console.WriteLine("This activity will help you relax by walking you through your breathing in and out slowly. Clear your mind and fous on your breathing.");
    //     Console.WriteLine();
        
    

    //     //Breathing prompts
    
    //     Console.WriteLine();
    //     Console.WriteLine();
    //     Console.WriteLine("Breathe in...");
    //     Console.WriteLine("Breathe out...");
    //     Console.WriteLine();
    //     Console.WriteLine("Well done!!");





    //     //Relection Message
    //     Console.WriteLine("Welcome to the Reflecting Activity.");
    //     Console.WriteLine();
    //     Console.WriteLine("This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    //     Console.WriteLine();
    //     Console.Write("How long, in seconds, would you like for your session? ");
    //     Console.ReadLine();
    //     Console.WriteLine("Get ready...");
    //     Console.WriteLine();
    //     Console.WriteLine("Consider the following prompt:");
    //     Console.WriteLine();

    //     Console.WriteLine("When you have something in mind, press enter to continue.");
    //     Console.ReadLine();
    //     Console.WriteLine("Well done!!");



    //     //Reflection prompts
    //     Console.WriteLine("Think of a time when you stood up for someone else.");
    //     Console.WriteLine("Think of a time when you did something really difficult.");
    //     Console.WriteLine("Think of a time when you helped someone in need.");
    //     Console.WriteLine("Think of a time when you did something truly selfless.");


    //     //Reflection Questions
    //     Console.WriteLine("Why was this experience meaningful to you? ");
    //     Console.WriteLine("Have you ever done anything like this before? ");
    //     Console.WriteLine("How did you get started? ");
    //     Console.WriteLine("How did you get started? ");
    //     Console.WriteLine("How did you feel when it was complete? ");
    //     Console.WriteLine("What made this time different than other times when you were not as successful? ");
    //     Console.WriteLine("What is your favorite thing about this experience? ");
    //     Console.WriteLine("What could you learn from this experience that applies to other situations? ");
    //     Console.WriteLine("What did you learn about yourself through this experience? ");
    //     Console.WriteLine("How can you keep this experience in mind in the future? ");


    //      //Listing Activity message

    //     Console.WriteLine("Welcome to the Listing Activity.");
    //     Console.WriteLine();
    //     Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    //     Console.WriteLine();
    //     Console.Write("How long, in seconds, would you like for your session? ");
    //     Console.ReadLine();
    //     Console.WriteLine("Get ready...");

    //     //Listing prompts
    //     Console.WriteLine("Who are people that you appreciate? ");
    //     Console.WriteLine("What are personal strengths of yours? ");
    //     Console.WriteLine("Who are people that you have helped this week? ");
    //     Console.WriteLine("When have you felt the Holy Ghost this month? ");
    //     Console.WriteLine("Who are some of your personal heroes? ");
    //     Console.WriteLine();
    //     Console.WriteLine("Well done!!");

    }
}
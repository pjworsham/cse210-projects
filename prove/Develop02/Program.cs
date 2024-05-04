using System;
using System.Net;


class Program
{
    static void Main(string[] args)
    {

        //create (instance) or (object) of prompt generator class
        PromptGenerator promptGenerator = new PromptGenerator();

        //create list of prompts
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today? ");
        prompts.Add("What was the best part of my day? ");
        prompts.Add("How did I see the hand of the Lord in my life today? ");
        prompts.Add("What was the strongest emotion I felt today? ");
        prompts.Add("If I had one thing I could do over today, what would it be? ");

        //save list of prompts to object
        promptGenerator._prompts = prompts;

        //create a instance (object) of the Journal class
        Journal journal = new Journal();

        int response = 0;
        while (response < 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                //returns a random prompt and stores in a variable called randomPrompt
                string randomPrompt = promptGenerator.GetRandomPrompt();
                //writes to console the random prompt and reads the users entry text
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string input = Console.ReadLine();

                //got the current time and stored it in a variable called dateText
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //created a new object of the entry class
                Entry entry = new Entry();
                entry._date = dateText;
                entry._promptText = randomPrompt;
                entry._entryText = input;
                
                //add entry to the journal
                journal.AddEntry(entry);

            }
            else if (response == 2)
            {
                journal.DisplayAll();
            }
            else if (response == 3)
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile($"{filename}.txt");
            }
            else if (response == 4)
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                journal.SaveToFile($"{filename}.txt");
            }
            
       }

    }   
}       

       

        
      
    

      

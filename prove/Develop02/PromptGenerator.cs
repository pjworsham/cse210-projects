

public class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        //create an object of the Random class
        Random random = new Random();
        //generated a random number and stored it inside of a variable
        int number = random.Next(_prompts.Count);
        //created a variable to store random prompt from the list of prompts
        string randomPrompt = _prompts[number];
        return randomPrompt;

    }
       
}

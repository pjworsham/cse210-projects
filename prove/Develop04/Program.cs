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

    }
}
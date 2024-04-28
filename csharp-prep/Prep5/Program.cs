using System;

class Program
{
    static void Main(string[] args)
    
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numbersquared = SquareNumber(number);
        DisplayResult(numbersquared, name);
    
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;

    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoritenumber = Console.ReadLine();
        int number = int.Parse(favoritenumber);
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(int number, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}
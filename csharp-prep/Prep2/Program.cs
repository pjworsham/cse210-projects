using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
      

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter;

        if (number >=90)
        {
           letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");


       if (number >= 70)
       {
            Console.WriteLine("Congratulations, you passed the class! ");
       }
       else
       {
            Console.WriteLine("You did not pass the class. Try again later!");
       }

    }
}
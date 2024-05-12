using System;
using System.Net.Quic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string book = "Proverbs"; 
        int chapter = 3;
        int verse = 5;
        int endVerse = 6;

        Reference reference = new Reference(book, chapter, verse, endVerse);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine(scripture.GetDisplayText());

        string userInput = "";
        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());

        }

       
        

   
    }
}
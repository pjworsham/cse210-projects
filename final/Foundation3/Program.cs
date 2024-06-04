using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
    
        Address address = new Address ("202 Warsaw Rd", "Canton", "GA", "USA");
        Lectures lectures = new Lectures ("Showing Love as Christ Would", "A discuss about Loving as Christ would", "6/24/2024", "8:00pm", address, "Elder Stewart and Oler", 100);

        Receptions receptions = new Receptions ("Wedding", "Mr. & Mrs. Jones taking there vows.", "6/3/2024", "6:00pm", address, "weddingJones@gmail.com");

        OutdoorGatherings outdoorGatherings = new OutdoorGatherings ("50th Birthday Party", "Bill Smith's 50th Birthday Party", "7/10/2024", "12:00pm", address, "Partly cloudy");
        
        Console.WriteLine();
        Console.WriteLine("Lecture:");
        Console.WriteLine (lectures.GetFullDetails());
        Console.WriteLine ();
        Console.WriteLine (lectures.GetShortDescription());
        Console.WriteLine ();
        Console.WriteLine("Recptions:");
        Console.WriteLine (receptions.GetFullDetails());
        Console.WriteLine ();
        Console.WriteLine (receptions.GetShortDescription());
        Console.WriteLine ();
        Console.WriteLine ("Outdoor Gathering:");
        Console.WriteLine (outdoorGatherings.GetFullDetails());
        Console.WriteLine ();
        Console.WriteLine (outdoorGatherings.GetShortDescription());
    }
    
}
using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Choose Wisely", "Quentin L. Cook", 920);
        Comment comment1 = new Comment("@markjolyn94", "This beautiful talk is even more imperative now.");
        Comment comment2 = new Comment("@leilanatui", "this talk is the answer to my prayers lately");
        Comment comment3 = new Comment("@Omegaej1", " Needed this today");

        videos.Add(video1);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("How I #HereHim", "President Dallin H. Oaks", 184);
        Comment comment4 = new Comment("@josephasamoah144", "Truly a man of God");
        Comment comment5 = new Comment("@williamphillips2060", "The Lord was concerned for ONE youth in the stake, and inspired President Oaks to deliver a message to him.  Truly an instance of leaving the 90 and 9 and helping the one.");
        Comment comment6 = new Comment("@moroniafrifa614", "Thank you very much President Oaks");

        videos.Add(video2);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment (comment6);

        Video video3 = new Video("Finding JOy in the Journey", "M. Russell Ballard", 920);
        Comment comment7 = new Comment("@createdbyzette7397", "Seeing President Monson feels like he is still with us");
        Comment comment8 = new Comment("wij2012Gaming", "I don't think I've ever missed President Monson more than I do now.");
        Comment comment9 = new Comment("j.huffhumble4281", "I love you President Monson");

        videos.Add(video3);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        

        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.Display();
        }


    }
}
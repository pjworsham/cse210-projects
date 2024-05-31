using System.Security.Cryptography.X509Certificates;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comment.Count;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Seconds: {_length}, Number of Comments:{GetCommentCount()}");

        foreach (Comment comment in _comment)
        {
            comment.Display();
        }  
    }  
}
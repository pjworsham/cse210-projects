public class Comment
{
    private string _name;
    private string _commentText;
    
   

    public Comment(string name, string text)
    {
        _name = name;
        _commentText = text;
        
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}, Comment: {_commentText}");
    }
    
}
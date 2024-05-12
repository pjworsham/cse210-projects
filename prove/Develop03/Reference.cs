
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
        
    }
    public Reference(string book, int chapter, int startVerse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endverse;
    }
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
    

   
}
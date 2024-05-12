using System;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words = [];

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] arrayText = text.Split(" ");
        foreach (string word in arrayText)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {

       Random random = new Random();
       for (int i = 0; i < numberToHide; i++)
       {
            int index = random.Next(0, _words.Count);
            _words[index].Hide();
            
       }
    }
    public string GetDisplayText()
    {
        string text = "";
        text +=_reference.GetDisplayText();
        foreach (Word word in _words)
        {
            text += $" {word.GetDisplayText()}";
        }
        return text;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHIdden())
            {
                return false;
            }
        }
        return true;
    }
}


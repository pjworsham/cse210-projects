
using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _text;

    private bool _isHidden;

    public Word(string text)
    {
       _text = text; 
       _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHIdden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string newString = _text;
            for (int i = 0; i < newString.Length; i++)
            {
                char toReplace = newString[i];
                newString = newString.Replace(toReplace, '_');
            }
            return newString;
        }
        else 
        {
            return $"{_text}";
        }
    }

}
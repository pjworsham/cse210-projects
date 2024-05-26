

using System.ComponentModel;
using System.Net.NetworkInformation;

public abstract class Goal 
{
    //member variables should be private
    protected string _shortName;
    protected string _description;
    protected int _points;

    //this is the constructor and it should always be public, initialize the member variables, parameters must have a data type (string)
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }

    public string GetName()
    {
        return _shortName;
    }
    
    //abstract method does not need a body in parent class because the child class has the implementation. The child class is required to implement abstract methods
    public abstract int RecordEvent();
    
    public abstract bool IsComplete();
   
   // The child class can override the method. 
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
   
    public abstract string GetStringRepresentation();
    
}
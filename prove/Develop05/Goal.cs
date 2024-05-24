

using System.ComponentModel;

public abstract class Goal 
{
    //member variables should be private
    private string _shortName;
    private string _description;
    private int _points;

    //this is the constructor and it should always be public, initialize the member variables, parameters must have a data type (string)
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    //abstract method does not need a body in parent class because the child class has the implementation
    public abstract void RecordEvent();
    
    public abstract bool IsComplete();
   
    public virtual string GetDetailsString()
    {
        return "";
    }
   
    public abstract string GetStringRepresentation();
    
}
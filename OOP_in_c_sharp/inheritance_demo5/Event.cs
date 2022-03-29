using System;
public class Event
{
    protected string _name;
    protected DateTime _date;
    protected string _type;
    protected string _organizer;
    //Fill your code
    public Event()
    {

    }
    public Event (string name, DateTime date, string type, string organizer)
    {
        _name = name;
        _date = date;
        _type = type;
        _organizer = organizer;
    }
}
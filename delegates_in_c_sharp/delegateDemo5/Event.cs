using System;

internal class Event
{
    private string _name;
    private string _type;
    private string _organizer;
    public Event(string _name, string _type, string _organizer)
    {
        this._name = _name;
        this._type = _type;
        this._organizer = _organizer;
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public string Type
    {
        get
        {
            return _type;
        }
        set
        {
            _type = value;
        }
    }
    public string Organizer
    {
        get
        {
            return _organizer;
        }
        set
        {
            _organizer = value;
        }
    }
    // fill your code
    public override string ToString()
    {
        return string.Format("{0,-15}{1,-15}{2,-15}", _name, _type, _organizer);
    }

}

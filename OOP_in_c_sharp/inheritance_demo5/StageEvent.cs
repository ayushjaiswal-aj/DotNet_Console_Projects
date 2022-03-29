using System;
public class StageEvent : Event
{
    private string _showType;
    //Fill your code
    public StageEvent(string name, DateTime date, string type, string organizer, string showType)
        : base(name, date, type, organizer)
    {
        _showType = showType;
    }
    public void Display()
    {
        Console.WriteLine($"Event Name: {base._name}\n" +
            $"Event Date: {base._date.ToString("dd/MM/yyyy")}\n" +
            $"Event Organizer: {base._organizer}\n" +
            $"Event Type: {base._type}\n" +
            $"Stall Type: {_showType}");
    }
}
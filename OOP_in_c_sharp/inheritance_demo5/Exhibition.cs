using System;
public class Exhibition : Event
{
    private string _stallType;
    //Fill your code
    public Exhibition(string name, DateTime date, string type, string organizer, string stallTYpe)
        : base(name, date, type, organizer)
    {
        _stallType = stallTYpe;
    }

    public void Display()
    {
        Console.WriteLine($"Event Name: {base._name}\n" +
            $"Event Date: {base._date.ToString("dd/MM/yyyy")}\n" +
            $"Event Organizer: {base._organizer}\n" +
            $"Event Type: {base._type}\n" +
            $"Stall Type: {_stallType}");
    }
}
using System;
using System.Collections.Generic;

class Program
{
    public delegate void EventDelegate(List<Event> events);

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter total number of events");
        // fill your code 
        int noOfEvents = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter event details");
        // fill your code
        Event e;
        List<Event> events = new List<Event>();
        for (int i = 0; i < noOfEvents; i++)
        {
            string[] details = Console.ReadLine().Split(",");
            e = new Event(details[0], details[1], details[2]);
            events.Add(e);
        }

        Console.WriteLine("{0,-15}{1,-15}{2,-15}", "EventName", "EventType", "EventOrganizer");

        EventDelegate eventDel = new EventDelegate(Program.ShowEvent);
        eventDel(events);
    }

    static Action<List<Event>> ShowEvent = eventList =>
    {
        foreach (Event e in eventList)
        {
            Console.WriteLine($"{e.ToString()}");
        }
    };
}


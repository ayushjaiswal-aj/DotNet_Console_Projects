using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter event name");
        string _name = Console.ReadLine();
        Console.WriteLine("Enter the cost per day");
        double _costPerDay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the number of days");
        int _noOfDays = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the type of event\n1.Exhibition\n2.Stage Event");
        int _type = Convert.ToInt32(Console.ReadLine());
        //Fill your code here
        if(_type > 0 && _type < 3)
        {
            if(_type == 1)
            {
                Console.WriteLine("Enter the number of stalls");
                int noOfStalls = Convert.ToInt32(Console.ReadLine());
                Exhibition e = new Exhibition(_name, "Exhibition", _costPerDay, _noOfDays, noOfStalls);
                Console.WriteLine("Event Details");
                Console.WriteLine(e.ToString());
            }
            else if (_type == 2)
            {
                Console.WriteLine("Enter the number of seats");
                int noOfSeats = Convert.ToInt32(Console.ReadLine());
                StageEvent se = new StageEvent(_name, "Stage Event", _costPerDay, _noOfDays, noOfSeats);
                Console.WriteLine("Event Details");
                Console.WriteLine(se.ToString());
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
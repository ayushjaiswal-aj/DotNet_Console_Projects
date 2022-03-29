using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Event Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Detail");
        string detail = Console.ReadLine();
        Console.WriteLine("Enter Organizer");
        string organizer = Console.ReadLine();
        Console.WriteLine("Select Event Type 1.Exhibition 2.StageEvent");
        int ch = Convert.ToInt32(Console.ReadLine());
        //Fill Your Code Here
        switch (ch)
        {
            case 1:
                Console.WriteLine("Enter stall count");
                int stallCount = Convert.ToInt32(Console.ReadLine());
                Exhibition e = new Exhibition(name, detail, organizer, stallCount);
                Console.WriteLine(e.ToString());
                e.TotalCredit();
                break;

            case 2:
                Console.WriteLine("Enter Total shows");
                int totalShows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter seats per show");
                int seatsPerShow = Convert.ToInt32(Console.ReadLine());
                StageEvent se = new StageEvent(name, detail, organizer, totalShows, seatsPerShow);
                Console.WriteLine(se.ToString());
                se.TotalCredit();
                break;

            default:
                Console.WriteLine("Enter valid choice");
                break;
        }
    }
}

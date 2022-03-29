using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Event Name:");
        //Fill your code
		string name = Console.ReadLine();
        Console.WriteLine("Enter the Event Date:");
		//Fill your code
		string d = Console.ReadLine();
		DateTime date = Convert.ToDateTime(d);
        Console.WriteLine("Enter the Event Organizer:");
        //Fill your code
		string organizer = Console.ReadLine();
        Console.WriteLine("Enter the Event Type(Exhibition/Stage Event):");
        string eType = Console.ReadLine();

		if(eType == "Exhibition")
		{
			Console.WriteLine("Enter the Stall Type:");
			//Fill your code
			string stallType = Console.ReadLine();
			Exhibition e = new Exhibition(name, date, eType, organizer, stallType);
			e.Display();
		}
		else if(eType == "Stage Event")
		{
			Console.WriteLine("Enter the Show Type:");
			//Fill your code
			string showType = Console.ReadLine();
			StageEvent se = new StageEvent(name, date, eType, organizer, showType);
			se.Display();
		}
		else
		{
			Console.WriteLine("Enter the correct Event Type and try again...");
		}
    }
}

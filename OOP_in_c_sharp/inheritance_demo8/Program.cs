using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the stall type");
        string type = Console.ReadLine();
        Console.WriteLine("Enter the square feet");
        int area = Convert.ToInt32(Console.ReadLine());
        //fill code here
        Stall stall = new Stall();

        if ("Gold" == type)
        {
            stall.ComputeCost(type, area);
        }
        else if("Diamond" == type)
        {
            Console.WriteLine("Enter the number of TV");
            int noOfTV = Convert.ToInt32(Console.ReadLine());
            stall.ComputeCost(type, area, noOfTV);
        }
        else if ("Platinum" == type)
        {
            Console.WriteLine("Do you need a projector(yes/no)");
            string needProjector = Console.ReadLine();
            stall.ComputeCost(type, area, needProjector == "yes");
        }
    }
}
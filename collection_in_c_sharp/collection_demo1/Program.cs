using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		// fill your codeL
		List<Hall> halls = new List<Hall>();
		int ch;
		halls.Add(new Hall("Hardy Marriage Hall", 9092314678, 200.0, "Hardy"));
		halls.Add(new Hall("ABC Party Hall", 9092310078, 120.0, "Ram"));
		halls.Add(new Hall("Conferance Hall", 9092314677, 400.0, "Ravi"));

		// fill your code
		do
		{
			Console.WriteLine("1.Add New Hall\n2.Display Hall\n3.Replace Hall\n4.Exit");
			Console.WriteLine("Enter your choice");
			ch = Convert.ToInt32(Console.ReadLine());
			switch (ch)
            {
				case 1:
					Hall newHall = new Hall();
					Console.WriteLine("Enter Name");
					newHall.Name = Console.ReadLine();
					Console.WriteLine("Enter phoneNo");
					newHall.ContactNumber = Convert.ToInt64(Console.ReadLine());
					Console.WriteLine("Enter Cost Per Day");
					newHall.CostPerDay = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter Owner Name");
					newHall.OwnerName = Console.ReadLine();
					halls.Add(newHall);
					
					break;

				case 2:
					foreach (Hall hall in halls)
                    {
						Console.WriteLine(hall.ToString());
                    }
					break;

				case 3:
					Console.WriteLine("Enter the Index position");
					int index = Convert.ToInt32(Console.ReadLine());
					Hall NewHall = new Hall();
					Console.WriteLine("Enter Name");
					NewHall.Name = Console.ReadLine();
					Console.WriteLine("Enter phoneNo");
					NewHall.ContactNumber = Convert.ToInt64(Console.ReadLine());
					Console.WriteLine("Enter Cost Per Day");
					NewHall.CostPerDay = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter Owner Name");
					NewHall.OwnerName = Console.ReadLine();
					halls.Insert(index, NewHall);

					break;

				case 4:
					break;

				default:
					Console.WriteLine("Enter Valid Choice");
					break;
            }
		} while (ch != 4);
    }
}
    
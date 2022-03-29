using System;

public class Program {
	public static void Main(string[] args)
	{
		//Fill your code
		
		Console.WriteLine("Enter the Customer Details");
		Console.WriteLine("Enter the name");
		string name = Console.ReadLine();
		Console.WriteLine("Enter the email");
		string email = Console.ReadLine();
		Console.WriteLine("Enter the type");
		string type = Console.ReadLine();
		Console.WriteLine("Enter the location");
		string location = Console.ReadLine();

		Customer customer = new Customer(name, email, type, location);
		customer.DisplayDetails();
	}
}

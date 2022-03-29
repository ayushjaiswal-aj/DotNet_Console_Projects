using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Enter Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter UserName");
        string username = Console.ReadLine();
        Console.WriteLine("Enter Password");
        string password = Console.ReadLine();
        Console.WriteLine("Enter PhoneNumber");
        long phoneNumber = Convert.ToInt64(Console.ReadLine());
		//Fill your code here
        User user = new User(name, username, password, phoneNumber);

        Console.WriteLine("Enter Name");
        name = Console.ReadLine();
        Console.WriteLine("Enter UserName");
        username = Console.ReadLine();
        Console.WriteLine("Enter Password");
        password = Console.ReadLine();
        Console.WriteLine("Enter PhoneNumber");
        phoneNumber = Convert.ToInt64(Console.ReadLine());
        
        User newUser = new User(name, username, password, phoneNumber);
        if (newUser.ComparePhoneNumber(user))
        {
            Console.WriteLine("Same Users");
        }
        else
        {
            Console.WriteLine("Different User");
        }
    }
}
